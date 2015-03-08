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
    public partial class frmCategoriesCRUD : SmartShoppingBackEnd.frmBase
    {
        public frmCategoriesCRUD()
        {
            InitializeComponent();
        }

        global::SmartShoppingBackEnd.SmartShoppingEntities SSEntities = new SmartShoppingEntities();
        bool ReadOnly = true;

        private void setReadOnly()
        {
            this.categoryNameTextBox.ReadOnly = ReadOnly;
            this.pCategory_IDComboBox.Enabled = !ReadOnly;
        }

        public void ResetCategoriesData()//讀資料
        {
            var q = from p in SSEntities.Categories select p;
            this.CategoriesBindingSource.DataSource = q.ToList();
            this.categoriesDataGridView.DataSource = CategoriesBindingSource;
            this.categoriesDataGridView.Refresh();

            ReadOnly = true;
            setReadOnly();
        }

        private void frmCategoriesCRUD_Load(object sender, EventArgs e)//FormLoad事件-讀資料.綁BindingSource
        {
            ResetCategoriesData();

            var pc = from p in SSEntities.Categories
                    where p.PCategory_ID.Value == null
                    select new { p.Category_ID, p.CategoryName };
            this.PCategoriesbindingSource.DataSource = pc.ToList();

            var s = from p in SSEntities.Source
                    select new { p.Source_ID, p.Source1 };
            this.SourcebindingSource.DataSource = s.ToList();

        }

        public override void btnFirst_Click(object sender, EventArgs e)//首筆
        {
            CategoriesBindingSource.MoveFirst();
        }

        public override void btnPrior_Click(object sender, EventArgs e)//前筆
        {
            CategoriesBindingSource.MovePrevious();
        }

        public override void btnNext_Click(object sender, EventArgs e)//次筆
        {
            CategoriesBindingSource.MoveNext();
        }

        public override void btnLast_Click(object sender, EventArgs e)//末筆
        {
            CategoriesBindingSource.MoveLast();
        }

        public override void btnAddNew_Click(object sender, EventArgs e)//新增
        {
            try
            { CategoriesBindingSource.AddNew(); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            this.categoriesDataGridView.Refresh();
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
                //CategoriesBindingSource.RemoveCurrent(); 
                var p = (Categories)this.CategoriesBindingSource.Current;
                SSEntities.Categories.Remove(p);
                SSEntities.SaveChanges();
                ResetCategoriesData();

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            this.categoriesDataGridView.Refresh();
        }

        public override void btnCancelEdit_Click(object sender, EventArgs e)//取消
        {
            CategoriesBindingSource.CancelEdit();
            ResetCategoriesData();
        }

        public override void btnSaveChange_Click(object sender, EventArgs e)//儲存
        {
            CategoriesBindingSource.EndEdit();
            this.SSEntities.SaveChanges();
            ResetCategoriesData();
        }

        public override void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text == null)
            {
                ResetCategoriesData();
            }
            else
            {
                var qry = from p in SSEntities.Categories
                          where p.CategoryName.ToString().Contains(this.tbxSearch.Text) 
                          select p;

                CategoriesBindingSource.DataSource = qry.ToList();
            }
        }

    }
}
