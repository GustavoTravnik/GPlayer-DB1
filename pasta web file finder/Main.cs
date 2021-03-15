using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WMPLib;
using System.Threading;
using System.Drawing;

namespace pasta_web_file_finder
{
    public partial class Main : Form
    {
        WebClient wc = new WebClient();
        List<Source> games = new List<Source>();
        Source currentGame;
        List<String> currentSoundTracks = new List<string>();
        List<String> listMusicOst = new List<string>();
        List<String> sourceListAll = new List<string>();
        volatile int activeThreads = 0;
        private static readonly Object LOCKER = new object();
        Thread filterThread;
        public static String OST_LIST_DUMP = Path.Combine(Application.StartupPath, "OSTDUMP.dmp");
        Control selectedControl;

        public Main()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            txtF1.ReadOnly = true;
            CreateLoadOn();

            if (File.Exists(OST_LIST_DUMP))
            {
                foreach (String s in File.ReadAllLines(OST_LIST_DUMP))
                {
                    Source game = new Source(s, wc);
                    games.Add(game);
                    Invoke(new MethodInvoker(() => AddItemToListBox1(new object[] { game.Nome })));
                    currentSoundTracks.Add(game.Nome);
                }

                DestroyLoadOn();
                txtF1.ReadOnly = false;
                AdjustScreen();
            }
            else
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(FillListBySimbol), new Object[] { "#" });
                for (int i = 65; i <= 90; i++)
                {
                    char letter = Convert.ToChar(i);
                    ThreadPool.QueueUserWorkItem(new WaitCallback(FillListBySimbol), new Object[] { letter.ToString() });
                }
            }
        }

        private void CreateLoadOn()
        {
            panelGeral.Enabled = false;
            loadPicture.Size = panelGeral.Size;
            loadPicture.Location = panelGeral.Location;
            loadPicture.Visible = true;
            loadPicture.BringToFront();
        }

        private void DestroyLoadOn()
        {
            panelGeral.Enabled = true;
            loadPicture.Visible = false;
        }

        ///game-soundtracks/album/donkey-kong-country-3-dixie-kong-s-double-trouble-gba/Arich%2520Boss.mp3
        public void FillListBySimbol(Object args)
        {
            activeThreads++;
            String simbol = (String)((Object[])args)[0];
            WebClient wc = new WebClient();
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            String source = (wc.DownloadString("https://downloads.khinsider.com/game-soundtracks/browse/" + simbol));
            source = Regex.Split(source, "<p align=\"left\">")[1];
            String[] sourceParts = Regex.Split(source, "<a href=\"");
            sourceParts = sourceParts.Where(k => k.StartsWith("/game-soundtracks") && k.Contains("album")).ToArray();
            for (int i = 0; i < sourceParts.Length; i++)
            {
                sourceParts[i] = "https://downloads.khinsider.com" + sourceParts[i].Split('"')[0];
            }

            foreach(String s in sourceParts)
            {
                sourceListAll.Add(s);
                Source game = new Source(s, wc);
                games.Add(game);
                Invoke(new MethodInvoker(() => AddItemToListBox1(new object[] { game.Nome })));
                currentSoundTracks.Add(game.Nome);
            }

            activeThreads--;

            if (activeThreads == 0)
            {
                Invoke(new MethodInvoker(() => DestroyLoadOn()));
                txtF1.ReadOnly = false;
                File.WriteAllLines(OST_LIST_DUMP, sourceListAll);
                sourceListAll.Clear();
            }
        }

        private void AddItemToListBox1(Object[] args)
        {
            lstSiteOSTS1.Items.Add((String)args[0]);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            ThreadPool.QueueUserWorkItem(new WaitCallback(LoadMusicsBySelectedGame), new Object());
        }

        private void LoadMusicsBySelectedGame(Object args)
        {
            Invoke(new MethodInvoker(() => CreateLoadOn()));
            currentGame = games.Find(k => k.Nome.Equals(lstSiteOSTS1.SelectedItem.ToString()));
            currentGame.LoadMusics(wc);
            lstMusicsOST2.Items.Clear();
            listMusicOst.Clear();
            foreach (KeyValuePair<string, string> kvp in currentGame.Tracks)
            {
                lstMusicsOST2.Items.Add(kvp.Key);
                listMusicOst.Add(kvp.Key);
            }
            Invoke(new MethodInvoker(() => DestroyLoadOn()));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtF1.Text))
            {
                txtF1.Text = "Pesquisa nome OST";
            }
        }

        private void ApplyFilter()
        {
            lock (LOCKER)
            {               
                CreateLoadOn();
                lstSiteOSTS1.Visible = false;
                lstSiteOSTS1.Items.Clear();
                foreach (string s in currentSoundTracks.Where(k => k.ToLower().Contains(txtF1.Text.ToLower())))
                {
                    lstSiteOSTS1.Items.Add(s);
                }
                lstSiteOSTS1.Visible = true;
                DestroyLoadOn();
            }
        }

        private void DownloadCurrentTrack()
        {
            Downloader download = new Downloader(new List<string>(){ lstMusicsOST2.SelectedItem.ToString() }, currentGame);
            download.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadCurrentTrack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(Path.Combine(Application.StartupPath, "OST"));
            Process.Start("\"" + Path.Combine(Application.StartupPath, "OST") + "\"");
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (lstMusicsOST2.Items.Count > 0)
                player.URL = currentGame.Tracks[lstMusicsOST2.SelectedItem.ToString()];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsStopped && checkBox1.Checked)
            {
                if (lstMusicsOST2.SelectedIndex < lstMusicsOST2.Items.Count - 1)
                {
                    lstMusicsOST2.SelectedIndex = lstMusicsOST2.SelectedIndex + 1;
                    listBox2_DoubleClick(sender, e);
                }
            }
        }

        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            Text = "KHInsider Music Player - " + currentGame.Nome + " / " + player.Ctlcontrols.currentItem.name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<String> lista = new List<string>();
            foreach(String s in lstMusicsOST2.Items)
            {
                lista.Add(s);
            }
            Downloader download = new Downloader(lista, currentGame);
            download.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            lstMusicsOST2.Items.Clear();
            foreach (string s in listMusicOst)
            {
                if (s.Contains(txtF2.Text))
                {
                    lstMusicsOST2.Items.Add(s);
                }
            }
        }

        private void txtF1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                filterThread?.Abort();
                filterThread = new Thread(() => ApplyFilter());
                filterThread.IsBackground = true;
                filterThread.Start();
            }
        }

        private void txtF1_Click(object sender, EventArgs e)
        {
            txtF1.Text = "";
        }

        private void txtF2_Click(object sender, EventArgs e)
        {
            txtF2.Text = "";
        }

        private void AdjustScreen()
        {
            txtF1.Location = new Point(0, 0);
            txtF1.Width = panelGeral.Width / 2;
            txtF2.Location = new Point(txtF1.Width, 0);
            txtF2.Width = panelGeral.Width / 2;
            
            lstSiteOSTS1.Location = new Point(0, txtF1.Height);
            lstMusicsOST2.Location = new Point(txtF2.Left, txtF2.Height);
            lstSiteOSTS1.Size = new Size(txtF1.Width, panelGeral.Height - (txtF1.Height * 2));
            lstMusicsOST2.Size = new Size(txtF1.Width, panelGeral.Height - (txtF2.Height * 2));

            btnDownloadOst1.Height = txtF1.Height;
            btnDownloadOst1.Location = new Point(0, lstSiteOSTS1.Bottom);
            btnDownloadOst1.Width = lstSiteOSTS1.Width;

            btnDownloadMusica2.Size = new Size(lstMusicsOST2.Width/2, txtF1.Height);
            btnDownloadAlbum3.Size = new Size(lstMusicsOST2.Width/2, txtF1.Height);

            btnDownloadMusica2.Location = new Point(lstMusicsOST2.Left, lstMusicsOST2.Bottom);
            btnDownloadAlbum3.Location = new Point(lstMusicsOST2.Left + lstMusicsOST2.Width / 2, lstMusicsOST2.Bottom);
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            AdjustScreen();
        }

        private void seekTimer_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                var unitTotal = pic_trackbar.Width / player.currentMedia.duration;
                var currentLocation = player.Ctlcontrols.currentPosition * unitTotal;
                pic_currentPos.Left = (int)(pic_trackbar.Left + currentLocation) - pic_currentPos.Width / 2;

                lblTime.Text = player.Ctlcontrols.currentPositionString;
            }
        }

        private void pic_trackbar_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying || player.playState == WMPPlayState.wmppsPaused || player.playState == WMPPlayState.wmppsStopped)
            {
                var position = Control.MousePosition.X - Left;
                var unitTotal =  player.currentMedia.duration / pic_trackbar.Width;
                var futurePosition = position - pic_trackbar.Left - 8;
                player.Ctlcontrols.currentPosition = futurePosition * unitTotal;
            }            
        }

        private void picPlayPause_Click(object sender, EventArgs e)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                player.Ctlcontrols.pause();
            }
            else if (player.playState == WMPPlayState.wmppsPaused)
            {
                player.Ctlcontrols.play();
            }            
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackVolume.Value;
        }
    }
}
