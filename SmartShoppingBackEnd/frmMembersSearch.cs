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
    public partial class frmMembersSearch : SmartShoppingBackEnd.frmBaseSearch
    {
        public frmMembersSearch()
        {
            InitializeComponent();
        }

        public int Member_ID
        {
            get
            {
                //回覆使用者所選擇的會員編號
                if (this.MembersBindingSource.Count!=0)
                {
                    return (int)customerDataGridView.Rows[MembersBindingSource.Position]
                                           .Cells[0].Value;
                }
                else
                {
                    return 0;
                }
                
            }
        }

        private void GetAllMembers()
        {
            using (var context = new SmartShoppingEntities())
            {
                //取得客戶資料表所有的記錄
                var qry = from p in context.Members select p;
                Debug.WriteLine(qry.ToString());

                //將取得的結果指派給BindingSource控制項的DataSource
                MembersBindingSource.DataSource = qry.ToList();
            }
        }

        private void SearchProducts()
        {
            if (SearchTextBox.Text == String.Empty)
            {
                //查詢資料為空字串，取得所有的廠商記錄
                GetAllMembers();
            }
            else
            {
                switch (SearchByComboBox.SelectedIndex)
                {
                    case 0:
                        //依會員編號查詢
                        using (var context = new SmartShoppingEntities())
                        {
                            //取得客戶資料表符合會員編號條件的記錄
                            var qry = from p in context.Members
                                      where p.Member_ID.ToString() == SearchTextBox.Text
                                      select p;

                            //將取得的結果指派給BindingSource控制項的DataSource
                            MembersBindingSource.DataSource = qry.ToList();
                        }
                        break;
                    case 1:
                        //依會員姓名查詢
                        using (var context = new SmartShoppingEntities())
                        {
                            ////取得客戶資料表符合會員姓名條件的記錄
                            var qry = from p in context.Members
                                      where p.MemberName.Contains(SearchTextBox.Text)
                                      select p;

                            //將取得的結果指派給BindingSource控制項的DataSource
                            MembersBindingSource.DataSource = qry.ToList();
                        }
                        break;
                    case 2:
                        //依會員帳號查詢
                        using (var context = new SmartShoppingEntities())
                        {
                            //取得客戶資料表符合會員帳號條件的記錄
                            var qry = from p in context.Members
                                      where p.Username.Contains(SearchTextBox.Text)
                                      select p;

                            //將取得的結果指派給BindingSource控制項的DataSource
                            MembersBindingSource.DataSource = qry.ToList();
                        }
                        break;
                }
            }
        }

        private void frmMembersSearch_Load(object sender, EventArgs e)
        {
            //預設的查詢依據-會員編號
            SearchByComboBox.SelectedIndex = 0;
            //取得客戶資料表所有的記錄
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}