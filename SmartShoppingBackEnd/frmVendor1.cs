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
    public partial class frmVendor1 : Form
    {
        public frmVendor1()
        {
            InitializeComponent();
        }

        private void vendorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vendorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.smartShoppingDataSet);

        }

        private void frmVendor1_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Vendors' 資料表。您可以視需要進行移動或移除。
            this.vendorsTableAdapter.Fill(this.smartShoppingDataSet.Vendors);

        }
    }
}
