namespace Secure
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
            this.BTN_EthernetStatus = new System.Windows.Forms.Button();
            this.LB_Ethernet = new System.Windows.Forms.Label();
            this.LB_EthernetStatus = new System.Windows.Forms.Label();
            this.LB_FirewallStatus = new System.Windows.Forms.Label();
            this.LB_Firewall = new System.Windows.Forms.Label();
            this.BTN_FirewallStatus = new System.Windows.Forms.Button();
            this.LB_FirewallWork = new System.Windows.Forms.Label();
            this.LB_FirewallWstatus = new System.Windows.Forms.Label();
            this.BTN_FirewallWork = new System.Windows.Forms.Button();
            this.LB_AntivirusStatus = new System.Windows.Forms.Label();
            this.LB_Antivirus = new System.Windows.Forms.Label();
            this.BTN_AntivirusStatus = new System.Windows.Forms.Button();
            this.LB_AntivirusWork = new System.Windows.Forms.Label();
            this.LB_AntivirusWstatus = new System.Windows.Forms.Label();
            this.BNT_AntivirusWork = new System.Windows.Forms.Button();
            this.LB_AntivirusTest = new System.Windows.Forms.Label();
            this.LB_AntivirusTstatus = new System.Windows.Forms.Label();
            this.BTN_AntivirusTest = new System.Windows.Forms.Button();
            this.GB_Firewall = new System.Windows.Forms.GroupBox();
            this.GB_Antivirus = new System.Windows.Forms.GroupBox();
            this.LSB_LOG = new System.Windows.Forms.ListBox();
            this.LB_LOG = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveLogToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAllTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GB_Firewall.SuspendLayout();
            this.GB_Antivirus.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_EthernetStatus
            // 
            this.BTN_EthernetStatus.Location = new System.Drawing.Point(8, 19);
            this.BTN_EthernetStatus.Name = "BTN_EthernetStatus";
            this.BTN_EthernetStatus.Size = new System.Drawing.Size(144, 23);
            this.BTN_EthernetStatus.TabIndex = 0;
            this.BTN_EthernetStatus.Text = "Интернет статус";
            this.BTN_EthernetStatus.UseVisualStyleBackColor = true;
            this.BTN_EthernetStatus.Click += new System.EventHandler(this.BTN_EthernetStatus_Click);
            // 
            // LB_Ethernet
            // 
            this.LB_Ethernet.AutoSize = true;
            this.LB_Ethernet.Location = new System.Drawing.Point(165, 24);
            this.LB_Ethernet.Name = "LB_Ethernet";
            this.LB_Ethernet.Size = new System.Drawing.Size(47, 13);
            this.LB_Ethernet.TabIndex = 1;
            this.LB_Ethernet.Text = "Статус: ";
            // 
            // LB_EthernetStatus
            // 
            this.LB_EthernetStatus.AutoSize = true;
            this.LB_EthernetStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LB_EthernetStatus.Location = new System.Drawing.Point(214, 24);
            this.LB_EthernetStatus.Name = "LB_EthernetStatus";
            this.LB_EthernetStatus.Size = new System.Drawing.Size(38, 13);
            this.LB_EthernetStatus.TabIndex = 2;
            this.LB_EthernetStatus.Text = "NONE";
            // 
            // LB_FirewallStatus
            // 
            this.LB_FirewallStatus.AutoSize = true;
            this.LB_FirewallStatus.Location = new System.Drawing.Point(214, 53);
            this.LB_FirewallStatus.Name = "LB_FirewallStatus";
            this.LB_FirewallStatus.Size = new System.Drawing.Size(38, 13);
            this.LB_FirewallStatus.TabIndex = 5;
            this.LB_FirewallStatus.Text = "NONE";
            // 
            // LB_Firewall
            // 
            this.LB_Firewall.AutoSize = true;
            this.LB_Firewall.Location = new System.Drawing.Point(165, 53);
            this.LB_Firewall.Name = "LB_Firewall";
            this.LB_Firewall.Size = new System.Drawing.Size(47, 13);
            this.LB_Firewall.TabIndex = 4;
            this.LB_Firewall.Text = "Статус: ";
            // 
            // BTN_FirewallStatus
            // 
            this.BTN_FirewallStatus.Location = new System.Drawing.Point(8, 48);
            this.BTN_FirewallStatus.Name = "BTN_FirewallStatus";
            this.BTN_FirewallStatus.Size = new System.Drawing.Size(144, 23);
            this.BTN_FirewallStatus.TabIndex = 3;
            this.BTN_FirewallStatus.Text = "МЭ статус";
            this.BTN_FirewallStatus.UseVisualStyleBackColor = true;
            this.BTN_FirewallStatus.Click += new System.EventHandler(this.BTN_FirewallStatus_Click);
            // 
            // LB_FirewallWork
            // 
            this.LB_FirewallWork.AutoSize = true;
            this.LB_FirewallWork.Location = new System.Drawing.Point(214, 82);
            this.LB_FirewallWork.Name = "LB_FirewallWork";
            this.LB_FirewallWork.Size = new System.Drawing.Size(38, 13);
            this.LB_FirewallWork.TabIndex = 8;
            this.LB_FirewallWork.Text = "NONE";
            // 
            // LB_FirewallWstatus
            // 
            this.LB_FirewallWstatus.AutoSize = true;
            this.LB_FirewallWstatus.Location = new System.Drawing.Point(165, 82);
            this.LB_FirewallWstatus.Name = "LB_FirewallWstatus";
            this.LB_FirewallWstatus.Size = new System.Drawing.Size(47, 13);
            this.LB_FirewallWstatus.TabIndex = 7;
            this.LB_FirewallWstatus.Text = "Статус: ";
            // 
            // BTN_FirewallWork
            // 
            this.BTN_FirewallWork.Location = new System.Drawing.Point(8, 77);
            this.BTN_FirewallWork.Name = "BTN_FirewallWork";
            this.BTN_FirewallWork.Size = new System.Drawing.Size(144, 23);
            this.BTN_FirewallWork.TabIndex = 6;
            this.BTN_FirewallWork.Text = "МЭ корректность";
            this.BTN_FirewallWork.UseVisualStyleBackColor = true;
            this.BTN_FirewallWork.Click += new System.EventHandler(this.BTN_FirewallWork_Click);
            // 
            // LB_AntivirusStatus
            // 
            this.LB_AntivirusStatus.AutoSize = true;
            this.LB_AntivirusStatus.Location = new System.Drawing.Point(214, 24);
            this.LB_AntivirusStatus.Name = "LB_AntivirusStatus";
            this.LB_AntivirusStatus.Size = new System.Drawing.Size(38, 13);
            this.LB_AntivirusStatus.TabIndex = 11;
            this.LB_AntivirusStatus.Text = "NONE";
            // 
            // LB_Antivirus
            // 
            this.LB_Antivirus.AutoSize = true;
            this.LB_Antivirus.Location = new System.Drawing.Point(165, 24);
            this.LB_Antivirus.Name = "LB_Antivirus";
            this.LB_Antivirus.Size = new System.Drawing.Size(47, 13);
            this.LB_Antivirus.TabIndex = 10;
            this.LB_Antivirus.Text = "Статус: ";
            // 
            // BTN_AntivirusStatus
            // 
            this.BTN_AntivirusStatus.Location = new System.Drawing.Point(6, 19);
            this.BTN_AntivirusStatus.Name = "BTN_AntivirusStatus";
            this.BTN_AntivirusStatus.Size = new System.Drawing.Size(146, 23);
            this.BTN_AntivirusStatus.TabIndex = 9;
            this.BTN_AntivirusStatus.Text = "Антивирус статус";
            this.BTN_AntivirusStatus.UseVisualStyleBackColor = true;
            this.BTN_AntivirusStatus.Click += new System.EventHandler(this.BTN_AntivirusStatus_Click);
            // 
            // LB_AntivirusWork
            // 
            this.LB_AntivirusWork.AutoSize = true;
            this.LB_AntivirusWork.Location = new System.Drawing.Point(214, 53);
            this.LB_AntivirusWork.Name = "LB_AntivirusWork";
            this.LB_AntivirusWork.Size = new System.Drawing.Size(38, 13);
            this.LB_AntivirusWork.TabIndex = 14;
            this.LB_AntivirusWork.Text = "NONE";
            // 
            // LB_AntivirusWstatus
            // 
            this.LB_AntivirusWstatus.AutoSize = true;
            this.LB_AntivirusWstatus.Location = new System.Drawing.Point(165, 53);
            this.LB_AntivirusWstatus.Name = "LB_AntivirusWstatus";
            this.LB_AntivirusWstatus.Size = new System.Drawing.Size(47, 13);
            this.LB_AntivirusWstatus.TabIndex = 13;
            this.LB_AntivirusWstatus.Text = "Статус: ";
            // 
            // BNT_AntivirusWork
            // 
            this.BNT_AntivirusWork.Location = new System.Drawing.Point(6, 48);
            this.BNT_AntivirusWork.Name = "BNT_AntivirusWork";
            this.BNT_AntivirusWork.Size = new System.Drawing.Size(146, 23);
            this.BNT_AntivirusWork.TabIndex = 12;
            this.BNT_AntivirusWork.Text = "Антивирус корректность";
            this.BNT_AntivirusWork.UseVisualStyleBackColor = true;
            this.BNT_AntivirusWork.Click += new System.EventHandler(this.BNT_AntivirusWork_Click);
            // 
            // LB_AntivirusTest
            // 
            this.LB_AntivirusTest.AutoSize = true;
            this.LB_AntivirusTest.Location = new System.Drawing.Point(214, 82);
            this.LB_AntivirusTest.Name = "LB_AntivirusTest";
            this.LB_AntivirusTest.Size = new System.Drawing.Size(38, 13);
            this.LB_AntivirusTest.TabIndex = 17;
            this.LB_AntivirusTest.Text = "NONE";
            // 
            // LB_AntivirusTstatus
            // 
            this.LB_AntivirusTstatus.AutoSize = true;
            this.LB_AntivirusTstatus.Location = new System.Drawing.Point(165, 82);
            this.LB_AntivirusTstatus.Name = "LB_AntivirusTstatus";
            this.LB_AntivirusTstatus.Size = new System.Drawing.Size(47, 13);
            this.LB_AntivirusTstatus.TabIndex = 16;
            this.LB_AntivirusTstatus.Text = "Статус: ";
            // 
            // BTN_AntivirusTest
            // 
            this.BTN_AntivirusTest.Location = new System.Drawing.Point(6, 77);
            this.BTN_AntivirusTest.Name = "BTN_AntivirusTest";
            this.BTN_AntivirusTest.Size = new System.Drawing.Size(146, 23);
            this.BTN_AntivirusTest.TabIndex = 15;
            this.BTN_AntivirusTest.Text = "Антивирус тест";
            this.BTN_AntivirusTest.UseVisualStyleBackColor = true;
            this.BTN_AntivirusTest.Click += new System.EventHandler(this.BTN_AntivirusTest_Click);
            // 
            // GB_Firewall
            // 
            this.GB_Firewall.Controls.Add(this.BTN_EthernetStatus);
            this.GB_Firewall.Controls.Add(this.LB_Ethernet);
            this.GB_Firewall.Controls.Add(this.LB_EthernetStatus);
            this.GB_Firewall.Controls.Add(this.BTN_FirewallStatus);
            this.GB_Firewall.Controls.Add(this.LB_Firewall);
            this.GB_Firewall.Controls.Add(this.LB_FirewallStatus);
            this.GB_Firewall.Controls.Add(this.BTN_FirewallWork);
            this.GB_Firewall.Controls.Add(this.LB_FirewallWstatus);
            this.GB_Firewall.Controls.Add(this.LB_FirewallWork);
            this.GB_Firewall.Location = new System.Drawing.Point(4, 32);
            this.GB_Firewall.Name = "GB_Firewall";
            this.GB_Firewall.Size = new System.Drawing.Size(402, 119);
            this.GB_Firewall.TabIndex = 18;
            this.GB_Firewall.TabStop = false;
            this.GB_Firewall.Text = "Межсетевой экран";
            // 
            // GB_Antivirus
            // 
            this.GB_Antivirus.Controls.Add(this.LB_AntivirusTest);
            this.GB_Antivirus.Controls.Add(this.BTN_AntivirusStatus);
            this.GB_Antivirus.Controls.Add(this.LB_AntivirusTstatus);
            this.GB_Antivirus.Controls.Add(this.LB_Antivirus);
            this.GB_Antivirus.Controls.Add(this.BTN_AntivirusTest);
            this.GB_Antivirus.Controls.Add(this.LB_AntivirusStatus);
            this.GB_Antivirus.Controls.Add(this.LB_AntivirusWork);
            this.GB_Antivirus.Controls.Add(this.BNT_AntivirusWork);
            this.GB_Antivirus.Controls.Add(this.LB_AntivirusWstatus);
            this.GB_Antivirus.Location = new System.Drawing.Point(4, 167);
            this.GB_Antivirus.Name = "GB_Antivirus";
            this.GB_Antivirus.Size = new System.Drawing.Size(402, 119);
            this.GB_Antivirus.TabIndex = 19;
            this.GB_Antivirus.TabStop = false;
            this.GB_Antivirus.Text = "Антивирус";
            // 
            // LSB_LOG
            // 
            this.LSB_LOG.FormattingEnabled = true;
            this.LSB_LOG.Location = new System.Drawing.Point(412, 48);
            this.LSB_LOG.Name = "LSB_LOG";
            this.LSB_LOG.Size = new System.Drawing.Size(404, 238);
            this.LSB_LOG.TabIndex = 20;
            // 
            // LB_LOG
            // 
            this.LB_LOG.AutoSize = true;
            this.LB_LOG.Location = new System.Drawing.Point(413, 29);
            this.LB_LOG.Name = "LB_LOG";
            this.LB_LOG.Size = new System.Drawing.Size(32, 13);
            this.LB_LOG.TabIndex = 21;
            this.LB_LOG.Text = "ЛОГ:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 24);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveLogToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // saveLogToFileToolStripMenuItem
            // 
            this.saveLogToFileToolStripMenuItem.Name = "saveLogToFileToolStripMenuItem";
            this.saveLogToFileToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveLogToFileToolStripMenuItem.Text = "Сохранить лог в файл";
            this.saveLogToFileToolStripMenuItem.Click += new System.EventHandler(this.saveLogToFileToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runAllTestsToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.testToolStripMenuItem.Text = "Автопрогон";
            // 
            // runAllTestsToolStripMenuItem
            // 
            this.runAllTestsToolStripMenuItem.Name = "runAllTestsToolStripMenuItem";
            this.runAllTestsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.runAllTestsToolStripMenuItem.Text = "Запустить все тесты";
            this.runAllTestsToolStripMenuItem.Click += new System.EventHandler(this.runAllTestsToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 300);
            this.Controls.Add(this.LB_LOG);
            this.Controls.Add(this.LSB_LOG);
            this.Controls.Add(this.GB_Firewall);
            this.Controls.Add(this.GB_Antivirus);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Статусы";
            this.GB_Firewall.ResumeLayout(false);
            this.GB_Firewall.PerformLayout();
            this.GB_Antivirus.ResumeLayout(false);
            this.GB_Antivirus.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_EthernetStatus;
        private System.Windows.Forms.Label LB_Ethernet;
        private System.Windows.Forms.Label LB_EthernetStatus;
        private System.Windows.Forms.Label LB_FirewallStatus;
        private System.Windows.Forms.Label LB_Firewall;
        private System.Windows.Forms.Button BTN_FirewallStatus;
        private System.Windows.Forms.Label LB_FirewallWork;
        private System.Windows.Forms.Label LB_FirewallWstatus;
        private System.Windows.Forms.Button BTN_FirewallWork;
        private System.Windows.Forms.Label LB_AntivirusStatus;
        private System.Windows.Forms.Label LB_Antivirus;
        private System.Windows.Forms.Button BTN_AntivirusStatus;
        private System.Windows.Forms.Label LB_AntivirusWork;
        private System.Windows.Forms.Label LB_AntivirusWstatus;
        private System.Windows.Forms.Button BNT_AntivirusWork;
        private System.Windows.Forms.Label LB_AntivirusTest;
        private System.Windows.Forms.Label LB_AntivirusTstatus;
        private System.Windows.Forms.Button BTN_AntivirusTest;
        private System.Windows.Forms.GroupBox GB_Firewall;
        private System.Windows.Forms.GroupBox GB_Antivirus;
        private System.Windows.Forms.ListBox LSB_LOG;
        private System.Windows.Forms.Label LB_LOG;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveLogToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAllTestsToolStripMenuItem;
    }
}

