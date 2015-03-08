namespace ExControls
{
    partial class LinkLabelEntry
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
            this.entryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.entryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Text = "linkTitle";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.entryLinkLabel);
            // 
            // entryLinkLabel
            // 
            this.entryLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.entryLinkLabel.Location = new System.Drawing.Point(7, 5);
            this.entryLinkLabel.Name = "entryLinkLabel";
            this.entryLinkLabel.Size = new System.Drawing.Size(257, 14);
            this.entryLinkLabel.TabIndex = 0;
            this.entryLinkLabel.TabStop = true;
            this.entryLinkLabel.Text = "linkLabel1";
            // 
            // LinkLabelEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "LinkLabelEntry";
            this.TitleText = "linkTitle";
            this.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel entryLinkLabel;
    }
}
