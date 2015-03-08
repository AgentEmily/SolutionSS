using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ExControls
{
    public partial class RoundCornerForm : Form
    {
        private bool isDrag = false;
        private Size mouseDistance;

        public RoundCornerForm()
        {
            InitializeComponent();
        }

        private void RoundRectForm_Resize(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, Width, Height);
            GraphicsPath path = Helper.GetRoundRectPath(rect, 8);
            this.Region = new Region(path);

        }

        private void RoundRectForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                this.Location = new Point(MousePosition.X - mouseDistance.Width, MousePosition.Y - mouseDistance.Height);
            }

        }

        private void RoundRectForm_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = !(e.Button == MouseButtons.Left);
        }

        private void RoundRectForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDistance = new Size(MousePosition.X - Location.X, MousePosition.Y - Location.Y);

            isDrag = e.Button == MouseButtons.Left;
        }
    }
}