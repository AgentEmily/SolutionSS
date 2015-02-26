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
    public partial class frmVendorsSearch : SmartShoppingBackEnd.frmBaseSearch
    {
        public frmVendorsSearch()
        {
            InitializeComponent();
        }

        public int Vendor_ID
        {
            //

            get
            {
                //回覆使用者所選擇的廠商編號
                if (this.VendorsBindingSource.Count != 0)
                    //return (int)VendorsDataGridView.Rows[VendorsBindingSource.Position]
                    //                           .Cells[0].Value;
                    return this.VendorsBindingSource.Position;
                else
                {
                    return 0;
                }
            }
        }

        private void GetAllVendors()
        {
            using (var context = new SmartShoppingEntities())
            {
                //取得廠商資料表所有的記錄
                //var qry = context.Vendors.Execute(MergeOption.OverwriteChanges);
                var qry = from p in context.Vendors select p;
                Debug.WriteLine(qry.ToString());

                //將取得的結果指派給BindingSource控制項的DataSource
                //VendorsBindingSource.DataSource = qry;
                VendorsBindingSource.DataSource = qry.ToList();
            }
        }

        private void SearchVendors()
        {
            if (SearchTextBox.Text == String.Empty)
            {
                //查詢資料為空字串，取得所有的廠商記錄
                GetAllVendors();
            }
            else
            {
                switch (SearchByComboBox.SelectedIndex)
                {
                    case 0:
                        //依廠商編號查詢
                        using (var context = new SmartShoppingEntities())
                        {
                            //取得廠商資料表符合廠商編號條件的記錄
                            var qry = from p in context.Vendors
                                      where p.Vendor_ID.ToString() == SearchTextBox.Text
                                      select p;

                            //將取得的結果指派給BindingSource控制項的DataSource
                            VendorsBindingSource.DataSource = qry.ToList();
                        }
                        break;
                    case 1:
                        //依廠商名稱查詢
                        using (var context = new SmartShoppingEntities())
                        {
                            //取得廠商資料表符合廠商名稱條件的記錄
                            var qry = from p in context.Vendors
                                      where p.VendorName.Contains(SearchTextBox.Text)
                                      select p;

                            //將取得的結果指派給BindingSource控制項的DataSource
                            VendorsBindingSource.DataSource = qry.ToList();
                        }
                        break;
                    case 2:
                        //依統一編號查詢
                        using (var context = new SmartShoppingEntities())
                        {
                            //取得廠商資料表符合統一編號條件的記錄
                            var qry = from p in context.Vendors
                                      where p.UnifiedBusinessNumber == SearchTextBox.Text
                                      select p;

                            //將取得的結果指派給BindingSource控制項的DataSource
                            VendorsBindingSource.DataSource = qry.ToList();
                        }
                        break;
                }
            }
        }

        private void frmVendorsSearch_Load(object sender, EventArgs e)
        {
            //預設的查詢依據-廠商編號
            SearchByComboBox.SelectedIndex = 0;
            //取得廠商資料表所有的記錄
            SearchVendors();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            SearchVendors();
        }

        private void SearchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchVendors();
        }

        public void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }


    }
}




