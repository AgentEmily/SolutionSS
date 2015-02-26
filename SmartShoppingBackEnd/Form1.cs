using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;


namespace SmartShoppingBackEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
// TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Categories' 資料表。您可以視需要進行移動或移除。
            //ElementHost elementHost = new ElementHost();
            //global::WpfControlLibrary1.ImageMirror control = new WpfControlLibrary1.ImageMirror();
            //elementHost.Child = control;
            //elementHost.Dock = DockStyle.Fill;
            //this.Controls.Add(elementHost);
            
            
        }

        private void elementHost1_ChildChanged(object sender, ChildChangedEventArgs e)
        {

        }
    }
}
