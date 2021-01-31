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
        static void DecryptMaster(FileInfo inputFile)
        {
            var typeName = inputFile.Name.Replace(".msgpack.enc", "");
            var targetType = MasterTypes.GetDeserializeType(typeName);

            if (targetType == null)
            {
                Console.WriteLine($"Not supported master {typeName}.");
                return;
            }

            var decrypted = AssetDecryptor.Decrypt(inputFile.OpenRead());

            var options = MessagePackSerializerOptions.Standard.WithCompression(MessagePackCompression.Lz4Block);
            var result = MessagePackSerializer.Deserialize(targetType, decrypted, options);

            File.WriteAllText(
                inputFile.FullName.Replace(".msgpack.enc", ".json"),
                JsonConvert.SerializeObject(result, Formatting.Indented, new StringEnumConverter())
            );

            Console.WriteLine($"Success.");
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
                // Dump master
                if (fileInfo.Name.EndsWith("Master.msgpack.enc"))
                {
                    Console.WriteLine($"Dumping {fileInfo.Name} into json...");
                    DecryptMaster(fileInfo);
                }
                // Decrypt enc file
                else if (fileInfo.Extension == ".enc")
                {
                    Console.WriteLine($"Decrypting {fileInfo.Name}...");
                    var decrypted = AssetDecryptor.Decrypt(fileInfo.OpenRead());
                    File.WriteAllBytes(fileInfo.FullName.Replace(".enc", ""), decrypted);

                    Console.WriteLine($"Success.");
                }
                // Dump Resource List
                else if(fileInfo.Name.EndsWith("ResourceList.msgpack"))
                {
                    Console.WriteLine($"Dumping {fileInfo.Name} into json...");

                    var options = MessagePackSerializerOptions.Standard.WithCompression(MessagePackCompression.Lz4Block);
                    var result = MessagePackSerializer.Deserialize<Dictionary<string, int>>(
                        File.ReadAllBytes(fileInfo.FullName), 
                        options
                    );

                    File.WriteAllText(
                        fileInfo.FullName.Replace(".msgpack", ".json"),
                        JsonConvert.SerializeObject(result, Formatting.Indented, new StringEnumConverter())
                    );

                    Console.WriteLine($"Success.");
                }
            }
        }

        static void Main(string[] args)
        {
            foreach(var arg in args)
            {
                if(Directory.Exists(arg))
                {
                    ProcessFileSystemEntry(new DirectoryInfo(arg));
                }
                else if(File.Exists(arg))
                {
                    ProcessFileSystemEntry(new FileInfo(arg));
                }
            }
        }
    }
}
