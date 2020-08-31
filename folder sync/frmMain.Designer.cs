namespace folder_sync
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
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lbladdr = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.lblport = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnListen = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.folderWatcher = new System.IO.FileSystemWatcher();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.delaysecs = new System.Windows.Forms.NumericUpDown();
            this.lstips = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.folderWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delaysecs)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(174, 220);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(541, 30);
            this.txtPath.TabIndex = 0;
            // 
            // lbladdr
            // 
            this.lbladdr.AutoSize = true;
            this.lbladdr.Location = new System.Drawing.Point(12, 223);
            this.lbladdr.Name = "lbladdr";
            this.lbladdr.Size = new System.Drawing.Size(156, 25);
            this.lbladdr.TabIndex = 1;
            this.lbladdr.Text = "Folder Address :";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(12, 256);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(348, 45);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect to";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.HorizontalScrollbar = true;
            this.lstLog.ItemHeight = 25;
            this.lstLog.Location = new System.Drawing.Point(12, 305);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(703, 104);
            this.lstLog.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "IP Address :";
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(137, 184);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(337, 30);
            this.txtIPAddress.TabIndex = 4;
            // 
            // lblport
            // 
            this.lblport.AutoSize = true;
            this.lblport.Location = new System.Drawing.Point(480, 187);
            this.lblport.Name = "lblport";
            this.lblport.Size = new System.Drawing.Size(58, 25);
            this.lblport.TabIndex = 7;
            this.lblport.Text = "Port :";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(544, 184);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(171, 30);
            this.txtPort.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your local IP addresses :";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(367, 256);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(348, 45);
            this.btnListen.TabIndex = 11;
            this.btnListen.Text = "Listen for a connection";
            this.btnListen.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(-9, 94);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(743, 28);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Disconnected";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folderWatcher
            // 
            this.folderWatcher.EnableRaisingEvents = true;
            this.folderWatcher.SynchronizingObject = this;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(169, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(264, 29);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Every                      seconds";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.modeChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sync Mode :";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(485, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 29);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "Real time";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // delaysecs
            // 
            this.delaysecs.Location = new System.Drawing.Point(247, 132);
            this.delaysecs.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.delaysecs.Name = "delaysecs";
            this.delaysecs.Size = new System.Drawing.Size(97, 30);
            this.delaysecs.TabIndex = 16;
            this.delaysecs.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lstips
            // 
            this.lstips.FormattingEnabled = true;
            this.lstips.ItemHeight = 25;
            this.lstips.Location = new System.Drawing.Point(246, 7);
            this.lstips.Name = "lstips";
            this.lstips.Size = new System.Drawing.Size(469, 79);
            this.lstips.TabIndex = 17;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(727, 421);
            this.Controls.Add(this.lstips);
            this.Controls.Add(this.delaysecs);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbladdr);
            this.Controls.Add(this.txtPath);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(743, 460);
            this.MinimumSize = new System.Drawing.Size(743, 460);
            this.Name = "frmMain";
            this.Text = "Folder Syncer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.folderWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delaysecs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lbladdr;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label lblport;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label lblStatus;
        private System.IO.FileSystemWatcher folderWatcher;
        private System.Windows.Forms.NumericUpDown delaysecs;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox lstips;
    }
}

