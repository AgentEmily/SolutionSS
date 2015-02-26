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
    public partial class frmBaseDialog : Form
    {
        public frmBaseDialog()
        {
            InitializeComponent();
        }

        bool FCanClose = false;
        public bool CanClose
        {
            get { return FCanClose; }
            set { FCanClose = value; }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FCanClose = true;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BaseDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !FCanClose;
        }
    }
}
