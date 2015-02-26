namespace ExControls
{
    partial class ComboBoxEntry
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
            this.entryComboBox = new System.Windows.Forms.ComboBox();
            this.entryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Text = "comboBoxTitle";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.entryComboBox);
            // 
            // entryComboBox
            // 
            this.entryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.entryComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.entryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entryComboBox.FormattingEnabled = true;
            this.entryComboBox.Location = new System.Drawing.Point(7, 2);
            this.entryComboBox.Name = "entryComboBox";
            this.entryComboBox.Size = new System.Drawing.Size(256, 21);
            this.entryComboBox.TabIndex = 0;
            // 
            // ComboBoxEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "ComboBoxEntry";
            this.TitleText = "comboBoxTitle";
            this.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox entryComboBox;
    }
}
