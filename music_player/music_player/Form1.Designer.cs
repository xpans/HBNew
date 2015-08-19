namespace music_player
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.btnChange = new System.Windows.Forms.Button();
            this.musicPalyer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlayOrPause = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpMusic = new System.Windows.Forms.Button();
            this.btnDownMusic = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblLrc = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.musicPalyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(348, 12);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(78, 30);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "换肤";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // musicPalyer
            // 
            this.musicPalyer.Enabled = true;
            this.musicPalyer.Location = new System.Drawing.Point(-2, 1);
            this.musicPalyer.Name = "musicPalyer";
            this.musicPalyer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPalyer.OcxState")));
            this.musicPalyer.Size = new System.Drawing.Size(315, 384);
            this.musicPalyer.TabIndex = 1;
            this.musicPalyer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.musicPalyer_PlayStateChange);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 340);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPlayOrPause
            // 
            this.btnPlayOrPause.Location = new System.Drawing.Point(348, 60);
            this.btnPlayOrPause.Name = "btnPlayOrPause";
            this.btnPlayOrPause.Size = new System.Drawing.Size(78, 30);
            this.btnPlayOrPause.TabIndex = 3;
            this.btnPlayOrPause.Text = "播放";
            this.btnPlayOrPause.UseVisualStyleBackColor = true;
            this.btnPlayOrPause.Click += new System.EventHandler(this.btnPlayOrPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(348, 110);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(78, 29);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(348, 159);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(78, 29);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "选择文件";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(463, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(240, 268);
            this.listBox1.TabIndex = 6;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // btnUpMusic
            // 
            this.btnUpMusic.Location = new System.Drawing.Point(348, 208);
            this.btnUpMusic.Name = "btnUpMusic";
            this.btnUpMusic.Size = new System.Drawing.Size(78, 31);
            this.btnUpMusic.TabIndex = 7;
            this.btnUpMusic.Text = "上一曲";
            this.btnUpMusic.UseVisualStyleBackColor = true;
            this.btnUpMusic.Click += new System.EventHandler(this.btnUpMusic_Click);
            // 
            // btnDownMusic
            // 
            this.btnDownMusic.Location = new System.Drawing.Point(348, 259);
            this.btnDownMusic.Name = "btnDownMusic";
            this.btnDownMusic.Size = new System.Drawing.Size(78, 33);
            this.btnDownMusic.TabIndex = 8;
            this.btnDownMusic.Text = "下一曲";
            this.btnDownMusic.UseVisualStyleBackColor = true;
            this.btnDownMusic.Click += new System.EventHandler(this.btnDownMusic_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(331, 304);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(95, 12);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "               ";
            // 
            // lblLrc
            // 
            this.lblLrc.AutoSize = true;
            this.lblLrc.Location = new System.Drawing.Point(461, 304);
            this.lblLrc.Name = "lblLrc";
            this.lblLrc.Size = new System.Drawing.Size(41, 12);
            this.lblLrc.TabIndex = 11;
            this.lblLrc.Text = "label1";
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 386);
            this.Controls.Add(this.lblLrc);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnDownMusic);
            this.Controls.Add(this.btnUpMusic);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlayOrPause);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.musicPalyer);
            this.Controls.Add(this.btnChange);
            this.MaximumSize = new System.Drawing.Size(731, 424);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicPalyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnChange;
        private AxWMPLib.AxWindowsMediaPlayer musicPalyer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPlayOrPause;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnUpMusic;
        private System.Windows.Forms.Button btnDownMusic;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblLrc;
        private System.Windows.Forms.Timer timer3;

    }
}

