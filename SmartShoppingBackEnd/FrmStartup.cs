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
    public partial class frmStartup : Form
    {
        public frmStartup()
        {
            InitializeComponent();
        }

        private void FrmStartup_Load(object sender, EventArgs e)
        {
            this.labelEntry1.EntryText = "包含會員管理、廠商管理、商品管理與類別管理";
            this.labelEntry2.TitleText = "其他功能";
            this.labelEntry2.EntryText = "提供關聯產品報表，讓管理者了解消費者買了A產品可以推薦其他哪些產品給他，做行銷規劃";
            
            
        }

        private void pictureBoxEntry1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxEntry1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
