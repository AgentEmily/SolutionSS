namespace ExControls
{
    partial class LabelEntry
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
            this.entryLabel = new System.Windows.Forms.Label();
            this.entryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Location = new System.Drawing.Point(7, 3);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.titleLabel.Size = new System.Drawing.Size(160, 29);
            this.titleLabel.Text = "labelTitle";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.entryLabel);
            this.entryPanel.Location = new System.Drawing.Point(231, 3);
            this.entryPanel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.entryPanel.Size = new System.Drawing.Size(480, 29);
            // 
            // entryLabel
            // 
            this.entryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entryLabel.Location = new System.Drawing.Point(17, 6);
            this.entryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.entryLabel.Name = "entryLabel";
            this.entryLabel.Size = new System.Drawing.Size(335, 18);
            this.entryLabel.TabIndex = 0;
            this.entryLabel.Text = "entryLabel";
            // 
            // LabelEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "LabelEntry";
            this.NormalBackColor1 = System.Drawing.Color.White;
            this.NormalBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.TitleText = "labelTitle";
            this.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleWidth = 160;
            this.entryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label entryLabel;
    }
}
