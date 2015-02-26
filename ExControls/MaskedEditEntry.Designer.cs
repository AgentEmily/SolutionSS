namespace ExControls
{
    partial class MaskedEditEntry
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
            this.entryMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.entryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.entryMaskedTextBox);
            // 
            // entryMaskedTextBox
            // 
            this.entryMaskedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.entryMaskedTextBox.Location = new System.Drawing.Point(10, 6);
            this.entryMaskedTextBox.Name = "entryMaskedTextBox";
            this.entryMaskedTextBox.Size = new System.Drawing.Size(252, 13);
            this.entryMaskedTextBox.TabIndex = 0;
            // 
            // MaskedEditEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MaskedEditEntry";
            this.entryPanel.ResumeLayout(false);
            this.entryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox entryMaskedTextBox;
    }
}
