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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.menuStrip1.MdiWindowListItem = this.miWindows;
        }
        public static bool FAllowCheck = false;
        public static string FUserName;
        public static int FUserID;
        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            if (!FAllowCheck)
            {
                this.Close();
            }
            //StatusLabel1.Text = "User: " + FUserName;//show login name at the status bar
        }

        private bool CheckWindowOpened(string ChildWindowName)
        {
            bool Opened = true;
            for (int iChildren = 0; iChildren < MdiChildren.Length; iChildren++)
            {
                MdiChildren[iChildren].BringToFront();
                Opened = false;
            }
            return Opened;
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form tempChild = this.ActiveMdiChild;
            e.Cancel = false;
            if (tempChild != null)
            {
                if (MessageBox.Show("尚有作業進行中，是否仍要結束?", "結束系統", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void view_Click(object sender, EventArgs e)
        {

        }

        private void 角色管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRoles frmRoles = new frmRoles();
            frmRoles.MdiParent = this;
            frmRoles.Show();
        }

        private void 廣告管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPictureLoad frmPL = new frmPictureLoad();
            frmPL.MdiParent = this;
            frmPL.Show();
        }

        private void 出貨通知ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutoMail frmAM = new frmAutoMail();
            frmAM.MdiParent = this;
            frmAM.Show();
        }
        FrmStartup start = new FrmStartup();//後續處理
        private void frmMain_Load(object sender, EventArgs e)
        {
            //fmSplashScreen splash = new fmSplashScreen();
            //splash.Show();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            //splash.Close();
            if (!FAllowCheck)
            {
                this.Close();
            }
            else
            {
            start.MdiParent = this;
            start.Show();

            }

        }

        private void 進貨單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start.Close();
            frmwhy why = new frmwhy();
            why.MdiParent = this;
            why.Show();
        }

        private void miCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 進貨作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmwhy why = new frmwhy();
            why.MdiParent = this;
            why.Show();
        }

        private void 關聯產品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelateProducts frp = new frmRelateProducts();
            frp.MdiParent = this;
            frp.Show();
        }

        private void 商品維護ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsCRUD products = new frmProductsCRUD();
            products.MdiParent = this;
            products.Show();
        }

        private void 廠商維護ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendorsCRUD vendor = new frmVendorsCRUD();
            vendor.MdiParent = this;
            vendor.Show();
        }

        private void 會員維護ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembersCRUD member = new frmMembersCRUD();
            member.MdiParent = this;
            member.Show();
        }

        private void 類別管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoriesCRUD category = new frmCategoriesCRUD();
            category.MdiParent = this;
            category.Show();
        }

        private void 出貨作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders orders = new frmOrders();
            orders.MdiParent = this;
            orders.Show();
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            //要不要儲存
            this.Close();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {

        }

        private void 縮小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var childform in MdiChildren)
            {
                childform.WindowState = FormWindowState.Minimized;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //關視窗不會有問題
            foreach (var childform in MdiChildren)
            {
                childform.Close();
                childform.Dispose();

            }
        }
    }
}
