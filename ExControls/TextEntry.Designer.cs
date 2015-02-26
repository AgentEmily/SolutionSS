namespace ExControls
{
    partial class TextEntry
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
            this.entryTextBox = new ExControls.ExTextBox();
            this.entryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Size = new System.Drawing.Size(120, 25);
            this.titleLabel.Text = "textBoxTitle";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.entryTextBox);
            // 
            // entryTextBox
            // 
            this.entryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.entryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entryTextBox.Location = new System.Drawing.Point(7, 4);
            this.entryTextBox.Name = "entryTextBox";
            this.entryTextBox.Size = new System.Drawing.Size(257, 17);
            this.entryTextBox.TabIndex = 0;
            // 
            // TextEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "TextEntry";
            this.TitleText = "textBoxTitle";
            this.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleWidth = 120;
            this.entryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ExTextBox entryTextBox;


    }
}
