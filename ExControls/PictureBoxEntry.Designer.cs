namespace ExControls
{
    partial class PictureBoxEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entryPictureBox = new System.Windows.Forms.PictureBox();
            this.entryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.entryPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Location = new System.Drawing.Point(55, 6);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.titleLabel.Size = new System.Drawing.Size(159, 28);
            this.titleLabel.Text = "pictureTitle";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.entryPictureBox);
            this.entryPanel.Location = new System.Drawing.Point(11, 43);
            this.entryPanel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.entryPanel.Size = new System.Drawing.Size(247, 205);
            // 
            // entryPictureBox
            // 
            this.entryPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryPictureBox.Location = new System.Drawing.Point(0, 0);
            this.entryPictureBox.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.entryPictureBox.Name = "entryPictureBox";
            this.entryPictureBox.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.entryPictureBox.Size = new System.Drawing.Size(247, 205);
            this.entryPictureBox.TabIndex = 0;
            this.entryPictureBox.TabStop = false;
            // 
            // PictureBoxEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "PictureBoxEntry";
            this.NormalBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.Size = new System.Drawing.Size(268, 256);
            this.TitleText = "pictureTitle";
            this.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.entryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.entryPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox entryPictureBox;

    }
}
