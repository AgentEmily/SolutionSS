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
    public partial class frmPurchaseOrderQuery : Form
    {
        private int PurchID;
        private String PurchDateS;
        private String PurchDateE;

        public int My進貨單號
        {
            get { return PurchID; }
            set { PurchID = value; }
        }

        public String My訂單日期起
        {
            get { return PurchDateS; }
            set { PurchDateS = value; }
        }

        public String My訂單日期迄
        {
            get { return PurchDateE; }
            set { PurchDateE = value; }
        }

        public frmPurchaseOrderQuery()
        {
            InitializeComponent();
        }

        public DialogResult dlgResult;

        

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() != "")
            {
                if (!int.TryParse(textBox1.Text, out PurchID))
                {
                    MessageBox.Show("進貨單號請輸入數字！");
                }
            }
            if (this.checkBox1.Checked)
            {
                My訂單日期起 = Convert.ToString(dateTimePicker1.Value.Date);
                My訂單日期迄 = Convert.ToString(dateTimePicker2.Value.Date);
            }
            else
            {
                My訂單日期起 = "";
                My訂單日期迄 = "";
            }


            Close();
            dlgResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            dlgResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
