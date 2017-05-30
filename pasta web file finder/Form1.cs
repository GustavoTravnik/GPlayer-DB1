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

namespace pasta_web_file_finder
{
    public partial class Form1 : Form
    {
        WebClient wc = new WebClient();
        List<Game> games = new List<Game>();
        Game currentGame;
        List<String> currentSoundTracks = new List<string>();
        volatile int activeThreads = 0;
        private static readonly Object LOCKER = new object();
        Thread filterThread;

        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            CreateLoadOn(listBox1);
            ThreadPool.QueueUserWorkItem(new WaitCallback(FillListBySimbol), new Object[] { "#" });

            for (int i = 65; i <= 90; i++)
            {
                char letter = Convert.ToChar(i);
                ThreadPool.QueueUserWorkItem(new WaitCallback(FillListBySimbol), new Object[] { letter.ToString() });
            }
        }

        private void CreateLoadOn(Control control)
        {
            loadPicture.BackColor = System.Drawing.Color.Black;
            loadPicture.Size = control.Size;
            loadPicture.Location = control.Location;
            loadPicture.Visible = true;
            loadPicture.BringToFront();
        }

        private void DestroyLoadOn(Control control)
        {
            loadPicture.Visible = false;
        }

        public void FillListBySimbol(Object args)
        {
            activeThreads++;
            String simbol = (String)((Object[])args)[0];
            WebClient wc = new WebClient();
            String source = (wc.DownloadString("https://downloads.khinsider.com/game-soundtracks/browse/" + simbol));
            source = Regex.Split(source, "<p align=\"left\">")[1];
            String[] sourceParts = Regex.Split(source, "<a href=\"");
            sourceParts = sourceParts.Where(k => k.StartsWith("http") && k.Contains("album")).ToArray();
            for (int i = 0; i < sourceParts.Length; i++)
            {
                sourceParts[i] = sourceParts[i].Split('"')[0];
            }

            foreach(String s in sourceParts)
            {
                Game game = new Game(s, wc);
                games.Add(game);
                Invoke(new MethodInvoker(() => AddItemToListBox1(new object[] { game.Nome })));
                currentSoundTracks.Add(game.Nome);
            }
            activeThreads--;

            if (activeThreads == 0)
            {
                Invoke(new MethodInvoker(() => DestroyLoadOn(listBox1)));
            }
        }

        private void AddItemToListBox1(Object[] args)
        {
            listBox1.Items.Add((String)args[0]);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
            ThreadPool.QueueUserWorkItem(new WaitCallback(LoadMusicsBySelectedGame), new Object());
        }

        private void LoadMusicsBySelectedGame(Object args)
        {
            Invoke(new MethodInvoker(() => CreateLoadOn(listBox2)));
            currentGame = games.Find(k => k.Nome.Equals(listBox1.SelectedItem.ToString()));
            currentGame.LoadMusics(wc);
            listBox2.Items.Clear();
            foreach (KeyValuePair<string, string> kvp in currentGame.Tracks)
            {

                listBox2.Items.Add(kvp.Key);
            }
            Invoke(new MethodInvoker(() => DestroyLoadOn(listBox2)));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            filterThread?.Abort();
            filterThread = new Thread(() => ApplyFilter());
            filterThread.IsBackground = true;
            filterThread.Start();
        }

        private void ApplyFilter()
        {
            lock (LOCKER)
            {
                CreateLoadOn(listBox1);
                listBox1.Visible = false;
                listBox1.Items.Clear();
                foreach (string s in currentSoundTracks.Where(k => k.ToLower().Contains(textBox1.Text.ToLower())))
                {
                    listBox1.Items.Add(s);
                }
                listBox1.Visible = true;
                DestroyLoadOn(listBox1);
            }
        }

        private void DownloadCurrentTrack()
        {
            Downloader download = new Downloader(new List<string>(){ listBox2.SelectedItem.ToString() }, currentGame);
            download.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DownloadCurrentTrack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("\"" + Path.Combine(Application.StartupPath, "OST") + "\"");
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
                axWindowsMediaPlayer1.URL = currentGame.Tracks[listBox2.SelectedItem.ToString()];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsStopped)
            {
                if (listBox2.SelectedIndex < listBox2.Items.Count - 1)
                {
                    listBox2.SelectedIndex = listBox2.SelectedIndex + 1;
                    listBox2_DoubleClick(sender, e);
                }
            }
        }

        private void axWindowsMediaPlayer1_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            Text = "NP - " + axWindowsMediaPlayer1.Ctlcontrols.currentItem.name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<String> lista = new List<string>();
            foreach(String s in listBox2.Items)
            {
                lista.Add(s);
            }
            Downloader download = new Downloader(lista, currentGame);
            download.ShowDialog();
        }
    }
}
