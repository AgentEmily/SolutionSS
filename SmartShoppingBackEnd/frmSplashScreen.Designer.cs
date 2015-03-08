namespace SmartShoppingBackEnd
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.LbApplicationTitle = new System.Windows.Forms.Label();
            this.LbCompany = new System.Windows.Forms.Label();
            this.LbVersion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LbApplicationTitle
            // 
            this.LbApplicationTitle.AutoSize = true;
            this.LbApplicationTitle.ForeColor = System.Drawing.Color.White;
            this.LbApplicationTitle.Location = new System.Drawing.Point(28, 292);
            this.LbApplicationTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbApplicationTitle.Name = "LbApplicationTitle";
            this.LbApplicationTitle.Size = new System.Drawing.Size(239, 25);
            this.LbApplicationTitle.TabIndex = 0;
            this.LbApplicationTitle.Text = "SmartShoppingBackEnd";
            // 
            // LbCompany
            // 
            this.LbCompany.AutoSize = true;
            this.LbCompany.ForeColor = System.Drawing.Color.White;
            this.LbCompany.Location = new System.Drawing.Point(28, 337);
            this.LbCompany.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbCompany.Name = "LbCompany";
            this.LbCompany.Size = new System.Drawing.Size(188, 25);
            this.LbCompany.TabIndex = 1;
            this.LbCompany.Text = "MSIT99 2nd group";
            // 
            // LbVersion
            // 
            this.LbVersion.AutoSize = true;
            this.LbVersion.ForeColor = System.Drawing.Color.White;
            this.LbVersion.Location = new System.Drawing.Point(28, 382);
            this.LbVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LbVersion.Name = "LbVersion";
            this.LbVersion.Size = new System.Drawing.Size(116, 25);
            this.LbVersion.TabIndex = 2;
            this.LbVersion.Text = "Version 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 97);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(45, 27);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(342, 50);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "智慧購物管理系統";
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(423, 422);
            this.ControlBox = false;
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LbVersion);
            this.Controls.Add(this.LbCompany);
            this.Controls.Add(this.LbApplicationTitle);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplashScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbApplicationTitle;
        private System.Windows.Forms.Label LbCompany;
        private System.Windows.Forms.Label LbVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelTitle;
    }
}