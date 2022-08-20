using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

string CleanType(string str)
{
    int depth = 0;

    int len = 0;

    foreach (var ch in str)
    {
        if (ch == '<')
            ++depth;
        else if (ch == '>')
            --depth;

        if (depth == 0)
            break;

        ++len;
    }

    return str.Substring(0, len + 1);
}

List<string> depEnums = new();
string enumCode = null;

Dictionary<string, string> foundedMasters = new();
Dictionary<string, string> masterTypes = new();

Regex masterRE = new("public class (.*Master) : MasterBase(<.*, .*>)");
Regex typeRE = new("public (.*?) .*? \\{ get; set; \\}");
Regex enumRE = new("public enum (.*) //");
Regex enumMemberRE = new("public const .*? (.*?);");

using (StreamReader sr = new("dump.cs"))
{
    // Search masters
    while(!sr.EndOfStream)
    {
        var line = sr.ReadLine();
        var m = masterRE.Match(line);

        if(m.Success)
        {
            var masterName = m.Groups[1].Value;
            var masterType = m.Groups[2].Value;

            masterTypes.Add(masterName, masterType);

            StringBuilder codeBuilder = new();

            codeBuilder.AppendLine("using MessagePack;\r\nusing System;\r\n");
            codeBuilder.AppendLine("namespace D4DJ_Tools.Masters\r\n{");

            codeBuilder.AppendLine("\t[MessagePackObject]");
            codeBuilder.AppendLine($"\tpublic class {masterName}");
            codeBuilder.AppendLine("\t{");
            {
                int attrIndex = 0;

                for(string attr = sr.ReadLine(); attr != "}"; attr = sr.ReadLine())
                {
                    if(attr.Contains("[Key"))
                    {
                        codeBuilder.AppendLine($"\t\t[Key({attrIndex++})]");
                        var prop = sr.ReadLine();

                        var typeMatch = typeRE.Match(prop);
                        var type = typeMatch.Groups[1].Value;

                        switch (type)
                        {
                            case "bool":
                            case "bool[]":
                            case "int":
                            case "int[]":
                            case "long":
                            case "long[]":
                            case "string":
                            case "string[]":
                            case "float":
                            case "float[]":
                            case "DateTime":
                            case "DateTime[]":
                                break;
                            default:
                                depEnums.Add(type.Replace("[]", ""));
                                break;
                        }

                        codeBuilder.AppendLine($"\t{prop}");
                    }
                }
            }

            codeBuilder.AppendLine("\t}\r\n}\r\n");

            var code = codeBuilder.ToString();

            foundedMasters.Add(masterName, code);
            Console.WriteLine($"{masterName} - {masterType}");
        }
    }

    Console.WriteLine();

    depEnums = depEnums.Distinct().ToList();

    // Search enums
    if(depEnums.Count != 0)
    {
        sr.BaseStream.Position = 0;

        StringBuilder codeBuilder = new();

        codeBuilder.AppendLine("namespace D4DJ_Tools.Masters\r\n{");

        var prevLine = "";

        while (!sr.EndOfStream)
        {
            var line = sr.ReadLine();

            if(prevLine == "// Namespace: UnityEngine"){
                prevLine = "";
                continue;
            }

            var m = enumRE.Match(line);

            if (m.Success)
            {
                var typeName = m.Groups[1].Value;

                if (depEnums.Contains(typeName))
                {
                    depEnums.Remove(typeName);

                    codeBuilder.AppendLine($"\tpublic enum {typeName}\r\n\t{{");

                    for (string code = sr.ReadLine(); code != "}"; code = sr.ReadLine())
                    {
                        var m1 = enumMemberRE.Match(code);

                        if(m1.Success)
                        {
                            codeBuilder.AppendLine($"\t\t{m1.Groups[1].Value},");
                        }
                    }

                    codeBuilder.AppendLine("\t}\r\n");
                }
            }
            prevLine = line;
        }

        codeBuilder.AppendLine("}");
        enumCode = codeBuilder.ToString();

        if(depEnums.Count != 0)
        {
            Console.WriteLine("Warning: not all enums are founded.");
        }
    }
}

StringBuilder codeBuilder = new();
codeBuilder.AppendLine("using System;\r\nusing System.Collections.Generic;\r\n\r\nnamespace D4DJ_Tools.Masters\r\n{");
codeBuilder.AppendLine("\tpublic static partial class MasterTypes\r\n\t{");
codeBuilder.AppendLine("\t\tprivate static Dictionary<string, Type> specialTypes = new Dictionary<string, Type>\r\n\t\t{");

foreach(var masterType in masterTypes)
{
    var cleaned = CleanType(masterType.Value);

    if (cleaned == $"<int, {masterType.Key}>")
        continue;

    codeBuilder.AppendLine($"\t\t\t{{ \"{masterType.Key}\", typeof(Dictionary{cleaned}) }},");
}

codeBuilder.AppendLine("\t\t};\r\n\t}\r\n}");
var typeCode = codeBuilder.ToString();

if (Directory.Exists("../D4DJ.Types/CodeGen"))
    Directory.Delete("../D4DJ.Types/CodeGen", true);

Directory.CreateDirectory("../D4DJ.Types/CodeGen");
File.WriteAllText("../D4DJ.Types/CodeGen/D4DJEnums.cs", enumCode);
File.WriteAllText("../D4DJ.Types/CodeGen/MasterTypes.Generated.cs", typeCode);

Directory.CreateDirectory("../D4DJ.Types/CodeGen/Masters");

foreach(var master in foundedMasters)
{
    File.WriteAllText($"../D4DJ.Types/CodeGen/Masters/{master.Key}.cs", master.Value);
}