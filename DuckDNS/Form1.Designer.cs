namespace DuckDNS
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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.installStartupShortcutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbToken = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbInterval = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbSmtp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbEnableSsl = new System.Windows.Forms.CheckBox();
            this.cbUpdateNotification = new System.Windows.Forms.CheckBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cbSavePass = new System.Windows.Forms.CheckBox();
            this.tbMaxEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Text = "DuckDNS";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateNowToolStripMenuItem,
            this.toolStripSeparator1,
            this.installStartupShortcutToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 82);
            // 
            // updateNowToolStripMenuItem
            // 
            this.updateNowToolStripMenuItem.Name = "updateNowToolStripMenuItem";
            this.updateNowToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.updateNowToolStripMenuItem.Text = "Update Now!";
            this.updateNowToolStripMenuItem.Click += new System.EventHandler(this.updateNowToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // installStartupShortcutToolStripMenuItem
            // 
            this.installStartupShortcutToolStripMenuItem.Name = "installStartupShortcutToolStripMenuItem";
            this.installStartupShortcutToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.installStartupShortcutToolStripMenuItem.Text = "Install startup shortcut";
            this.installStartupShortcutToolStripMenuItem.Click += new System.EventHandler(this.installStartupShortcutToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.Location = new System.Drawing.Point(258, 12);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(30, 520);
            this.btOk.TabIndex = 12;
            this.btOk.Text = "Ok";
            this.toolTip1.SetToolTip(this.btOk, "Accept, Save and Check");
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Domain";
            // 
            // tbDomain
            // 
            this.tbDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDomain.Location = new System.Drawing.Point(64, 16);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.Size = new System.Drawing.Size(184, 20);
            this.tbDomain.TabIndex = 0;
            this.toolTip1.SetToolTip(this.tbDomain, "DuckDNS domain to update");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Token";
            // 
            // tbToken
            // 
            this.tbToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbToken.Location = new System.Drawing.Point(64, 42);
            this.tbToken.Name = "tbToken";
            this.tbToken.Size = new System.Drawing.Size(184, 20);
            this.tbToken.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tbToken, "User Token");
            this.tbToken.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Interval";
            // 
            // cbInterval
            // 
            this.cbInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbInterval.FormattingEnabled = true;
            this.cbInterval.Items.AddRange(new object[] {
            "10s",
            "30s",
            "1m",
            "5m",
            "10m",
            "30m",
            "1h",
            "2h",
            "5h",
            "10h",
            "1d"});
            this.cbInterval.Location = new System.Drawing.Point(64, 68);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(184, 21);
            this.cbInterval.TabIndex = 2;
            this.toolTip1.SetToolTip(this.cbInterval, "Update interval (number and unit)\r\nUse a tailing letter to define time unit\r\ns fo" +
        "r seconds.\r\nm for minutes.\r\nh for hours.\r\nd for days.");
            this.cbInterval.TextChanged += new System.EventHandler(this.cbInterval_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(176, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblInfo.Location = new System.Drawing.Point(8, 420);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(240, 23);
            this.lblInfo.TabIndex = 23;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tbSmtp
            // 
            this.tbSmtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSmtp.Location = new System.Drawing.Point(64, 112);
            this.tbSmtp.Name = "tbSmtp";
            this.tbSmtp.Size = new System.Drawing.Size(184, 20);
            this.tbSmtp.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tbSmtp, "DuckDNS domain to update");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Smtp Host";
            // 
            // tbPort
            // 
            this.tbPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPort.Location = new System.Drawing.Point(64, 136);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(80, 20);
            this.tbPort.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tbPort, "DuckDNS domain to update");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Port";
            // 
            // tbUsername
            // 
            this.tbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUsername.Location = new System.Drawing.Point(64, 160);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(184, 20);
            this.tbUsername.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tbUsername, "DuckDNS domain to update");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Username";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(64, 184);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(184, 20);
            this.tbPassword.TabIndex = 7;
            this.toolTip1.SetToolTip(this.tbPassword, "DuckDNS domain to update");
            // 
            // cbEnableSsl
            // 
            this.cbEnableSsl.AutoSize = true;
            this.cbEnableSsl.Location = new System.Drawing.Point(168, 136);
            this.cbEnableSsl.Name = "cbEnableSsl";
            this.cbEnableSsl.Size = new System.Drawing.Size(82, 17);
            this.cbEnableSsl.TabIndex = 5;
            this.cbEnableSsl.Text = "Enable SSL";
            this.cbEnableSsl.UseVisualStyleBackColor = true;
            // 
            // cbUpdateNotification
            // 
            this.cbUpdateNotification.AutoSize = true;
            this.cbUpdateNotification.Location = new System.Drawing.Point(64, 312);
            this.cbUpdateNotification.Name = "cbUpdateNotification";
            this.cbUpdateNotification.Size = new System.Drawing.Size(130, 17);
            this.cbUpdateNotification.TabIndex = 10;
            this.cbUpdateNotification.Text = "IP Update Notification";
            this.cbUpdateNotification.UseVisualStyleBackColor = true;
            // 
            // tbFrom
            // 
            this.tbFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFrom.Location = new System.Drawing.Point(64, 224);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(184, 20);
            this.tbFrom.TabIndex = 8;
            this.toolTip1.SetToolTip(this.tbFrom, "DuckDNS domain to update");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Email From";
            // 
            // tbTo
            // 
            this.tbTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTo.Location = new System.Drawing.Point(64, 248);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(184, 20);
            this.tbTo.TabIndex = 9;
            this.toolTip1.SetToolTip(this.tbTo, "DuckDNS domain to update");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Email To";
            // 
            // lblInfo2
            // 
            this.lblInfo2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblInfo2.Location = new System.Drawing.Point(8, 444);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(240, 47);
            this.lblInfo2.TabIndex = 24;
            this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(176, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Test Email";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbSavePass
            // 
            this.cbSavePass.AutoSize = true;
            this.cbSavePass.Location = new System.Drawing.Point(64, 328);
            this.cbSavePass.Name = "cbSavePass";
            this.cbSavePass.Size = new System.Drawing.Size(155, 17);
            this.cbSavePass.TabIndex = 25;
            this.cbSavePass.Text = "Save Password into config.";
            this.cbSavePass.UseVisualStyleBackColor = true;
            // 
            // tbMaxEmail
            // 
            this.tbMaxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMaxEmail.Location = new System.Drawing.Point(192, 288);
            this.tbMaxEmail.Name = "tbMaxEmail";
            this.tbMaxEmail.Size = new System.Drawing.Size(56, 20);
            this.tbMaxEmail.TabIndex = 26;
            this.tbMaxEmail.Text = "-1";
            this.toolTip1.SetToolTip(this.tbMaxEmail, "DuckDNS domain to update");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Max. Email before a successful update (-1 = Unlimit)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 542);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbMaxEmail);
            this.Controls.Add(this.cbSavePass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbUpdateNotification);
            this.Controls.Add(this.cbEnableSsl);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSmtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbInterval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDomain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DuckDNS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDomain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbToken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbInterval;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installStartupShortcutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TextBox tbSmtp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbEnableSsl;
        private System.Windows.Forms.CheckBox cbUpdateNotification;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbSavePass;
        private System.Windows.Forms.TextBox tbMaxEmail;
        private System.Windows.Forms.Label label10;
    }
}

