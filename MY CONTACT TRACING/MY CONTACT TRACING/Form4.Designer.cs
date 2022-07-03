namespace MY_CONTACT_TRACING
{
    partial class QRHome
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
            this.BTNCreate = new System.Windows.Forms.Button();
            this.BTNDirect = new System.Windows.Forms.Button();
            this.QRLabel = new System.Windows.Forms.Label();
            this.MenuQR = new System.Windows.Forms.MenuStrip();
            this.HMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.EMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.COMPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuQR.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNCreate
            // 
            this.BTNCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCreate.Location = new System.Drawing.Point(97, 105);
            this.BTNCreate.Name = "BTNCreate";
            this.BTNCreate.Size = new System.Drawing.Size(90, 36);
            this.BTNCreate.TabIndex = 0;
            this.BTNCreate.Text = "Sign up";
            this.BTNCreate.UseVisualStyleBackColor = true;
            this.BTNCreate.Click += new System.EventHandler(this.BTNCreate_Click);
            // 
            // BTNDirect
            // 
            this.BTNDirect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDirect.Location = new System.Drawing.Point(97, 147);
            this.BTNDirect.Name = "BTNDirect";
            this.BTNDirect.Size = new System.Drawing.Size(90, 36);
            this.BTNDirect.TabIndex = 1;
            this.BTNDirect.Text = "Sign in";
            this.BTNDirect.UseVisualStyleBackColor = true;
            this.BTNDirect.Click += new System.EventHandler(this.BTNDirect_Click);
            // 
            // QRLabel
            // 
            this.QRLabel.AutoSize = true;
            this.QRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRLabel.Location = new System.Drawing.Point(27, 74);
            this.QRLabel.Name = "QRLabel";
            this.QRLabel.Size = new System.Drawing.Size(146, 16);
            this.QRLabel.TabIndex = 2;
            this.QRLabel.Text = "QR Code Get Pass :";
            // 
            // MenuQR
            // 
            this.MenuQR.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HMenu,
            this.AMenu});
            this.MenuQR.Location = new System.Drawing.Point(0, 0);
            this.MenuQR.Name = "MenuQR";
            this.MenuQR.Size = new System.Drawing.Size(284, 24);
            this.MenuQR.TabIndex = 21;
            // 
            // HMenu
            // 
            this.HMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EMenu});
            this.HMenu.Name = "HMenu";
            this.HMenu.Size = new System.Drawing.Size(44, 20);
            this.HMenu.Text = "Help";
            // 
            // EMenu
            // 
            this.EMenu.Name = "EMenu";
            this.EMenu.Size = new System.Drawing.Size(152, 22);
            this.EMenu.Text = "Exit";
            this.EMenu.Click += new System.EventHandler(this.EMenu_Click);
            // 
            // AMenu
            // 
            this.AMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.COMPMenu});
            this.AMenu.Name = "AMenu";
            this.AMenu.Size = new System.Drawing.Size(52, 20);
            this.AMenu.Text = "About";
            // 
            // COMPMenu
            // 
            this.COMPMenu.Name = "COMPMenu";
            this.COMPMenu.Size = new System.Drawing.Size(173, 22);
            this.COMPMenu.Text = "Program Town Inc.";
            this.COMPMenu.Click += new System.EventHandler(this.COMPMenu_Click);
            // 
            // QRHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MenuQR);
            this.Controls.Add(this.QRLabel);
            this.Controls.Add(this.BTNDirect);
            this.Controls.Add(this.BTNCreate);
            this.Name = "QRHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Home";
            this.MenuQR.ResumeLayout(false);
            this.MenuQR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCreate;
        private System.Windows.Forms.Button BTNDirect;
        private System.Windows.Forms.Label QRLabel;
        private System.Windows.Forms.MenuStrip MenuQR;
        private System.Windows.Forms.ToolStripMenuItem HMenu;
        private System.Windows.Forms.ToolStripMenuItem EMenu;
        private System.Windows.Forms.ToolStripMenuItem AMenu;
        private System.Windows.Forms.ToolStripMenuItem COMPMenu;
    }
}