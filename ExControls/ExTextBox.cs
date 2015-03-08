using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ExControls
{
    public partial class ExTextBox : TextBox
    {
        public ExTextBox()
        {
            InitializeComponent();

            this.AutoSize = false;
        }

        private void ExTextBox_Resize(object sender, EventArgs e)
        {
            //Rectangle rect = new Rectangle(0,0,Width,Height);
            //GraphicsPath path =  Helper.GetRoundRectPath(rect, 5);
            //this.Region = new Region(path);
        }
    }
}