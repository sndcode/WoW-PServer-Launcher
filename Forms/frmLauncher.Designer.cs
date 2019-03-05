namespace PTFLauncher
{
    partial class frmLauncher
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLauncher));
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.launcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.überToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugtrackerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientDownloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openClientFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dEBUGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugtrackerAttatchmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debug01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debug02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debug03ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiAFKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOWNLOADUPDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrServerOnline = new System.Windows.Forms.Timer(this.components);
            this.lblOnlinePlayers = new System.Windows.Forms.Label();
            this.tmrPlayersOnline = new System.Windows.Forms.Timer(this.components);
            this.lblOnlinePlayersValue = new System.Windows.Forms.Label();
            this.txtNews = new System.Windows.Forms.RichTextBox();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(369, 321);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(81, 55);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Location = new System.Drawing.Point(12, 316);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(10, 13);
            this.lblServerStatus.TabIndex = 2;
            this.lblServerStatus.Text = "-";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(83, 316);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(10, 13);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "-";
            this.lblVersion.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.launcherToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.dEBUGToolStripMenuItem,
            this.dOWNLOADUPDATEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // launcherToolStripMenuItem
            // 
            this.launcherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updatesToolStripMenuItem,
            this.hilfeToolStripMenuItem,
            this.überToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem,
            this.restartToolStripMenuItem1});
            this.launcherToolStripMenuItem.Name = "launcherToolStripMenuItem";
            this.launcherToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.launcherToolStripMenuItem.Text = "Launcher";
            // 
            // updatesToolStripMenuItem
            // 
            this.updatesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updatesToolStripMenuItem.Image")));
            this.updatesToolStripMenuItem.Name = "updatesToolStripMenuItem";
            this.updatesToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updatesToolStripMenuItem.Text = "Update";
            this.updatesToolStripMenuItem.Click += new System.EventHandler(this.updatesToolStripMenuItem_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hilfeToolStripMenuItem.Image")));
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.hilfeToolStripMenuItem.Text = "Help";
            this.hilfeToolStripMenuItem.Click += new System.EventHandler(this.hilfeToolStripMenuItem_Click);
            // 
            // überToolStripMenuItem
            // 
            this.überToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("überToolStripMenuItem.Image")));
            this.überToolStripMenuItem.Name = "überToolStripMenuItem";
            this.überToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.überToolStripMenuItem.Text = "About";
            this.überToolStripMenuItem.Click += new System.EventHandler(this.überToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem1
            // 
            this.restartToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("restartToolStripMenuItem1.Image")));
            this.restartToolStripMenuItem1.Name = "restartToolStripMenuItem1";
            this.restartToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.restartToolStripMenuItem1.Text = "Restart";
            this.restartToolStripMenuItem1.Click += new System.EventHandler(this.restartToolStripMenuItem1_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearCacheToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.createAccountToolStripMenuItem,
            this.bugtrackerToolStripMenuItem,
            this.clientDownloadToolStripMenuItem,
            this.openClientFolderToolStripMenuItem});
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.extrasToolStripMenuItem.Text = "Extras";
            // 
            // clearCacheToolStripMenuItem
            // 
            this.clearCacheToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clearCacheToolStripMenuItem.Image")));
            this.clearCacheToolStripMenuItem.Name = "clearCacheToolStripMenuItem";
            this.clearCacheToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clearCacheToolStripMenuItem.Text = "Clear Cache";
            this.clearCacheToolStripMenuItem.Click += new System.EventHandler(this.clearCacheToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createAccountToolStripMenuItem.Image")));
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // bugtrackerToolStripMenuItem
            // 
            this.bugtrackerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bugtrackerToolStripMenuItem.Image")));
            this.bugtrackerToolStripMenuItem.Name = "bugtrackerToolStripMenuItem";
            this.bugtrackerToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.bugtrackerToolStripMenuItem.Text = "Bugtracker";
            this.bugtrackerToolStripMenuItem.Click += new System.EventHandler(this.bugtrackerToolStripMenuItem_Click);
            // 
            // clientDownloadToolStripMenuItem
            // 
            this.clientDownloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientDownloadToolStripMenuItem.Image")));
            this.clientDownloadToolStripMenuItem.Name = "clientDownloadToolStripMenuItem";
            this.clientDownloadToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.clientDownloadToolStripMenuItem.Text = "Client Download";
            this.clientDownloadToolStripMenuItem.Click += new System.EventHandler(this.clientDownloadToolStripMenuItem_Click);
            // 
            // openClientFolderToolStripMenuItem
            // 
            this.openClientFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openClientFolderToolStripMenuItem.Image")));
            this.openClientFolderToolStripMenuItem.Name = "openClientFolderToolStripMenuItem";
            this.openClientFolderToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.openClientFolderToolStripMenuItem.Text = "Open Client Folder";
            this.openClientFolderToolStripMenuItem.Click += new System.EventHandler(this.openClientFolderToolStripMenuItem_Click);
            // 
            // dEBUGToolStripMenuItem
            // 
            this.dEBUGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bugtrackerAttatchmentsToolStripMenuItem,
            this.debug01ToolStripMenuItem,
            this.debug02ToolStripMenuItem,
            this.debug03ToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.antiAFKToolStripMenuItem});
            this.dEBUGToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.dEBUGToolStripMenuItem.Name = "dEBUGToolStripMenuItem";
            this.dEBUGToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.dEBUGToolStripMenuItem.Text = "ADMIN MODE";
            this.dEBUGToolStripMenuItem.Visible = false;
            // 
            // bugtrackerAttatchmentsToolStripMenuItem
            // 
            this.bugtrackerAttatchmentsToolStripMenuItem.Name = "bugtrackerAttatchmentsToolStripMenuItem";
            this.bugtrackerAttatchmentsToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.bugtrackerAttatchmentsToolStripMenuItem.Text = "Bugtracker Attatchments";
            this.bugtrackerAttatchmentsToolStripMenuItem.Click += new System.EventHandler(this.bugtrackerAttatchmentsToolStripMenuItem_Click);
            // 
            // debug01ToolStripMenuItem
            // 
            this.debug01ToolStripMenuItem.Name = "debug01ToolStripMenuItem";
            this.debug01ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.debug01ToolStripMenuItem.Text = "Bugtracker Tickets";
            this.debug01ToolStripMenuItem.Click += new System.EventHandler(this.debug01ToolStripMenuItem_Click);
            // 
            // debug02ToolStripMenuItem
            // 
            this.debug02ToolStripMenuItem.Name = "debug02ToolStripMenuItem";
            this.debug02ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.debug02ToolStripMenuItem.Text = "Admin Password Reset";
            this.debug02ToolStripMenuItem.Click += new System.EventHandler(this.debug02ToolStripMenuItem_Click);
            // 
            // debug03ToolStripMenuItem
            // 
            this.debug03ToolStripMenuItem.Name = "debug03ToolStripMenuItem";
            this.debug03ToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.debug03ToolStripMenuItem.Text = "CMS Admin";
            this.debug03ToolStripMenuItem.Click += new System.EventHandler(this.debug03ToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.restartToolStripMenuItem.Text = "Forum Admin";
            // 
            // antiAFKToolStripMenuItem
            // 
            this.antiAFKToolStripMenuItem.Name = "antiAFKToolStripMenuItem";
            this.antiAFKToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.antiAFKToolStripMenuItem.Text = "AntiAFK";
            this.antiAFKToolStripMenuItem.Click += new System.EventHandler(this.antiAFKToolStripMenuItem_Click);
            // 
            // dOWNLOADUPDATEToolStripMenuItem
            // 
            this.dOWNLOADUPDATEToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.dOWNLOADUPDATEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dOWNLOADUPDATEToolStripMenuItem.Image")));
            this.dOWNLOADUPDATEToolStripMenuItem.Name = "dOWNLOADUPDATEToolStripMenuItem";
            this.dOWNLOADUPDATEToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.dOWNLOADUPDATEToolStripMenuItem.Text = "DOWNLOAD UPDATE";
            this.dOWNLOADUPDATEToolStripMenuItem.Visible = false;
            this.dOWNLOADUPDATEToolStripMenuItem.Click += new System.EventHandler(this.dOWNLOADUPDATEToolStripMenuItem_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(12, 363);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Download Update!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tmrServerOnline
            // 
            this.tmrServerOnline.Enabled = true;
            this.tmrServerOnline.Interval = 5000;
            this.tmrServerOnline.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblOnlinePlayers
            // 
            this.lblOnlinePlayers.AutoSize = true;
            this.lblOnlinePlayers.Location = new System.Drawing.Point(12, 341);
            this.lblOnlinePlayers.Name = "lblOnlinePlayers";
            this.lblOnlinePlayers.Size = new System.Drawing.Size(10, 13);
            this.lblOnlinePlayers.TabIndex = 10;
            this.lblOnlinePlayers.Text = "-";
            // 
            // tmrPlayersOnline
            // 
            this.tmrPlayersOnline.Enabled = true;
            this.tmrPlayersOnline.Interval = 5000;
            this.tmrPlayersOnline.Tick += new System.EventHandler(this.tmrPlayersOnline_Tick);
            // 
            // lblOnlinePlayersValue
            // 
            this.lblOnlinePlayersValue.AutoSize = true;
            this.lblOnlinePlayersValue.Location = new System.Drawing.Point(83, 341);
            this.lblOnlinePlayersValue.Name = "lblOnlinePlayersValue";
            this.lblOnlinePlayersValue.Size = new System.Drawing.Size(10, 13);
            this.lblOnlinePlayersValue.TabIndex = 11;
            this.lblOnlinePlayersValue.Text = "-";
            // 
            // txtNews
            // 
            this.txtNews.ContextMenuStrip = this.menu;
            this.txtNews.Location = new System.Drawing.Point(15, 164);
            this.txtNews.Name = "txtNews";
            this.txtNews.Size = new System.Drawing.Size(435, 149);
            this.txtNews.TabIndex = 12;
            this.txtNews.Text = "no news stream available at this moment";
            this.txtNews.TextChanged += new System.EventHandler(this.txtNews_TextChanged_1);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menu.Name = "contextMenuStrip1";
            this.menu.Size = new System.Drawing.Size(185, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 22);
            this.toolStripMenuItem1.Text = "open in new window";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // frmLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 395);
            this.Controls.Add(this.txtNews);
            this.Controls.Add(this.lblOnlinePlayersValue);
            this.Controls.Add(this.lblOnlinePlayers);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmLauncher";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P2F Launcher -";
            this.Load += new System.EventHandler(this.frmLauncher_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem launcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem überToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripMenuItem dEBUGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debug01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debug02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debug03ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugtrackerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientDownloadToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem dOWNLOADUPDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem antiAFKToolStripMenuItem;
        private System.Windows.Forms.Timer tmrServerOnline;
        private System.Windows.Forms.Label lblOnlinePlayers;
        private System.Windows.Forms.Timer tmrPlayersOnline;
        private System.Windows.Forms.Label lblOnlinePlayersValue;
        private System.Windows.Forms.ToolStripMenuItem openClientFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugtrackerAttatchmentsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtNews;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

