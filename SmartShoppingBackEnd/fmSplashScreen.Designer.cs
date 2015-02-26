namespace SmartShoppingBackEnd
{
    partial class fmSplashScreen
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
            this.LbApplicationTitle = new System.Windows.Forms.Label();
            this.LbCompany = new System.Windows.Forms.Label();
            this.LbVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LbApplicationTitle
            // 
            this.LbApplicationTitle.AutoSize = true;
            this.LbApplicationTitle.Location = new System.Drawing.Point(108, 50);
            this.LbApplicationTitle.Name = "LbApplicationTitle";
            this.LbApplicationTitle.Size = new System.Drawing.Size(146, 15);
            this.LbApplicationTitle.TabIndex = 0;
            this.LbApplicationTitle.Text = "SmartShoppingBackEnd";
            // 
            // LbCompany
            // 
            this.LbCompany.AutoSize = true;
            this.LbCompany.Location = new System.Drawing.Point(108, 87);
            this.LbCompany.Name = "LbCompany";
            this.LbCompany.Size = new System.Drawing.Size(118, 15);
            this.LbCompany.TabIndex = 1;
            this.LbCompany.Text = "MSIT99 2nd group";
            // 
            // LbVersion
            // 
            this.LbVersion.AutoSize = true;
            this.LbVersion.Location = new System.Drawing.Point(113, 127);
            this.LbVersion.Name = "LbVersion";
            this.LbVersion.Size = new System.Drawing.Size(51, 15);
            this.LbVersion.TabIndex = 2;
            this.LbVersion.Text = "Version";
            // 
            // fmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.ControlBox = false;
            this.Controls.Add(this.LbVersion);
            this.Controls.Add(this.LbCompany);
            this.Controls.Add(this.LbApplicationTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fmSplashScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbApplicationTitle;
        private System.Windows.Forms.Label LbCompany;
        private System.Windows.Forms.Label LbVersion;
    }
}