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
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;


namespace SmartShoppingBackEnd
{
    public partial class frmMembersCRUD : SmartShoppingBackEnd.frmBase
    {

        public frmMembersCRUD()
        {
            InitializeComponent();
        }

        global::SmartShoppingBackEnd.SmartShoppingEntities SSEntities = new SmartShoppingEntities();
        bool ReadOnly = true;

        private void setReadOnly()
        {
            this.memberNameTextBox.ReadOnly = ReadOnly;
            this.usernameTextBox.ReadOnly = ReadOnly;
            this.birthdateDateTimePicker.Enabled = !ReadOnly;
            this.telPhoneTextBox.ReadOnly = ReadOnly;
            this.mobilePhoneTextBox.ReadOnly = ReadOnly;
            this.addressTextBox.ReadOnly = ReadOnly;
            this.deliveryAddressTextBox.ReadOnly = ReadOnly;
            this.emailTextBox.ReadOnly = ReadOnly;
            this.m_PicturePictureBox.Enabled = !ReadOnly;
            this.commentTextBox.ReadOnly = ReadOnly;
        }

        public void ResetMembersData()
        {
            var q = from p in SSEntities.Members select p;
            MembersBindingSource.DataSource = q.ToList();
            this.membersdataGridView.DataSource = MembersBindingSource;
            this.membersdataGridView.Refresh();

            ReadOnly = true;
            setReadOnly();
        }

        private void frmMembersCRUD_Load(object sender, EventArgs e)//FormLoad事件-讀資料
        {
            ResetMembersData();
        }

        public override void btnFirst_Click(object sender, EventArgs e)//首筆
        {
            MembersBindingSource.MoveFirst();
        }

        public override void btnPrior_Click(object sender, EventArgs e)//前筆
        {
            MembersBindingSource.MovePrevious();
        }

        public override void btnNext_Click(object sender, EventArgs e)//次筆
        {
            MembersBindingSource.MoveNext();
        }

        public override void btnLast_Click(object sender, EventArgs e)//末筆
        {
            MembersBindingSource.MoveLast();
        }

        public override void btnAddNew_Click(object sender, EventArgs e)//新增
        {
            try
            { MembersBindingSource.AddNew(); }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            this.membersdataGridView.Refresh();
            ReadOnly = false;
            setReadOnly();
        }

        public override void btnEdit_Click(object sender, EventArgs e)//修改
        {
            if(ReadOnly==true)
            {
                ReadOnly = false;
                setReadOnly();
            }
        }

        public override void btnDelete_Click(object sender, EventArgs e)//刪除
        {
            try
            { 
                //MembersBindingSource.RemoveCurrent();
                    var p = (Members)this.MembersBindingSource.Current;
                    SSEntities.Members.Remove(p);
                    SSEntities.SaveChanges();
                    ResetMembersData();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        public override void btnCancelEdit_Click(object sender, EventArgs e)//取消
        {
            MembersBindingSource.CancelEdit();
            ResetMembersData();
        }

        public override void btnSaveChange_Click(object sender, EventArgs e)//儲存
        {
            MembersBindingSource.EndEdit();
            int i = this.SSEntities.SaveChanges();
            this.SSEntities.SaveChanges();

            ResetMembersData();
        }

        public override void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbxSearch.Text == null)
            {
                ResetMembersData();
            }
            else
            {
                frmMembersSearch Sform = new frmMembersSearch();
                Sform.SearchTextBox.Text = this.tbxSearch.Text;
                if (Sform.ShowDialog() == DialogResult.OK && Sform.Member_ID != 0)
                {
                    this.MembersBindingSource.Position = Sform.Member_ID;//從Sform取值設定到this
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.jpg)|*.jpg|(*.gif)|*.gif|(*.bmp)|*.bmp|(*.png)|*.png";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.m_PicturePictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void exLabel1_Click(object sender, EventArgs e)
        {
            this.memberNameTextBox.Text = "吳偉翔";
            this.usernameTextBox.Text = "koala63";
            this.birthdateDateTimePicker.Value = new DateTime(1988,3,25);
            this.mobilePhoneTextBox.Text = "0987521465";
            this.telPhoneTextBox.Text = "0227874423";
            this.addressTextBox.Text = "台北市大安區信義路四段30巷8弄13之1號";
            this.deliveryAddressTextBox.Text = "台北市大安區信義路四段30巷8弄13之1號";
            this.emailTextBox.Text = "eyecontact@hotmail.com";
            this.commentTextBox.Text = "大戶 幫他開帳號";
        }   
    }
}
