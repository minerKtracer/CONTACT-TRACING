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
            this.CBox = new System.Windows.Forms.ComboBox();
            this.PBox = new System.Windows.Forms.PictureBox();
            this.MenuQRG = new System.Windows.Forms.MenuStrip();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuName = new System.Windows.Forms.ToolStripMenuItem();
            this.Ftimer = new System.Windows.Forms.Timer(this.components);
            this.ERISKLabel = new System.Windows.Forms.Label();
            this.erTB9 = new System.Windows.Forms.TextBox();
            this.vTB8 = new System.Windows.Forms.TextBox();
            this.cTB7 = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.BRGYLabel = new System.Windows.Forms.Label();
            this.HLabel = new System.Windows.Forms.Label();
            this.QLabel = new System.Windows.Forms.Label();
            this.PLabel = new System.Windows.Forms.Label();
            this.SexLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.FLabel = new System.Windows.Forms.Label();
            this.pnTB4 = new System.Windows.Forms.TextBox();
            this.haTB5 = new System.Windows.Forms.TextBox();
            this.bTB6 = new System.Windows.Forms.TextBox();
            this.sTB3 = new System.Windows.Forms.TextBox();
            this.aTB2 = new System.Windows.Forms.TextBox();
            this.fnTB1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.RESETbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).BeginInit();
            this.MenuQRG.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(24, 74);
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
            this.CLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLabel.Location = new System.Drawing.Point(141, 50);
            this.CLabel.Name = "CLabel";
            this.CLabel.Size = new System.Drawing.Size(70, 16);
            this.CLabel.TabIndex = 1;
            this.CLabel.Text = "Camera :";
            // 
            // CBox
            // 
            this.CBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBox.FormattingEnabled = true;
            this.CBox.Location = new System.Drawing.Point(217, 47);
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(198, 24);
            this.CBox.TabIndex = 3;
            // 
            // PBox
            // 
            this.PBox.BackColor = System.Drawing.Color.Snow;
            this.PBox.Location = new System.Drawing.Point(24, 117);
            this.PBox.Name = "PBox";
            this.PBox.Size = new System.Drawing.Size(281, 265);
            this.PBox.TabIndex = 4;
            this.PBox.TabStop = false;
            // 
            // MenuQRG
            // 
            this.MenuQRG.BackColor = System.Drawing.Color.OldLace;
            this.MenuQRG.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuQRG.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelp,
            this.MenuAbout});
            this.MenuQRG.Location = new System.Drawing.Point(0, 0);
            this.MenuQRG.Name = "MenuQRG";
            this.MenuQRG.Size = new System.Drawing.Size(660, 25);
            this.MenuQRG.TabIndex = 5;
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuExit});
            this.MenuHelp.Name = "MenuHelp";
            this.MenuHelp.Size = new System.Drawing.Size(49, 21);
            this.MenuHelp.Text = "Help";
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(152, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuName});
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(58, 21);
            this.MenuAbout.Text = "About";
            // 
            // MenuName
            // 
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(192, 22);
            this.MenuName.Text = "Program Town Inc.";
            this.MenuName.Click += new System.EventHandler(this.MenuName_Click);
            // 
            // Ftimer
            // 
            this.Ftimer.Interval = 1000;
            this.Ftimer.Tick += new System.EventHandler(this.Ftimer_Tick);
            // 
            // ERISKLabel
            // 
            this.ERISKLabel.AutoSize = true;
            this.ERISKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERISKLabel.Location = new System.Drawing.Point(383, 316);
            this.ERISKLabel.Name = "ERISKLabel";
            this.ERISKLabel.Size = new System.Drawing.Size(115, 15);
            this.ERISKLabel.TabIndex = 36;
            this.ERISKLabel.Text = "Exposure Risk? :";
            // 
            // erTB9
            // 
            this.erTB9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erTB9.Location = new System.Drawing.Point(504, 313);
            this.erTB9.Name = "erTB9";
            this.erTB9.Size = new System.Drawing.Size(100, 21);
            this.erTB9.TabIndex = 35;
            // 
            // vTB8
            // 
            this.vTB8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vTB8.Location = new System.Drawing.Point(504, 281);
            this.vTB8.Name = "vTB8";
            this.vTB8.Size = new System.Drawing.Size(100, 21);
            this.vTB8.TabIndex = 34;
            // 
            // cTB7
            // 
            this.cTB7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTB7.Location = new System.Drawing.Point(448, 252);
            this.cTB7.Name = "cTB7";
            this.cTB7.Size = new System.Drawing.Size(109, 21);
            this.cTB7.TabIndex = 33;
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLabel.Location = new System.Drawing.Point(405, 255);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(38, 15);
            this.CityLabel.TabIndex = 32;
            this.CityLabel.Text = "City :";
            // 
            // BRGYLabel
            // 
            this.BRGYLabel.AutoSize = true;
            this.BRGYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BRGYLabel.Location = new System.Drawing.Point(368, 228);
            this.BRGYLabel.Name = "BRGYLabel";
            this.BRGYLabel.Size = new System.Drawing.Size(75, 15);
            this.BRGYLabel.TabIndex = 31;
            this.BRGYLabel.Text = "Barangay :";
            // 
            // HLabel
            // 
            this.HLabel.AutoSize = true;
            this.HLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HLabel.Location = new System.Drawing.Point(335, 201);
            this.HLabel.Name = "HLabel";
            this.HLabel.Size = new System.Drawing.Size(108, 15);
            this.HLabel.TabIndex = 30;
            this.HLabel.Text = "Home Address :";
            // 
            // QLabel
            // 
            this.QLabel.AutoSize = true;
            this.QLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QLabel.Location = new System.Drawing.Point(326, 284);
            this.QLabel.Name = "QLabel";
            this.QLabel.Size = new System.Drawing.Size(172, 15);
            this.QLabel.TabIndex = 29;
            this.QLabel.Text = "Are you fully vaccinated? :";
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLabel.Location = new System.Drawing.Point(332, 174);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(111, 15);
            this.PLabel.TabIndex = 28;
            this.PLabel.Text = "Phone Number :";
            // 
            // SexLabel
            // 
            this.SexLabel.AutoSize = true;
            this.SexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexLabel.Location = new System.Drawing.Point(366, 147);
            this.SexLabel.Name = "SexLabel";
            this.SexLabel.Size = new System.Drawing.Size(77, 15);
            this.SexLabel.TabIndex = 27;
            this.SexLabel.Text = "Sex (F/M) :";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLabel.Location = new System.Drawing.Point(404, 120);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(39, 15);
            this.AgeLabel.TabIndex = 26;
            this.AgeLabel.Text = "Age :";
            // 
            // FLabel
            // 
            this.FLabel.AutoSize = true;
            this.FLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FLabel.Location = new System.Drawing.Point(362, 95);
            this.FLabel.Name = "FLabel";
            this.FLabel.Size = new System.Drawing.Size(81, 15);
            this.FLabel.TabIndex = 25;
            this.FLabel.Text = "Full Name :";
            // 
            // pnTB4
            // 
            this.pnTB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnTB4.Location = new System.Drawing.Point(448, 171);
            this.pnTB4.Name = "pnTB4";
            this.pnTB4.Size = new System.Drawing.Size(109, 21);
            this.pnTB4.TabIndex = 24;
            // 
            // haTB5
            // 
            this.haTB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haTB5.Location = new System.Drawing.Point(448, 198);
            this.haTB5.Name = "haTB5";
            this.haTB5.Size = new System.Drawing.Size(180, 21);
            this.haTB5.TabIndex = 23;
            // 
            // bTB6
            // 
            this.bTB6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTB6.Location = new System.Drawing.Point(448, 225);
            this.bTB6.Name = "bTB6";
            this.bTB6.Size = new System.Drawing.Size(109, 21);
            this.bTB6.TabIndex = 22;
            // 
            // sTB3
            // 
            this.sTB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sTB3.Location = new System.Drawing.Point(448, 144);
            this.sTB3.Name = "sTB3";
            this.sTB3.Size = new System.Drawing.Size(109, 21);
            this.sTB3.TabIndex = 21;
            // 
            // aTB2
            // 
            this.aTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aTB2.Location = new System.Drawing.Point(448, 117);
            this.aTB2.Name = "aTB2";
            this.aTB2.Size = new System.Drawing.Size(109, 21);
            this.aTB2.TabIndex = 20;
            // 
            // fnTB1
            // 
            this.fnTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnTB1.Location = new System.Drawing.Point(448, 92);
            this.fnTB1.Name = "fnTB1";
            this.fnTB1.Size = new System.Drawing.Size(180, 21);
            this.fnTB1.TabIndex = 19;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(446, 364);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 29);
            this.btnSubmit.TabIndex = 37;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // RESETbtn
            // 
            this.RESETbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESETbtn.Location = new System.Drawing.Point(555, 47);
            this.RESETbtn.Name = "RESETbtn";
            this.RESETbtn.Size = new System.Drawing.Size(75, 29);
            this.RESETbtn.TabIndex = 38;
            this.RESETbtn.Text = "Reset";
            this.RESETbtn.UseVisualStyleBackColor = true;
            this.RESETbtn.Click += new System.EventHandler(this.RESETbtn_Click);
            // 
            // QRcodepass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(660, 413);
            this.Controls.Add(this.RESETbtn);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.ERISKLabel);
            this.Controls.Add(this.erTB9);
            this.Controls.Add(this.vTB8);
            this.Controls.Add(this.cTB7);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.BRGYLabel);
            this.Controls.Add(this.HLabel);
            this.Controls.Add(this.QLabel);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.SexLabel);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.FLabel);
            this.Controls.Add(this.pnTB4);
            this.Controls.Add(this.haTB5);
            this.Controls.Add(this.bTB6);
            this.Controls.Add(this.sTB3);
            this.Controls.Add(this.aTB2);
            this.Controls.Add(this.fnTB1);
            this.Controls.Add(this.PBox);
            this.Controls.Add(this.CBox);
            this.Controls.Add(this.CLabel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.MenuQRG);
            this.MainMenuStrip = this.MenuQRG;
            this.Name = "QRcodepass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRcodepass_FormClosing);
            this.Load += new System.EventHandler(this.QRcodepass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBox)).EndInit();
            this.MenuQRG.ResumeLayout(false);
            this.MenuQRG.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label CLabel;
        private System.Windows.Forms.ComboBox CBox;
        private System.Windows.Forms.PictureBox PBox;
        private System.Windows.Forms.MenuStrip MenuQRG;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.Timer Ftimer;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem MenuName;
        private System.Windows.Forms.Label ERISKLabel;
        private System.Windows.Forms.TextBox erTB9;
        private System.Windows.Forms.TextBox vTB8;
        private System.Windows.Forms.TextBox cTB7;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label BRGYLabel;
        private System.Windows.Forms.Label HLabel;
        private System.Windows.Forms.Label QLabel;
        private System.Windows.Forms.Label PLabel;
        private System.Windows.Forms.Label SexLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label FLabel;
        private System.Windows.Forms.TextBox pnTB4;
        private System.Windows.Forms.TextBox haTB5;
        private System.Windows.Forms.TextBox bTB6;
        private System.Windows.Forms.TextBox sTB3;
        private System.Windows.Forms.TextBox aTB2;
        private System.Windows.Forms.TextBox fnTB1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button RESETbtn;
    }
}