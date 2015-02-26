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
            this.titleLabel.Location = new System.Drawing.Point(41, 5);
            this.titleLabel.Size = new System.Drawing.Size(119, 24);
            this.titleLabel.Text = "pictureTitle";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.entryPictureBox);
            this.entryPanel.Location = new System.Drawing.Point(8, 37);
            this.entryPanel.Size = new System.Drawing.Size(185, 178);
            // 
            // entryPictureBox
            // 
            this.entryPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.entryPictureBox.Location = new System.Drawing.Point(0, 0);
            this.entryPictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.entryPictureBox.Name = "entryPictureBox";
            this.entryPictureBox.Padding = new System.Windows.Forms.Padding(10);
            this.entryPictureBox.Size = new System.Drawing.Size(185, 178);
            this.entryPictureBox.TabIndex = 0;
            this.entryPictureBox.TabStop = false;
            // 
            // PictureBoxEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "PictureBoxEntry";
            this.Size = new System.Drawing.Size(201, 222);
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
