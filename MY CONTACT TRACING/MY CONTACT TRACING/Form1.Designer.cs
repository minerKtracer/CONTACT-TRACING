namespace MY_CONTACT_TRACING
{
    partial class GetPass
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
            this.EButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EButton
            // 
            this.EButton.Location = new System.Drawing.Point(102, 215);
            this.EButton.Name = "EButton";
            this.EButton.Size = new System.Drawing.Size(76, 34);
            this.EButton.TabIndex = 0;
            this.EButton.Text = "ENTER";
            this.EButton.UseVisualStyleBackColor = true;
            // 
            // GetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.EButton);
            this.Name = "GetPass";
            this.Text = "THE CONTACT TRACING";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EButton;
    }
}

