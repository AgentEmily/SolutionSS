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
    public partial class frmLogin : SmartShoppingBackEnd.BaseDialog
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        int Logincount;
        private void Login_Load(object sender, EventArgs e)
        {
            Logincount = 0;
            this.textBox1.Focus();//不會focus
            
        }
frmMain frmMain = new frmMain();//remove this after figure out
        private void BtnOk_Click(object sender, EventArgs e)
        {
            using (var SSEntity=new SmartShoppingEntities())
            {
                CanClose = false;
                var q = (from u in SSEntity.SSUsers
                         where u.EmployaaName == this.textBox1.Text && u.Password == this.textBox2.Text
                         select new { u.Employee_ID, u.EmployaaName }).FirstOrDefault();

                         if (q==null)
	{
		 MessageBox.Show("登入帳號密碼錯誤", "登入錯誤", MessageBoxButtons.OK,MessageBoxIcon.Error);
                             frmMain.FAllowCheck=false;//fix
                             Logincount++;
                             if (Logincount==3)
                             {
                                 MessageBox.Show("登入次數超過上限!", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 CanClose = true;
                             }


    }
                         else
                         {
                             frmMain.FAllowCheck = true;
                             frmMain.FUserID = int.Parse(q.Employee_ID);
                             frmMain.FUserName = q.EmployaaName;
                             CanClose = true;

                         }
;
            }
        }

    }
}
