namespace ExControls
{
    partial class MonthCalendarEntry
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
            this.entryMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.entryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLabel.Location = new System.Drawing.Point(37, 5);
            this.titleLabel.Size = new System.Drawing.Size(110, 28);
            this.titleLabel.Text = "calendarTitle";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // entryPanel
            // 
            this.entryPanel.Controls.Add(this.entryMonthCalendar);
            this.entryPanel.Location = new System.Drawing.Point(8, 40);
            this.entryPanel.Size = new System.Drawing.Size(186, 173);
            // 
            // entryMonthCalendar
            // 
            this.entryMonthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.entryMonthCalendar.Location = new System.Drawing.Point(7, 9);
            this.entryMonthCalendar.Name = "entryMonthCalendar";
            this.entryMonthCalendar.TabIndex = 0;
            // 
            // MonthCalendarEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Name = "MonthCalendarEntry";
            this.Size = new System.Drawing.Size(202, 216);
            this.TitleText = "calendarTitle";
            this.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleWidth = 110;
            this.entryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar entryMonthCalendar;
    }
}
