namespace Facebook_Messenger
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.sidebar = new System.Windows.Forms.PictureBox();
            this.splash = new System.Windows.Forms.Panel();
            this.main = new System.Windows.Forms.Panel();
            this.logo_spin = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.headerButtons = new System.Windows.Forms.PictureBox();
            this.headerShadow = new System.Windows.Forms.PictureBox();
            this.headerBorder = new System.Windows.Forms.PictureBox();
            this.headerTop = new System.Windows.Forms.PictureBox();
            this.chatPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chatAttach = new System.Windows.Forms.PictureBox();
            this.chatEmoticon = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.chatBorder = new System.Windows.Forms.PictureBox();
            this.browser = new Gecko.GeckoWebBrowser();
            this.spinner = new System.Windows.Forms.Timer(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sidebar)).BeginInit();
            this.splash.SuspendLayout();
            this.main.SuspendLayout();
            this.logo_spin.SuspendLayout();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.headerButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerShadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTop)).BeginInit();
            this.chatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatAttach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatEmoticon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(134)))), ((int)(((byte)(235)))));
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(13, 661);
            this.sidebar.TabIndex = 1;
            this.sidebar.TabStop = false;
            // 
            // splash
            // 
            this.splash.BackColor = System.Drawing.Color.White;
            this.splash.Controls.Add(this.main);
            this.splash.Controls.Add(this.header);
            this.splash.Controls.Add(this.chatPanel);
            this.splash.Controls.Add(this.sidebar);
            this.splash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splash.Location = new System.Drawing.Point(0, 0);
            this.splash.Name = "splash";
            this.splash.Size = new System.Drawing.Size(484, 661);
            this.splash.TabIndex = 2;
            this.splash.Click += new System.EventHandler(this.splash_Click);
            // 
            // main
            // 
            this.main.Controls.Add(this.logo_spin);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(13, 74);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(471, 434);
            this.main.TabIndex = 1;
            // 
            // logo_spin
            // 
            this.logo_spin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo_spin.BackgroundImage = global::Facebook_Messenger.Properties.Resources.Inner;
            this.logo_spin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo_spin.Controls.Add(this.logo);
            this.logo_spin.Location = new System.Drawing.Point(171, 153);
            this.logo_spin.Name = "logo_spin";
            this.logo_spin.Size = new System.Drawing.Size(128, 128);
            this.logo_spin.TabIndex = 1;
            // 
            // header
            // 
            this.header.Controls.Add(this.headerButtons);
            this.header.Controls.Add(this.headerShadow);
            this.header.Controls.Add(this.headerBorder);
            this.header.Controls.Add(this.headerTop);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(13, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(471, 74);
            this.header.TabIndex = 13;
            // 
            // headerButtons
            // 
            this.headerButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.headerButtons.ErrorImage = null;
            this.headerButtons.Image = global::Facebook_Messenger.Properties.Resources.DisabledButtons;
            this.headerButtons.InitialImage = null;
            this.headerButtons.Location = new System.Drawing.Point(362, 19);
            this.headerButtons.Name = "headerButtons";
            this.headerButtons.Size = new System.Drawing.Size(92, 24);
            this.headerButtons.TabIndex = 2;
            this.headerButtons.TabStop = false;
            // 
            // headerShadow
            // 
            this.headerShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.headerShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerShadow.Location = new System.Drawing.Point(0, 61);
            this.headerShadow.Name = "headerShadow";
            this.headerShadow.Size = new System.Drawing.Size(471, 2);
            this.headerShadow.TabIndex = 11;
            this.headerShadow.TabStop = false;
            // 
            // headerBorder
            // 
            this.headerBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.headerBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBorder.Location = new System.Drawing.Point(0, 60);
            this.headerBorder.Name = "headerBorder";
            this.headerBorder.Size = new System.Drawing.Size(471, 1);
            this.headerBorder.TabIndex = 10;
            this.headerBorder.TabStop = false;
            // 
            // headerTop
            // 
            this.headerTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            this.headerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerTop.Location = new System.Drawing.Point(0, 0);
            this.headerTop.Name = "headerTop";
            this.headerTop.Size = new System.Drawing.Size(471, 60);
            this.headerTop.TabIndex = 9;
            this.headerTop.TabStop = false;
            // 
            // chatPanel
            // 
            this.chatPanel.Controls.Add(this.pictureBox2);
            this.chatPanel.Controls.Add(this.chatAttach);
            this.chatPanel.Controls.Add(this.chatEmoticon);
            this.chatPanel.Controls.Add(this.progressBar);
            this.chatPanel.Controls.Add(this.chatBorder);
            this.chatPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chatPanel.Location = new System.Drawing.Point(13, 508);
            this.chatPanel.Name = "chatPanel";
            this.chatPanel.Size = new System.Drawing.Size(471, 153);
            this.chatPanel.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = global::Facebook_Messenger.Properties.Resources.Image;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(61, 95);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 14);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // chatAttach
            // 
            this.chatAttach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chatAttach.ErrorImage = null;
            this.chatAttach.Image = global::Facebook_Messenger.Properties.Resources.Attach;
            this.chatAttach.InitialImage = null;
            this.chatAttach.Location = new System.Drawing.Point(18, 94);
            this.chatAttach.Name = "chatAttach";
            this.chatAttach.Size = new System.Drawing.Size(16, 16);
            this.chatAttach.TabIndex = 17;
            this.chatAttach.TabStop = false;
            // 
            // chatEmoticon
            // 
            this.chatEmoticon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chatEmoticon.ErrorImage = null;
            this.chatEmoticon.Image = global::Facebook_Messenger.Properties.Resources.Emoticon;
            this.chatEmoticon.InitialImage = null;
            this.chatEmoticon.Location = new System.Drawing.Point(430, 22);
            this.chatEmoticon.Name = "chatEmoticon";
            this.chatEmoticon.Size = new System.Drawing.Size(14, 14);
            this.chatEmoticon.TabIndex = 16;
            this.chatEmoticon.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 143);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(471, 10);
            this.progressBar.TabIndex = 15;
            // 
            // chatBorder
            // 
            this.chatBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.chatBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.chatBorder.Location = new System.Drawing.Point(0, 0);
            this.chatBorder.Name = "chatBorder";
            this.chatBorder.Size = new System.Drawing.Size(471, 1);
            this.chatBorder.TabIndex = 0;
            this.chatBorder.TabStop = false;
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 0);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(484, 661);
            this.browser.TabIndex = 2;
            this.browser.UseHttpActivityObserver = false;
            this.browser.Navigated += new System.EventHandler<Gecko.GeckoNavigatedEventArgs>(this.browser_Navigated);
            this.browser.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.browser_DocumentCompleted);
            this.browser.ProgressChanged += new System.EventHandler<Gecko.GeckoProgressEventArgs>(this.browser_ProgressChanged);
            this.browser.DOMContentLoaded += new System.EventHandler<Gecko.DomEventArgs>(this.browser_DOMContentLoaded);
            // 
            // spinner
            // 
            this.spinner.Enabled = true;
            this.spinner.Interval = 1;
            this.spinner.Tick += new System.EventHandler(this.spinner_Tick);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logo.ErrorImage = null;
            this.logo.Image = global::Facebook_Messenger.Properties.Resources.Outer;
            this.logo.InitialImage = null;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(128, 128);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.splash);
            this.Controls.Add(this.browser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Facebook Messenger";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sidebar)).EndInit();
            this.splash.ResumeLayout(false);
            this.main.ResumeLayout(false);
            this.logo_spin.ResumeLayout(false);
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.headerButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerShadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headerTop)).EndInit();
            this.chatPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatAttach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatEmoticon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sidebar;
        private System.Windows.Forms.Panel splash;
        private Gecko.GeckoWebBrowser browser;
        private System.Windows.Forms.Panel chatPanel;
        private System.Windows.Forms.PictureBox chatBorder;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox headerShadow;
        private System.Windows.Forms.PictureBox headerBorder;
        private System.Windows.Forms.PictureBox headerTop;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer spinner;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Panel logo_spin;
        private System.Windows.Forms.PictureBox headerButtons;
        private System.Windows.Forms.PictureBox chatEmoticon;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox chatAttach;
        private System.Windows.Forms.PictureBox logo;
    }
}