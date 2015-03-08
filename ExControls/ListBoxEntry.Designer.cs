namespace ExControls
{
    partial class ListBoxEntry
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
            this.entryListBox = new System.Windows.Forms.ListBox();
            this.entryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Size = new System.Drawing.Size(170, 25);
            this.titleLabel.Text = "listBoxTitle";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.entryListBox);
            this.entryPanel.Location = new System.Drawing.Point(8, 38);
            this.entryPanel.Size = new System.Drawing.Size(167, 156);
            // 
            // entryListBox
            // 
            this.entryListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.entryListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entryListBox.FormattingEnabled = true;
            this.entryListBox.Location = new System.Drawing.Point(9, 14);
            this.entryListBox.Name = "entryListBox";
            this.entryListBox.Size = new System.Drawing.Size(148, 130);
            this.entryListBox.TabIndex = 0;
            // 
            // ListBoxEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "ListBoxEntry";
            this.Size = new System.Drawing.Size(186, 199);
            this.TitleText = "listBoxTitle";
            this.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleWidth = 170;
            this.entryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox entryListBox;
    }
}
