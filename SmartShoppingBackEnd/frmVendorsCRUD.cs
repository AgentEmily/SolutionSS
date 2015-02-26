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
    public partial class frmVendorsCRUD : SmartShoppingBackEnd.frmBase
    {
        public frmVendorsCRUD()
        {
            InitializeComponent();
        }

        global::SmartShoppingBackEnd.SmartShoppingEntities SSEntities = new SmartShoppingEntities();
        bool ReadOnly = true;

        private void setReadOnly()
        {
            this.vendorNameTextBox.ReadOnly = ReadOnly;
            this.unifiedBusinessNumberTextBox.ReadOnly = ReadOnly;
            this.representativeTextBox.ReadOnly = ReadOnly;
            this.telPhoneTextBox.ReadOnly = ReadOnly;
            this.faxTextBox.ReadOnly = ReadOnly;
            this.mobilePhoneTextBox.ReadOnly = ReadOnly;
            this.addressTextBox.ReadOnly = ReadOnly;
            this.deliveryAddressTextBox.ReadOnly = ReadOnly;
            this.emailTextBox.ReadOnly = ReadOnly;
            this.commentTextBox.ReadOnly = ReadOnly;
        }

        public void ResetVendorsData()
        {
            var q = from p in SSEntities.Vendors select p;
            VendorsBindingSource.DataSource = q.ToList();
            this.vendorsDataGridView.DataSource = VendorsBindingSource;
            this.vendorsDataGridView.Refresh();

            ReadOnly = true;
            setReadOnly();
        }

        private void frmVendorsCRUD_Load(object sender, EventArgs e)
        {
            ResetVendorsData();
        }

        public override void btnFirst_Click(object sender, EventArgs e)//首筆
        {
            VendorsBindingSource.MoveFirst();
        }

        public override void btnPrior_Click(object sender, EventArgs e)//前筆
        {
            VendorsBindingSource.MovePrevious();
        }

        public override void btnNext_Click(object sender, EventArgs e)//次筆
        {
            VendorsBindingSource.MoveNext();
        }

        public override void btnLast_Click(object sender, EventArgs e)//末筆
        {
            VendorsBindingSource.MoveLast();
        }

        public override void btnAddNew_Click(object sender, EventArgs e)//新增
        {
            try
            { VendorsBindingSource.AddNew(); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            this.vendorsDataGridView.Refresh();
            ReadOnly = false;
            setReadOnly();
        }

        public override void btnEdit_Click(object sender, EventArgs e)//修改
        {
            if (ReadOnly == true)
            {
                ReadOnly = false;
                setReadOnly();
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)//刪除
        {
            try
            { 
                //VendorsBindingSource.RemoveCurrent(); 
                var p = (Vendors)this.VendorsBindingSource.Current;
                SSEntities.Vendors.Remove(p);
                SSEntities.SaveChanges();
                ResetVendorsData();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            this.vendorsDataGridView.Refresh();
        }

        public override void btnCancelEdit_Click(object sender, EventArgs e)//取消
        {
            VendorsBindingSource.CancelEdit();
            ResetVendorsData();
        }

        public override void btnSaveChange_Click(object sender, EventArgs e)//儲存
        {
            VendorsBindingSource.EndEdit();
            this.SSEntities.SaveChanges();
            ResetVendorsData();
        }

        public override void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text == null)
            {
                ResetVendorsData();
            }
            else
            {
                frmVendorsSearch Sform = new frmVendorsSearch();
                Sform.SearchTextBox.Text = this.tbxSearch.Text;
                if (Sform.ShowDialog() == DialogResult.OK && Sform.Vendor_ID != 0)
                {

                    this.VendorsBindingSource.Position = Sform.Vendor_ID;//從Sform取值設定到this
                }
            }

        }

        private void exLabel1_Click(object sender, EventArgs e)
        {
            this.vendorNameTextBox.Text = "統王企業股份有限公司";
            this.unifiedBusinessNumberTextBox.Text = "65234478";
            this.representativeTextBox.Text = "林思璇";
            this.telPhoneTextBox.Text = "035789652";
            this.faxTextBox.Text = "0227589456";
            this.mobilePhoneTextBox.Text = "0923001546";
            this.addressTextBox.Text = "台中市大肚區沙田路一段485號";
            this.deliveryAddressTextBox.Text = "台中市大肚區沙田路一段485號";
            this.emailTextBox.Text = "rolext01233@gmail.com";
            this.commentTextBox.Text = "賣的衛生紙很便宜";
        }
    }
}