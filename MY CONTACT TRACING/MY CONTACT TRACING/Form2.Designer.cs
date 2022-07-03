namespace MY_CONTACT_TRACING
{
    partial class QRcodepass
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
            this.btnStart = new System.Windows.Forms.Button();
            this.CLabel = new System.Windows.Forms.Label();
            this.TxtBShow = new System.Windows.Forms.TextBox();
            this.CBox = new System.Windows.Forms.ComboBox();
            this.PBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.Ftimer = new System.Windows.Forms.Timer(this.components);
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuName = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(274, 41);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 26);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // CLabel
            // 
            this.CLabel.AutoSize = true;
            this.CLabel.Location = new System.Drawing.Point(21, 44);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(43, 13);
            this.CLabel.TabIndex = 1;
            this.CLabel.Text = "Camera";
            // 
            // TxtBShow
            // 
            this.TxtBShow.Location = new System.Drawing.Point(274, 80);
            this.TxtBShow.Multiline = true;
            this.TxtBShow.Name = "TxtBShow";
            this.TxtBShow.Size = new System.Drawing.Size(183, 83);
            this.TxtBShow.TabIndex = 2;
            // 
            // CBox
            // 
            this.CBox.FormattingEnabled = true;
            this.CBox.Location = new System.Drawing.Point(70, 41);
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(198, 21);
            this.CBox.TabIndex = 3;
            // 
            // PBox
            // 
            this.PBox.Location = new System.Drawing.Point(36, 80);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(232, 193);
            this.PBox.TabIndex = 4;
            this.PBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelp,
            this.MenuAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExit});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuHelp.Text = "Help";
            // 
            // MenuAbout
            // 
            this.MenuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuName});
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(52, 20);
            this.MenuAbout.Text = "About";
            // 
            // Ftimer
            // 
            this.Ftimer.Interval = 1000;
            this.Ftimer.Tick += new System.EventHandler(this.Ftimer_Tick);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(152, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuName
            // 
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(173, 22);
            this.MenuName.Text = "Program Town Inc.";
            this.MenuName.Click += new System.EventHandler(this.MenuName_Click);
            // 
            // QRcodepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 290);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.CBox);
            this.Controls.Add(this.TxtBShow);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QRcodepass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRcodepass_FormClosing);
            this.Load += new System.EventHandler(this.QRcodepass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.TextBox TxtBShow;
        private System.Windows.Forms.ComboBox CBox;
        private System.Windows.Forms.PictureBox PBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.Timer Ftimer;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuName;
    }
}