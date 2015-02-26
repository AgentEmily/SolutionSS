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
    public partial class frmUserPassword : frmBaseSearch
    {
        public frmUserPassword()
        {
            InitializeComponent();
        }

        private void frmUserPassword_Shown(object sender, EventArgs e)
        {
            OrignalPasswordTextBox.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //開始密碼變更，禁止關閉視窗
            CanClose = false;

            //驗證程序
            try
            {
                if (NewPasswordTextBox.Text == "")
                {
                    MessageBox.Show("新密碼不可空白！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NewPasswordTextBox.Focus();
                    return;
                }
                if (NewPasswordTextBox.Text != ConfirmPasswordTextBox.Text)
                {
                    MessageBox.Show("新密碼與確認密碼不一致！", "錯誤",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NewPasswordTextBox.Focus();
                    return;
                }
                using (var SSEntities = new SmartShoppingEntities())
                {
                    var qry = (from U in SSEntities.SSUsers
                                       where U.Employee_ID == frmMain.FUserID && U.Password == OrignalPasswordTextBox.Text
                                      select U).FirstOrDefault();
                    if (qry == null)
                    {
                        MessageBox.Show("原來密碼錯誤！", "錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        OrignalPasswordTextBox.Focus();
                        return;
                    }

                    //開始更新使用者的密碼
                    qry.Password = NewPasswordTextBox.Text;
                    SSEntities.SaveChanges();
                    MessageBox.Show("密碼變更完成，下次登入請使用新密碼", "變更密碼",MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            //完成密碼變更，允許關閉視窗
            CanClose = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //取消密碼變更，允許關閉視窗
            CanClose = true;
        }

    }
}
