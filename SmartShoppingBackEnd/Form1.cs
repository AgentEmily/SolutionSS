using SkinSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShoppingBackEnd
{


    public partial class Form1 : Form
    {         
        public SkinH_Net skinh;

        public Form1()
        {
            InitializeComponent();

            skinh = new SkinH_Net();
            skinh.AttachEx("skins\\［X.o］-0001.she", "");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string skin = this.textBox1.Text;
            skinh.AttachEx("skins\\"+skin, "");
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.reportDS);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'reportDS.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.reportDS.Products);

        }
    }
}
