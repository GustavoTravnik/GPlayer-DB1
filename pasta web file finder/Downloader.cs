using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pasta_web_file_finder
{
    public partial class Downloader : Form
    {

        WebClient wc = new WebClient();
        List<String> tracks;
        Source currentGame;
        int totalFiles = 0;

        public Downloader(List<String> tracks, Source currentGame)
        {
            InitializeComponent();

            this.totalFiles = tracks.Count;
            progressBar1.Maximum = totalFiles;
            this.tracks = tracks;
            this.currentGame = currentGame;
            wc.DownloadProgressChanged += Wc_DownloadProgressChanged;
            wc.DownloadFileCompleted += Wc_DownloadFileCompleted;
            DownloadNext();
        }

        private void DownloadNext()
        {
            if (tracks.Any())
            {
                Text = "Download " + (totalFiles - tracks.Count).ToString() + " de " + totalFiles.ToString();
                label1.Text = tracks[0];
               // Directory.CreateDirectory(Path.Combine(Application.StartupPath, "OST", currentGame.Nome));
               // wc.DownloadFileAsync(new Uri(currentGame.Tracks[tracks[0]]), Path.Combine(Application.StartupPath, "OST", currentGame.Nome, tracks[0].Split('/')[tracks[0].Split('/').Length - 1].Replace('-', ' ')));
                currentGame.Download(ref wc, currentGame.Tracks[tracks[0]]);
                tracks.Remove(tracks[0]);
            }
            else
            {
                Close();
            }
        }

        private void Wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            progressBar1.Value++;
            DownloadNext();
        }

        private void Wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar2.Value = e.ProgressPercentage;
        }
    }
}
