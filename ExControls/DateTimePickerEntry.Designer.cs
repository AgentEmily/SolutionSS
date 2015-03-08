namespace ExControls
{
    partial class DateTimePickerEntry
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
            this.entryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.entryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Text = "ddateTimeTitle";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.entryDateTimePicker);
            // 
            // entryDateTimePicker
            // 
            this.entryDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.entryDateTimePicker.Location = new System.Drawing.Point(7, 2);
            this.entryDateTimePicker.Name = "entryDateTimePicker";
            this.entryDateTimePicker.Size = new System.Drawing.Size(256, 20);
            this.entryDateTimePicker.TabIndex = 0;
            // 
            // DateTimePickerEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.MinimumSize = new System.Drawing.Size(0, 32);
            this.Name = "DateTimePickerEntry";
            this.TitleText = "ddateTimeTitle";
            this.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.entryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker entryDateTimePicker;
    }
}
