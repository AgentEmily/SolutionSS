using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SmartShoppingBackEnd
{
    public partial class frmLogin : SmartShoppingBackEnd.frmBaseDialog
    {
        //認證次數
        int Logincount;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Logincount = 0;
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            this.txtEmployeeID.Focus();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {             
            CanClose = false;

            using (var SSEntity=new SmartShoppingEntities())
            {
                var q = (from u in SSEntity.SSUsers
                         where u.Employee_ID == this.txtEmployeeID.Text && u.Password == this.txtPassword.Text
                         select new { u.Employee_ID, EmployeeName = u.EmployeeName }).FirstOrDefault();
                if (q == null)
                {
                    MessageBox.Show("登入帳號或密碼錯誤!", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmMain.FAllowCheck = false;
                    Logincount++;
                    if (Logincount == 3)
                    {
                        MessageBox.Show("登入錯誤已達3次!", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CanClose = true;
                    }
    }
                else
                {
                    frmMain.FAllowCheck = true;
                    frmMain.FUserID = q.Employee_ID;
                    frmMain.FUserName = q.EmployeeName;
                    CanClose = true;
                }
            }
        }
    }
}
