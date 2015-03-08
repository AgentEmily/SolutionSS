namespace ExControls
{
    public partial class BaseEntry
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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.entryPanel = new ExControls.RoundCornerPanel(this.components);
            this.refreshTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.titleLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.titleLabel.Location = new System.Drawing.Point(5, 5);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(119, 20);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            this.titleLabel.MouseLeave += new System.EventHandler(this.BaseEntry_MouseLeave);
            this.titleLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseEntry_MouseDown);
            this.titleLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseEntry_MouseMove);
            this.titleLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BaseEntry_MouseClick);
            this.titleLabel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BaseEntry_MouseDoubleClick);
            this.titleLabel.MouseEnter += new System.EventHandler(this.BaseEntry_MouseEnter);
            // 
            // entryPanel
            // 
            this.entryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.entryPanel.BackColor = System.Drawing.Color.White;
            this.entryPanel.Location = new System.Drawing.Point(130, 3);
            this.entryPanel.Name = "entryPanel";
            this.entryPanel.Size = new System.Drawing.Size(270, 25);
            this.entryPanel.TabIndex = 3;
            this.entryPanel.Move += new System.EventHandler(this.entryPanel_Move);
            this.entryPanel.Resize += new System.EventHandler(this.entryPanel_Resize);
            // 
            // refreshTimer
            // 
            this.refreshTimer.Tick += new System.EventHandler(this.refreshTimer_Tick);
            // 
            // BaseEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.entryPanel);
            this.Name = "BaseEntry";
            this.Size = new System.Drawing.Size(411, 32);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BaseEntry_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BaseEntry_MouseMove);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BaseEntry_MouseClick);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BaseEntry_MouseDoubleClick);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.BaseEntry_ControlAdded);
            this.Resize += new System.EventHandler(this.BaseEntry_Resize);
            this.MouseEnter += new System.EventHandler(this.BaseEntry_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.BaseEntry_MouseLeave);
            this.EnabledChanged += new System.EventHandler(this.BaseEntry_EnabledChanged);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label titleLabel;
        protected RoundCornerPanel entryPanel;
        private System.Windows.Forms.Timer refreshTimer;




    }
}
