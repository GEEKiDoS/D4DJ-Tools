using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace AssetDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourceList = JsonConvert.DeserializeObject<Dictionary<string, (int, int)>>(
                File.ReadAllText("iOSResourceList.json")
            );

            var baseAddr = "https://resources.d4dj-groovy-mix.com/b0f8db461938dd9fa9e083c9914b738b8397bd4d/";

            using WebClient wc = new();
            wc.Headers[HttpRequestHeader.UserAgent] = "d4dj/1 CFNetwork/1209 Darwin/20.2.0";
            wc.Headers["Host"] = "resources.d4dj-groovy-mix.com";
            wc.Headers["X-Unity-Version"] = "2019.4.1f1";

            wc.Proxy = new WebProxy
            {
                Address = new Uri("http://127.0.0.1:1080")
            };

            foreach(var file in resourceList.Keys)
            {
                if (!Directory.Exists("assets/" + Path.GetDirectoryName(file)))
                    Directory.CreateDirectory("assets/" + Path.GetDirectoryName(file));

                var ext = ".enc";

                if (file.StartsWith("plain"))
                    ext = "";

                if (File.Exists($"assets/{file}{ext}") || !file.Contains("MusicMaster"))
                    continue;

                Console.WriteLine($"Downloading {file}");
                wc.DownloadFile($"{baseAddr}{file}{ext}", $"assets/{file}{ext}");
            }

            
        }
    }
}
