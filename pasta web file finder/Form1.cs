using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Text.RegularExpressions;
using WMPLib;
using System.Diagnostics;
using System.IO;

namespace pasta_web_file_finder
{
    public partial class Form1 : Form
    {
        WebClient wc = new WebClient();
        List<Game> games = new List<Game>();
        Game currentGame;
        List<String> currentSoundTracks = new List<string>();

        public Form1()
        {
            InitializeComponent();

            FillListBySimbol("#", wc);

            for (int i = 65; i <= 90; i++)
            {
                char letter = Convert.ToChar(i);
                FillListBySimbol(letter.ToString(), wc);
            }
        }

        public void FillListBySimbol(String simbol, WebClient wc)
        {
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
                listBox1.Items.Add(game.Nome);
                currentSoundTracks.Add(game.Nome);
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            currentGame = games.Find(k => k.Nome.Equals(listBox1.SelectedItem.ToString()));
            currentGame.LoadMusics(wc);
            listBox2.Items.Clear();
            foreach (KeyValuePair<string, string> kvp in currentGame.Tracks)
            {
                
                listBox2.Items.Add(kvp.Key);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox1.Items.Clear();
            foreach(string s in currentSoundTracks.Where(k => k.ToLower().Contains(textBox1.Text.ToLower())))
            {
                listBox1.Items.Add(s);
            }
            listBox1.Visible = true;
        }

        private void DownloadCurrentTrack()
        {
            currentGame.Download(wc, currentGame.Tracks[listBox2.SelectedItem.ToString()]);
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
    }
}
