using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace pasta_web_file_finder
{
    public class Game
    {
        private string url = String.Empty;
        public string Nome { get; set; } = string.Empty;
        public Dictionary<string, string> Tracks { get; set; } = new Dictionary<string, string>();
        public String OST_LIST_DUMP = (Application.StartupPath);

        public Game(String url, WebClient wc)
        {
            this.url = url;
            Nome = url.Split('/')[url.Split('/').Length - 1].Replace('-', ' ');
            OST_LIST_DUMP = Path.Combine(OST_LIST_DUMP, Nome + ".dmp");
        }

        public void LoadMusics(WebClient wc)
        {
            if (!Tracks.Any())
            {
                if (File.Exists(OST_LIST_DUMP))
                {
                    foreach (string s in File.ReadAllLines(OST_LIST_DUMP))
                    {
                        Tracks.Add(s.Split('/')[s.Split('/').Length - 1].Replace('-', ' ').Replace("%20", " "), s);
                    }
                }
                else
                {
                    String source = wc.DownloadString(url);
                    String[] sourceList = Regex.Split(source, "<a href=\"");
                    sourceList = sourceList.Where(k => k.Contains(".mp3") && !k.Contains("forums/member")).ToArray();
                    for (int i = 0; i < sourceList.Length; i++)
                    {
                        sourceList[i] = sourceList[i].Split('"')[0];
                    }

                    sourceList = (from d in sourceList select d).Distinct().ToArray();

                    for (int i = 0; i < sourceList.Length; i++)
                    {
                        sourceList[i] = ResolveFileName(sourceList[i], wc);
                    }

                    foreach (string s in sourceList)
                    {
                        Tracks.Add(s.Split('/')[s.Split('/').Length - 1].Replace('-', ' ').Replace("%20", " "), s);
                    }

                    File.WriteAllLines(OST_LIST_DUMP, sourceList);
                }
            }
        }

        public void Download(ref WebClient wc, String track)
        {
            Directory.CreateDirectory(Path.Combine(Application.StartupPath, "OST", Nome));
            wc.DownloadFileAsync(new Uri(track), Path.Combine(Application.StartupPath, "OST", Nome, track.Split('/')[track.Split('/').Length - 1].Replace('-', ' ')));
        }

        public String ResolveFileName(String url, WebClient wc)
        {
            String source = wc.DownloadString(url);
            String[] sourceList = Regex.Split(source, "src=\"");
            for (int i = 0; i < sourceList.Length; i++)
            {
                sourceList[i] = sourceList[i].Split('"')[0];
            }
            sourceList = sourceList.Where(k => k.Contains(".mp3") && k.Contains("/ost/")).ToArray();
           

            return sourceList[0];
        }
    }
}
