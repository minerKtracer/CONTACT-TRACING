namespace MY_CONTACT_TRACING
{
    partial class Homepage
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
            this.BtnManual = new System.Windows.Forms.Button();
            this.BtnQRCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cname = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Cname.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnManual
            // 
            this.BtnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnManual.Location = new System.Drawing.Point(108, 100);
            this.BtnManual.Name = "BtnManual";
            this.BtnManual.Size = new System.Drawing.Size(85, 35);
            this.BtnManual.TabIndex = 0;
            this.BtnManual.Text = "Manual ";
            this.BtnManual.UseVisualStyleBackColor = true;
            this.BtnManual.Click += new System.EventHandler(this.BtnManual_Click);
            // 
            // BtnQRCode
            // 
            this.BtnQRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnQRCode.Location = new System.Drawing.Point(108, 141);
            this.BtnQRCode.Name = "BtnQRCode";
            this.BtnQRCode.Size = new System.Drawing.Size(85, 35);
            this.BtnQRCode.TabIndex = 1;
            this.BtnQRCode.Text = "QR Code";
            this.BtnQRCode.UseVisualStyleBackColor = true;
            this.BtnQRCode.Click += new System.EventHandler(this.BtnQRCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(21, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Get Pass :";
            // 
            // Cname
            // 
            this.Cname.BackColor = System.Drawing.Color.Lavender;
            this.Cname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cname.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.Cname.Location = new System.Drawing.Point(0, 239);
            this.Cname.Name = "Cname";
            this.Cname.Size = new System.Drawing.Size(284, 22);
            this.Cname.TabIndex = 3;
            this.Cname.Text = "Program Town Inc.";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(124, 17);
            this.toolStripStatusLabel2.Text = "Program Town Inc.";
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Cname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnQRCode);
            this.Controls.Add(this.BtnManual);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.VisibleChanged += new System.EventHandler(this.Homepage_Load);
            this.Cname.ResumeLayout(false);
            this.Cname.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnManual;
        private System.Windows.Forms.Button BtnQRCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip Cname;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}