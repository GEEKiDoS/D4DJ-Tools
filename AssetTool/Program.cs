using D4DJ_Tools.Masters;
using MessagePack;
using MessagePack.Resolvers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace D4DJ_Tools
{
    class Program
    {
        static bool DecryptMaster(FileInfo inputFile, byte[] decrypted)
        {
            var typeName = inputFile.Name.Replace(".msgpack.enc", "");
            var targetType = MasterTypes.GetDeserializeType(typeName);

            if (targetType == null)
            {
                Console.WriteLine($"Not supported master {typeName}.");
                return false;
            }

            var options = MessagePackSerializerOptions.Standard.WithCompression(MessagePackCompression.Lz4Block);
            var result = MessagePackSerializer.Deserialize(targetType, decrypted, options);

            File.WriteAllText(
                inputFile.FullName.Replace(".msgpack.enc", ".json"),
                DumpToJson(result)
            );

            return true;
        }

        static T DeserializeMsgPack<T> (byte[] decrypted)
        {
            var options = MessagePackSerializerOptions.Standard.WithCompression(MessagePackCompression.Lz4Block);
            return MessagePackSerializer.Deserialize<T>(decrypted, options);
        }

        static byte[] SerializeMsgPack(object obj)
        {
            var options = MessagePackSerializerOptions.Standard.WithCompression(MessagePackCompression.Lz4Block);
            return MessagePackSerializer.Serialize(obj, options);
        }

        static string DumpToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented, new StringEnumConverter());
        }

        static void EncryptMaster(FileInfo inputFile)
        {
            var typeName = inputFile.Name.Replace(".json", "");
            var targetType = MasterTypes.GetDeserializeType(typeName);

            if (targetType == null)
            {
                Console.WriteLine($"Not supported master {typeName}.");
                return;
            }

            var options = MessagePackSerializerOptions.Standard.WithCompression(MessagePackCompression.Lz4Block);
            var result = JsonConvert.DeserializeObject(File.ReadAllText(inputFile.FullName), targetType);
            var output = MessagePackSerializer.Serialize(result, options);
            var encrypted = AssetDecryptor.Encrypt(output);

            File.WriteAllBytes(inputFile.FullName.Replace(".json", ".msgpack.enc"), encrypted);
        }

        static void ProcessFileSystemEntry(FileSystemInfo fileSystemInfo)
        {
            if (fileSystemInfo is DirectoryInfo directoryInfo)
            {
                foreach (var fsi in directoryInfo.GetFileSystemInfos())
                    ProcessFileSystemEntry(fsi);
            }
            else if (fileSystemInfo is FileInfo fileInfo)
            {
                if(fileInfo.Extension == ".enc")
                {
                    Console.WriteLine($"Decrypting {fileInfo.Name}...");
                    var decrypted = AssetDecryptor.Decrypt(fileInfo.OpenRead());

                    var success = false;

                    if (fileInfo.Name.EndsWith("Master.msgpack.enc"))
                    {
                        success = DecryptMaster(fileInfo, decrypted);
                    }
                    else if (fileInfo.Name.StartsWith("chart_"))
                    {
                        Console.WriteLine("Dumping chart...");

                        try
                        {
                            object result = null;

                            // Check if this is chart common data
                            if(fileInfo.Name.EndsWith("0.enc"))
                                result= DeserializeMsgPack<ChartCommonData>(decrypted);
                            else
                                result = DeserializeMsgPack<ChartData>(decrypted);
 
                            File.WriteAllText(
                                fileInfo.FullName.Replace(".enc", ".json"),
                                DumpToJson(result)
                            );

                            success = true;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine($"Failed to dump chart: {ex.Message}");
                        }
                    }
                    else if(fileInfo.Name.EndsWith("ResourceList.msgpack.enc"))
                    {
                        Console.WriteLine($"Dumping ResourceList...");

                        var result = DeserializeMsgPack<Dictionary<string, (int, int)>>(decrypted);

                        File.WriteAllText(
                            fileInfo.FullName.Replace(".msgpack.enc", ".json"),
                            DumpToJson(result)
                        );

                        success = true;
                    }

                    if (!success)
                    {
                        Console.WriteLine($"Writing decrypted file...");
                        File.WriteAllBytes(fileInfo.FullName.Replace(".enc", ""), decrypted);
                    }

                    Console.WriteLine($"Success!");
                }
                else if (fileInfo.Name.EndsWith("ResourceList.msgpack"))
                {
                    
                    try
                    {
                        var result = DeserializeMsgPack<Dictionary<string, int>>(File.ReadAllBytes(fileInfo.FullName));

                        File.WriteAllText(
                            fileInfo.FullName.Replace(".msgpack", ".json"),
                            DumpToJson(result)
                        );

                        Console.WriteLine($"Success!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed to dump resource list: {ex.Message}");
                    }
                }
                else if (fileInfo.Name.EndsWith("ResourceList.json"))
                {
                    try
                    {
                        var result = SerializeMsgPack(
                            JsonConvert.DeserializeObject<Dictionary<string, int>>(
                                File.ReadAllText(fileInfo.FullName)
                            )
                        );

                        File.WriteAllBytes(
                            fileInfo.FullName.Replace(".json", ".msgpack"),
                            result
                        );

                        Console.WriteLine($"Success!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed to dump resource list: {ex.Message}");
                    }
                }
                // Encrypt master back
                else if(fileInfo.Name.EndsWith("Master.json"))
                {
                    Console.WriteLine($"Encrypting {fileInfo.Name}...");
                    EncryptMaster(fileInfo);
                }
                else
                {
                    Console.WriteLine($"Encrypting {fileInfo.Name}...");

                    File.WriteAllBytes(
                        fileInfo.FullName + ".enc",
                        AssetDecryptor.Encrypt(File.ReadAllBytes(fileInfo.FullName))
                    );
                }
            }
        }

        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                if (Directory.Exists(arg))
                {
                    ProcessFileSystemEntry(new DirectoryInfo(arg));
                }
                else if (File.Exists(arg))
                {
                    ProcessFileSystemEntry(new FileInfo(arg));
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
