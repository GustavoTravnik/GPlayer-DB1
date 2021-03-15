namespace pasta_web_file_finder
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lstSiteOSTS1 = new System.Windows.Forms.ListBox();
            this.lstMusicsOST2 = new System.Windows.Forms.ListBox();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.btnDownloadMusica2 = new System.Windows.Forms.Button();
            this.btnDownloadOst1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnDownloadAlbum3 = new System.Windows.Forms.Button();
            this.txtF2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelGeral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.picPlayPause = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.pic_currentPos = new System.Windows.Forms.PictureBox();
            this.pic_trackbar = new System.Windows.Forms.PictureBox();
            this.seekTimer = new System.Windows.Forms.Timer(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.loadPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panelGeral.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_currentPos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSiteOSTS1
            // 
            this.lstSiteOSTS1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstSiteOSTS1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstSiteOSTS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSiteOSTS1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSiteOSTS1.ForeColor = System.Drawing.Color.Purple;
            this.lstSiteOSTS1.FormattingEnabled = true;
            this.lstSiteOSTS1.HorizontalScrollbar = true;
            this.lstSiteOSTS1.IntegralHeight = false;
            this.lstSiteOSTS1.ItemHeight = 28;
            this.lstSiteOSTS1.Location = new System.Drawing.Point(2, 86);
            this.lstSiteOSTS1.Name = "lstSiteOSTS1";
            this.lstSiteOSTS1.ScrollAlwaysVisible = true;
            this.lstSiteOSTS1.Size = new System.Drawing.Size(439, 351);
            this.lstSiteOSTS1.Sorted = true;
            this.lstSiteOSTS1.TabIndex = 0;
            this.lstSiteOSTS1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // lstMusicsOST2
            // 
            this.lstMusicsOST2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstMusicsOST2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lstMusicsOST2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMusicsOST2.Font = new System.Drawing.Font("Segoe Print", 12F);
            this.lstMusicsOST2.ForeColor = System.Drawing.Color.Purple;
            this.lstMusicsOST2.FormattingEnabled = true;
            this.lstMusicsOST2.HorizontalScrollbar = true;
            this.lstMusicsOST2.IntegralHeight = false;
            this.lstMusicsOST2.ItemHeight = 28;
            this.lstMusicsOST2.Location = new System.Drawing.Point(450, 86);
            this.lstMusicsOST2.Name = "lstMusicsOST2";
            this.lstMusicsOST2.ScrollAlwaysVisible = true;
            this.lstMusicsOST2.Size = new System.Drawing.Size(439, 351);
            this.lstMusicsOST2.Sorted = true;
            this.lstMusicsOST2.TabIndex = 1;
            this.lstMusicsOST2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // txtF1
            // 
            this.txtF1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtF1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtF1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF1.ForeColor = System.Drawing.Color.Purple;
            this.txtF1.Location = new System.Drawing.Point(2, 57);
            this.txtF1.Name = "txtF1";
            this.txtF1.Size = new System.Drawing.Size(439, 27);
            this.txtF1.TabIndex = 2;
            this.txtF1.Text = "Pesquisa nome OST";
            this.txtF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtF1.Click += new System.EventHandler(this.txtF1_Click);
            this.txtF1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtF1_KeyDown);
            // 
            // btnDownloadMusica2
            // 
            this.btnDownloadMusica2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDownloadMusica2.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadMusica2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadMusica2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadMusica2.ForeColor = System.Drawing.Color.Purple;
            this.btnDownloadMusica2.Location = new System.Drawing.Point(450, 438);
            this.btnDownloadMusica2.Name = "btnDownloadMusica2";
            this.btnDownloadMusica2.Size = new System.Drawing.Size(215, 29);
            this.btnDownloadMusica2.TabIndex = 3;
            this.btnDownloadMusica2.Text = "Download Selected Music";
            this.btnDownloadMusica2.UseVisualStyleBackColor = false;
            this.btnDownloadMusica2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDownloadOst1
            // 
            this.btnDownloadOst1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDownloadOst1.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadOst1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadOst1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadOst1.ForeColor = System.Drawing.Color.Purple;
            this.btnDownloadOst1.Location = new System.Drawing.Point(2, 438);
            this.btnDownloadOst1.Name = "btnDownloadOst1";
            this.btnDownloadOst1.Size = new System.Drawing.Size(439, 29);
            this.btnDownloadOst1.TabIndex = 4;
            this.btnDownloadOst1.Text = "Open OSTs Folder";
            this.btnDownloadOst1.UseVisualStyleBackColor = false;
            this.btnDownloadOst1.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(2, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(886, 67);
            this.player.TabIndex = 5;
            this.player.Visible = false;
            this.player.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.axWindowsMediaPlayer1_MediaChange);
            // 
            // btnDownloadAlbum3
            // 
            this.btnDownloadAlbum3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDownloadAlbum3.BackColor = System.Drawing.Color.Transparent;
            this.btnDownloadAlbum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadAlbum3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadAlbum3.ForeColor = System.Drawing.Color.Purple;
            this.btnDownloadAlbum3.Location = new System.Drawing.Point(674, 438);
            this.btnDownloadAlbum3.Name = "btnDownloadAlbum3";
            this.btnDownloadAlbum3.Size = new System.Drawing.Size(215, 29);
            this.btnDownloadAlbum3.TabIndex = 7;
            this.btnDownloadAlbum3.Text = "Download Game Album";
            this.btnDownloadAlbum3.UseVisualStyleBackColor = false;
            this.btnDownloadAlbum3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtF2
            // 
            this.txtF2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtF2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtF2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF2.ForeColor = System.Drawing.Color.Purple;
            this.txtF2.Location = new System.Drawing.Point(450, 57);
            this.txtF2.Name = "txtF2";
            this.txtF2.Size = new System.Drawing.Size(439, 27);
            this.txtF2.TabIndex = 9;
            this.txtF2.Text = "Pesquisa nome Música";
            this.txtF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtF2.Click += new System.EventHandler(this.txtF2_Click);
            this.txtF2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(803, 34);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 22);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Auto Skip";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // panelGeral
            // 
            this.panelGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGeral.Controls.Add(this.txtF1);
            this.panelGeral.Controls.Add(this.lstSiteOSTS1);
            this.panelGeral.Controls.Add(this.txtF2);
            this.panelGeral.Controls.Add(this.lstMusicsOST2);
            this.panelGeral.Controls.Add(this.btnDownloadAlbum3);
            this.panelGeral.Controls.Add(this.btnDownloadMusica2);
            this.panelGeral.Controls.Add(this.btnDownloadOst1);
            this.panelGeral.Location = new System.Drawing.Point(0, 58);
            this.panelGeral.Name = "panelGeral";
            this.panelGeral.Size = new System.Drawing.Size(892, 519);
            this.panelGeral.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.trackVolume);
            this.panel1.Controls.Add(this.picPlayPause);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.pic_currentPos);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.pic_trackbar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 576);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 59);
            this.panel1.TabIndex = 13;
            // 
            // trackVolume
            // 
            this.trackVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackVolume.AutoSize = false;
            this.trackVolume.Location = new System.Drawing.Point(800, 11);
            this.trackVolume.Maximum = 100;
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(92, 22);
            this.trackVolume.TabIndex = 15;
            this.trackVolume.Value = 100;
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // picPlayPause
            // 
            this.picPlayPause.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPlayPause.BackColor = System.Drawing.Color.Transparent;
            this.picPlayPause.Image = global::GameWPlayer.Properties.Resources.pause_1_;
            this.picPlayPause.Location = new System.Drawing.Point(754, 11);
            this.picPlayPause.Name = "picPlayPause";
            this.picPlayPause.Size = new System.Drawing.Size(40, 40);
            this.picPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayPause.TabIndex = 14;
            this.picPlayPause.TabStop = false;
            this.picPlayPause.Click += new System.EventHandler(this.picPlayPause_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTime.Font = new System.Drawing.Font("Castellar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Blue;
            this.lblTime.Location = new System.Drawing.Point(669, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(77, 25);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "00:00";
            // 
            // pic_currentPos
            // 
            this.pic_currentPos.BackColor = System.Drawing.Color.Transparent;
            this.pic_currentPos.Image = global::GameWPlayer.Properties.Resources.image;
            this.pic_currentPos.Location = new System.Drawing.Point(12, 12);
            this.pic_currentPos.Name = "pic_currentPos";
            this.pic_currentPos.Size = new System.Drawing.Size(15, 39);
            this.pic_currentPos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_currentPos.TabIndex = 12;
            this.pic_currentPos.TabStop = false;
            // 
            // pic_trackbar
            // 
            this.pic_trackbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_trackbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pic_trackbar.Image = global::GameWPlayer.Properties.Resources.pink_texture_by_dancinghamham;
            this.pic_trackbar.Location = new System.Drawing.Point(12, 20);
            this.pic_trackbar.Name = "pic_trackbar";
            this.pic_trackbar.Size = new System.Drawing.Size(653, 22);
            this.pic_trackbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_trackbar.TabIndex = 10;
            this.pic_trackbar.TabStop = false;
            this.pic_trackbar.Click += new System.EventHandler(this.pic_trackbar_Click);
            // 
            // seekTimer
            // 
            this.seekTimer.Enabled = true;
            this.seekTimer.Tick += new System.EventHandler(this.seekTimer_Tick);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = global::GameWPlayer.Properties.Resources.bannerlite2;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(892, 58);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 10;
            this.picLogo.TabStop = false;
            // 
            // loadPicture
            // 
            this.loadPicture.BackColor = System.Drawing.Color.Black;
            this.loadPicture.Image = global::GameWPlayer.Properties.Resources.loading;
            this.loadPicture.Location = new System.Drawing.Point(677, 503);
            this.loadPicture.Name = "loadPicture";
            this.loadPicture.Size = new System.Drawing.Size(10, 10);
            this.loadPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadPicture.TabIndex = 6;
            this.loadPicture.TabStop = false;
            this.loadPicture.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(892, 635);
            this.Controls.Add(this.player);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.loadPicture);
            this.Controls.Add(this.panelGeral);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(908, 413);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHInsider Music Player";
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panelGeral.ResumeLayout(false);
            this.panelGeral.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_currentPos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSiteOSTS1;
        private System.Windows.Forms.ListBox lstMusicsOST2;
        private System.Windows.Forms.TextBox txtF1;
        private System.Windows.Forms.Button btnDownloadMusica2;
        private System.Windows.Forms.Button btnDownloadOst1;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.PictureBox loadPicture;
        private System.Windows.Forms.Button btnDownloadAlbum3;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panelGeral;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_currentPos;
        private System.Windows.Forms.PictureBox pic_trackbar;
        private System.Windows.Forms.Timer seekTimer;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox picPlayPause;
        private System.Windows.Forms.TrackBar trackVolume;
    }
}

