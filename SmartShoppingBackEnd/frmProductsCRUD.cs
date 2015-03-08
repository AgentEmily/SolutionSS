using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Data.Objects;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;


namespace SmartShoppingBackEnd
{
    public partial class frmProductsCRUD : SmartShoppingBackEnd.frmBase
    {

        public frmProductsCRUD()
        {
            InitializeComponent();
        }

        global::SmartShoppingBackEnd.SmartShoppingEntities SSEntities = new SmartShoppingEntities();
        bool ReadOnly = true;

        private void setReadOnly()
        {
            this.productNameTextBox.ReadOnly = ReadOnly;
            this.unitPriceTextBox.ReadOnly = ReadOnly;
            this.qtyperUnitTextBox.ReadOnly = ReadOnly;
            this.stockTextBox.ReadOnly = ReadOnly;
            this.discontinuedCheckBox.Enabled = !ReadOnly;
            this.category_IDComboBox.Enabled = !ReadOnly;
            this.brand_IDComboBox.Enabled = !ReadOnly;
            this.descriptionTextBox.ReadOnly = ReadOnly;
            this.startDateDateTimePicker.Enabled = !ReadOnly;
            this.endDateDateTimePicker.Enabled = !ReadOnly;
            commentTextBox.ReadOnly = ReadOnly;
        }

        public void ResetProductsData()
        {
            var q = from p in SSEntities.Products select p;
            ProductsBindingSource.DataSource = q.ToList();
            this.productsDataGridView.DataSource = ProductsBindingSource;
            this.productsDataGridView.Refresh();

            ReadOnly = true;
            setReadOnly();
        }

        private void frmProductsCRUD_Load(object sender, EventArgs e)//FormLoad事件-讀資料
        {
            ResetProductsData();

            var c = from p in SSEntities.Categories
                    where p.PCategory_ID.Value != null
                    select new { p.Category_ID, p.CategoryName };
            this.CategoriesBindingSource.DataSource = c.ToList();

            var b = from p in SSEntities.Brands
                    select new { p.Brand_ID, p.BrandName };
            this.BrandsBindingSource.DataSource = b.ToList();

        }

        public override void btnFirst_Click(object sender, EventArgs e)//首筆
        {
            ProductsBindingSource.MoveFirst();
        }

        public override void btnPrior_Click(object sender, EventArgs e)//前筆
        {
            ProductsBindingSource.MovePrevious();
        }

        public override void btnNext_Click(object sender, EventArgs e)//次筆
        {
            ProductsBindingSource.MoveNext();
        }

        public override void btnLast_Click(object sender, EventArgs e)//末筆
        {
            ProductsBindingSource.MoveLast();
        }

        public override void btnAddNew_Click(object sender, EventArgs e)//新增
        {
            try
            { ProductsBindingSource.AddNew(); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            this.productsDataGridView.Refresh();
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
                //ProductsBindingSource.RemoveCurrent(); 
                var p = (Products)this.ProductsBindingSource.Current;
                SSEntities.Products.Remove(p);
                SSEntities.SaveChanges();
                ResetProductsData();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            this.productsDataGridView.Refresh();
        }

        public override void btnCancelEdit_Click(object sender, EventArgs e)//取消
        {
            ProductsBindingSource.CancelEdit();
            ResetProductsData();
        }

        public override void btnSaveChange_Click(object sender, EventArgs e)//儲存
        {
            ProductsBindingSource.EndEdit();
            this.SSEntities.SaveChanges();
            ResetProductsData();
        }

        public override void btnSearch_Click(object sender, EventArgs e)
        {
                frmProductsSearch Sform = new frmProductsSearch();
                Sform.SearchTextBox.Text = this.tbxSearch.Text;
                if (Sform.ShowDialog() == DialogResult.OK && Sform.Product_ID != 0)
                {
                    int Index = Sform.Product_ID;//從Sform取值設定到this
                    this.ProductsBindingSource.Position = Index;
                }
        }

        private void exLabel1_Click(object sender, EventArgs e)
        {
            this.productNameTextBox.Text = "液態葉黃素(30粒)";
            this.unitPriceTextBox.Text = "295";
            this.qtyperUnitTextBox.Text = "1";
            this.stockTextBox.Text = "230";
            this.discontinuedCheckBox.CheckState = CheckState.Checked;

            this.descriptionTextBox.Text = "食用如有不適請即刻停止食用並請教醫師。正在服用抗膽固醇藥物者，請先醫師後再服用。 ";
        }
    }
}
