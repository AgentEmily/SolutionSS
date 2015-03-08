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
    public partial class frmProductsSearch : SmartShoppingBackEnd.frmBaseSearch
    {
        public frmProductsSearch()
        {
            InitializeComponent();
        }

        public int Product_ID
        {
            get
            {
                //回覆使用者所選擇的商品編號
                if (productBindingSource.Count!=0)
                    return (int)productDataGridView.Rows[productBindingSource.Position].Cells[0].Value;
                else
                    return 0;
            }
        }

        private void GetAllProducts()
        {
            using (var context = new SmartShoppingEntities())
            {
                //取得廠商資料表所有的記錄
                var qry = from p in context.Products select p;
                Debug.WriteLine(qry.ToString());

                //將取得的結果指派給BindingSource控制項的DataSource
                productBindingSource.DataSource = qry.ToList();
            }
        }

        private void SearchProducts()
        {
            if (SearchTextBox.Text == String.Empty)
            {
                //查詢資料為空字串，取得所有的廠商記錄
                GetAllProducts();
            }
            else
            {
                switch (SearchByComboBox.SelectedIndex)
                {
                    case 0:
                        //依商品編號查詢
                        using (var context = new SmartShoppingEntities())
                        {
                            //取得商品資料表商品編號條件的記錄
                            var qry = from p in context.Products
                                      where p.Product_ID.ToString() == SearchTextBox.Text
                                      select p;

                            //將取得的結果指派給BindingSource控制項的DataSource
                            productBindingSource.DataSource = qry.ToList();
                        }
                        break;
                    case 1:
                        //依商品名稱查詢
                        using (var context = new SmartShoppingEntities())
                        {
                            //取得商品資料符合商品名稱條件的記錄
                            var qry = from p in context.Products
                                      where p.ProductName.Contains(SearchTextBox.Text)
                                      select p;

                            //將取得的結果指派給BindingSource控制項的DataSource
                            productBindingSource.DataSource = qry.ToList();
                        }
                        break;
                    case 2:
                        //依商品分類查詢
                        using (var context = new SmartShoppingEntities())
                        {
                            //取得商品資料符合商品名稱分類條件的記錄
                            var ID = from p in context.Categories
                                     where p.CategoryName == SearchTextBox.Text
                                     select p.Category_ID;

                            var qry = from p in context.Products
                                      where p.Category_ID == ID.First()
                                      select p;

                            //將取得的結果指派給BindingSource控制項的DataSource
                            productBindingSource.DataSource = qry.ToList();
                        }
                        break;
                }
            }

        }

        private void fmQryProduct_Load(object sender, EventArgs e)
        {
            //預設的查詢依據-商品編號
            SearchByComboBox.SelectedIndex = 0;
            SearchProducts();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void SearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }

        public void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

    }
}
