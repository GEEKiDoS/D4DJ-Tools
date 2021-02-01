using D4DJ_Tools.Masters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace MusicRenamer
{
    class Program
    {
        static Dictionary<int, MusicMasterExt> musicMaster;
        static Dictionary<int, UnitMaster> unitMaster;

        static void ProcessFileSystemEntry(FileSystemInfo fileSystemInfo)
        {
            if (fileSystemInfo is DirectoryInfo directoryInfo)
            {
                foreach (var fsi in directoryInfo.GetFileSystemInfos())
                    ProcessFileSystemEntry(fsi);
            }
            else if (fileSystemInfo is FileInfo fileInfo)
            {
                if (fileInfo.Name == "MusicMaster.json")
                {
                    musicMaster = JsonConvert.DeserializeAnonymousType(File.ReadAllText(fileInfo.FullName), musicMaster);
                }
                else if (fileInfo.Name == "UnitMaster.json")
                {
                    unitMaster = JsonConvert.DeserializeAnonymousType(File.ReadAllText(fileInfo.FullName), unitMaster);
                }
                else if (fileInfo.Extension == ".mp3" && fileInfo.Name.StartsWith("music_"))
                {
                    int mid = int.Parse(fileInfo.Name.Replace("music_", "").Replace(".mp3", ""));

                    if (!musicMaster.ContainsKey(mid))
                        return;

                    var musicInfo = musicMaster[mid];
                    musicInfo.FindMyUnit(unitMaster);

                    var file = TagLib.File.Create(fileInfo.FullName);

                    file.Tag.Title = musicInfo.Name;

                    static string[] SplitArtistNames(string str)
                    {
                        // hack for DJ'TEKINA//SOMETHING
                        str.Replace("//", "👴");

                        if (str.Contains("、"))
                            return str.Split('、');
                        else if (str.Contains("/"))
                            return str.Split('/');
                        else return new string[] { str.Replace("👴", "//") };
                    }

                    if (musicInfo.__UnitPrimaryKey__ == 30)
                    {
                        file.Tag.Performers = new string[] { musicInfo.SpecialUnitName };
                    }
                    else if (musicInfo.__UnitPrimaryKey__ == 50)
                    {
                        List<string> ps = new();

                        ps.AddRange(SplitArtistNames(musicInfo.Arranger.Replace("(Elements Garden)", "")));
                        ps.AddRange(SplitArtistNames(musicInfo.Composer.Replace("(Elements Garden)", "")));
                        ps.AddRange(SplitArtistNames(musicInfo.Lyrist.Replace("(Elements Garden)", "")));

                        file.Tag.Performers = ps.Distinct().ToArray();
                    }
                    else
                    {
                        file.Tag.Performers = new string[] { musicInfo.Unit.Name };
                    }

                    file.Tag.Conductor = musicInfo.Arranger;
                    file.Tag.Composers = SplitArtistNames(musicInfo.Composer);
                    file.Tag.BeatsPerMinute = (uint)musicInfo.MusicBpm;
                    file.Tag.Year = (uint)musicInfo.StartDate.Year;

                    file.Tag.Album = $"D4DJ Groovy Mix - {musicInfo.Category}";
                    file.Tag.AlbumArtists = new string[] { "Bushiroad" };

                    file.Save();

                    var fileName = musicInfo.Name.Replace(':', '：')
                                                 .Replace('*', '＊')
                                                 .Replace('?', '？')
                                                 .Replace('"', '＂');

                    fileName += $" - {string.Join(',', file.Tag.Performers)}";

                    Console.WriteLine($"Renaming {fileInfo.Name} to {fileName}.mp3");

                    fileInfo.MoveTo($"{fileInfo.FullName.Replace(fileInfo.Name, fileName)}.mp3");
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
