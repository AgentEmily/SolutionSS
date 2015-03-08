using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace ExControls
{
    public partial class RoundCornerPanel : Panel
    {
        public RoundCornerPanel()
        {
            InitializeComponent();
        }

        public RoundCornerPanel(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void RoundCornerPanel_Resize(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            GraphicsPath path = Helper.GetRoundRectPath(rect, 8);
            this.Region = new Region(path);
        }
    }
}
