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
            // QRHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.QRLabel);
            this.Controls.Add(this.BTNDirect);
            this.Controls.Add(this.BTNCreate);
            this.Name = "QRHome";
            this.Text = "QR Code Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCreate;
        private System.Windows.Forms.Button BTNDirect;
        private System.Windows.Forms.Label QRLabel;
    }
}