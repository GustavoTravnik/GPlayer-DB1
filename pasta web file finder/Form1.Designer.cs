namespace pasta_web_file_finder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstSiteOSTS1 = new System.Windows.Forms.ListBox();
            this.lstMusicsOST2 = new System.Windows.Forms.ListBox();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.btnDownloadMusica2 = new System.Windows.Forms.Button();
            this.btnDownloadOst1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.loadPicture = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnDownloadAlbum3 = new System.Windows.Forms.Button();
            this.txtF2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstSiteOSTS1
            // 
            this.lstSiteOSTS1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstSiteOSTS1.BackColor = System.Drawing.Color.Black;
            this.lstSiteOSTS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstSiteOSTS1.ForeColor = System.Drawing.Color.Lime;
            this.lstSiteOSTS1.FormattingEnabled = true;
            this.lstSiteOSTS1.Location = new System.Drawing.Point(12, 44);
            this.lstSiteOSTS1.Name = "lstSiteOSTS1";
            this.lstSiteOSTS1.ScrollAlwaysVisible = true;
            this.lstSiteOSTS1.Size = new System.Drawing.Size(412, 249);
            this.lstSiteOSTS1.TabIndex = 0;
            this.lstSiteOSTS1.SelectedIndexChanged += new System.EventHandler(this.lstSiteOSTS_SelectedIndexChanged);
            this.lstSiteOSTS1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // lstMusicsOST2
            // 
            this.lstMusicsOST2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstMusicsOST2.BackColor = System.Drawing.Color.Black;
            this.lstMusicsOST2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMusicsOST2.ForeColor = System.Drawing.Color.Lime;
            this.lstMusicsOST2.FormattingEnabled = true;
            this.lstMusicsOST2.Location = new System.Drawing.Point(466, 44);
            this.lstMusicsOST2.Name = "lstMusicsOST2";
            this.lstMusicsOST2.ScrollAlwaysVisible = true;
            this.lstMusicsOST2.Size = new System.Drawing.Size(412, 249);
            this.lstMusicsOST2.TabIndex = 1;
            this.lstMusicsOST2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
            // 
            // txtF1
            // 
            this.txtF1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtF1.BackColor = System.Drawing.Color.Black;
            this.txtF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtF1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF1.ForeColor = System.Drawing.Color.Lime;
            this.txtF1.Location = new System.Drawing.Point(12, 0);
            this.txtF1.Name = "txtF1";
            this.txtF1.Size = new System.Drawing.Size(361, 26);
            this.txtF1.TabIndex = 2;
            this.txtF1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnDownloadMusica2
            // 
            this.btnDownloadMusica2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDownloadMusica2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadMusica2.ForeColor = System.Drawing.Color.Lime;
            this.btnDownloadMusica2.Location = new System.Drawing.Point(466, 299);
            this.btnDownloadMusica2.Name = "btnDownloadMusica2";
            this.btnDownloadMusica2.Size = new System.Drawing.Size(203, 23);
            this.btnDownloadMusica2.TabIndex = 3;
            this.btnDownloadMusica2.Text = "Download Musica Selecionada";
            this.btnDownloadMusica2.UseVisualStyleBackColor = true;
            this.btnDownloadMusica2.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDownloadOst1
            // 
            this.btnDownloadOst1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDownloadOst1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadOst1.ForeColor = System.Drawing.Color.Lime;
            this.btnDownloadOst1.Location = new System.Drawing.Point(12, 299);
            this.btnDownloadOst1.Name = "btnDownloadOst1";
            this.btnDownloadOst1.Size = new System.Drawing.Size(412, 23);
            this.btnDownloadOst1.TabIndex = 4;
            this.btnDownloadOst1.Text = "Open OSTs Folder";
            this.btnDownloadOst1.UseVisualStyleBackColor = true;
            this.btnDownloadOst1.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // loadPicture
            // 
            this.loadPicture.BackColor = System.Drawing.Color.Black;
            this.loadPicture.Image = global::pasta_web_file_finder.Properties.Resources.loading;
            this.loadPicture.Location = new System.Drawing.Point(439, 283);
            this.loadPicture.Name = "loadPicture";
            this.loadPicture.Size = new System.Drawing.Size(10, 10);
            this.loadPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadPicture.TabIndex = 6;
            this.loadPicture.TabStop = false;
            this.loadPicture.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(892, 374);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.axWindowsMediaPlayer1_MediaChange);
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // btnDownloadAlbum3
            // 
            this.btnDownloadAlbum3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDownloadAlbum3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadAlbum3.ForeColor = System.Drawing.Color.Lime;
            this.btnDownloadAlbum3.Location = new System.Drawing.Point(675, 299);
            this.btnDownloadAlbum3.Name = "btnDownloadAlbum3";
            this.btnDownloadAlbum3.Size = new System.Drawing.Size(203, 23);
            this.btnDownloadAlbum3.TabIndex = 7;
            this.btnDownloadAlbum3.Text = "Download Album";
            this.btnDownloadAlbum3.UseVisualStyleBackColor = true;
            this.btnDownloadAlbum3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtF2
            // 
            this.txtF2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtF2.BackColor = System.Drawing.Color.Black;
            this.txtF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF2.ForeColor = System.Drawing.Color.Lime;
            this.txtF2.Location = new System.Drawing.Point(517, 12);
            this.txtF2.Name = "txtF2";
            this.txtF2.Size = new System.Drawing.Size(361, 26);
            this.txtF2.TabIndex = 9;
            this.txtF2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(892, 374);
            this.Controls.Add(this.txtF2);
            this.Controls.Add(this.btnDownloadAlbum3);
            this.Controls.Add(this.loadPicture);
            this.Controls.Add(this.btnDownloadOst1);
            this.Controls.Add(this.btnDownloadMusica2);
            this.Controls.Add(this.txtF1);
            this.Controls.Add(this.lstMusicsOST2);
            this.Controls.Add(this.lstSiteOSTS1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NP";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.loadPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSiteOSTS1;
        private System.Windows.Forms.ListBox lstMusicsOST2;
        private System.Windows.Forms.TextBox txtF1;
        private System.Windows.Forms.Button btnDownloadMusica2;
        private System.Windows.Forms.Button btnDownloadOst1;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox loadPicture;
        private System.Windows.Forms.Button btnDownloadAlbum3;
        private System.Windows.Forms.TextBox txtF2;
    }
}

