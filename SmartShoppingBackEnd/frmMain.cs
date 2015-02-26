using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShoppingBackEnd
{
    public partial class frmMain : Form
    {      
        public static frmMain FormMain;
        public static frmStartup FormStart;

        public frmMain()
        {
            InitializeComponent();
            FormMain = this;
            this.IsMdiContainer = true;
            this.menuStrip1.MdiWindowListItem = this.miWindows;
        }

        //登入是否成功(身分驗證)
        public static bool FAllowCheck = false;
        
        //登入的ID與Name
        public static string FUserName;
        public static string FUserID;

        //設定主視窗的Load和Closing事件
        private void frmMain_FormLoad(object sender, EventArgs e)
        {
            //顯示系統啟動畫面(版權宣告畫面)
            frmSplashScreen splash = new frmSplashScreen();
            splash.Show();
            splash.Update();

            //同步全部程式
            SyncProgram();
            //同步全部使用者權限
            SyncBaceSSAuthority();
            SyncADMINSSAuthority();

            //關閉系統啟動畫面(版權宣告畫面)
            splash.Close();

            //開啟身分認證表單
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            
            if (!FAllowCheck)
            {          
                //未通過認證，結束系統
                this.Close();
            }
            else
            {
                //在狀態列顯示登入的使用者代碼與使用者名稱
                UserLabel.Text = "使用者:(" + FUserID + ")" +FUserName ;

                //設定登入者的權限
                SyncProgramsRight();

                //顯示開始畫面
                frmStartup start = new frmStartup();
                start.MdiParent = this;
                start.Show();

                FormStart = start;
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //關閉前，檢查是否有進行中的作業
            Form tempChild = this.ActiveMdiChild;
            e.Cancel = false;
            if (tempChild != null && tempChild.GetType() != FormStart.GetType())
            {
                if (MessageBox.Show("尚有作業進行中，是否仍要結束?", "結束系統", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                { e.Cancel = true; }
            }
            else 
            {
                //先關閉全部的子視窗 
                foreach (var childform in MdiChildren)
                {
                    childform.Close();
                    childform.Dispose();
                }
            }
        }

        #region 主視窗Load事件的方法
        //同步全部程式
        private void SyncProgram()
        {
            using (var SSEntities = new SmartShoppingEntities())
            {
                try
                {    
                    string ProgramName = "";

                    //取得目前的組件
                    Assembly thisAssembly = Assembly.GetExecutingAssembly();
                    //取得組件內所有類別型態
                    foreach (var t in thisAssembly.GetTypes())
                    {
                        //如果父類別是繼承自Form的話
                        if (t.IsSubclassOf(typeof(Form)))
                        {
                            //列出該類別資訊
                            ProgramName = t.Name.ToString();

                            //檢查程式代碼資料表是否有此程式代碼的記錄
                            var qry = (from P in SSEntities.SSPrograms
                                       where P.ProgramName == ProgramName
                                       select P).FirstOrDefault();

                            int MaxID = SSEntities.SSPrograms.Max(i => i.Program_ID);
                            if (qry == null)
                            {
                                //新增程式代碼記錄
                                var NewProgram = new SSPrograms();
                                NewProgram.Program_ID =MaxID+1;
                                NewProgram.ProgramName = ProgramName;

                                //加入程式代碼
                                SSEntities.SSPrograms.Add(NewProgram);
                                //更新資料
                                SSEntities.SaveChanges();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "啟動錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //同步全部使用者權限(系統管理者擁有全部程式的權限，其他使用者至少要有更改自己密碼的權限)
        private void SyncBaceSSAuthority()
        {
            using (var SSEntities = new SmartShoppingEntities())
            {
                try
                {
                    //其他使用者至少要有更改自己密碼的權限
                    string EmployeeID;

                    //找出全部的使用者
                    var qrysUsers = from E in SSEntities.SSUsers select E.Employee_ID;

                    foreach (var U in qrysUsers)
                    {
                        EmployeeID = (string)U;
                        var qry = (from A in SSEntities.SSAuthority
                                   where A.Employee_ID == EmployeeID
                                   select A).FirstOrDefault();
                        if (qry == null)
                        {
                            var ProgramUserPassword = (SSEntities.SSPrograms.Where(i => i.ProgramName == "frmUserPassword")).FirstOrDefault();

                            //新增使用權限記錄
                            SSAuthority NewAuthority = new SSAuthority();
                            NewAuthority.Employee_ID = EmployeeID;
                            NewAuthority.Program_ID = ProgramUserPassword.Program_ID;
                            NewAuthority.Run = true;
                            NewAuthority.Edit = true;
                            SSEntities.SSAuthority.Add(NewAuthority);
                        }
                    }
                    //更新資料
                    SSEntities.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "啟動錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void SyncADMINSSAuthority()
        {
            using (var SSEntities = new SmartShoppingEntities())
            {
                try
                {
                    //確定系統管理者擁有全部程式的權限
                    string ADMIN = "ADMIN";

                    //系統管理者ADMIN是否存在
                    var ADMINqry = (from E in SSEntities.SSUsers
                                    where E.Employee_ID == ADMIN
                                    select E).FirstOrDefault();

                    if (ADMINqry == null)
                    {
                        //新增系統管理者ADMIN
                        SSUsers NewSSUsers = new SSUsers();
                        NewSSUsers.Employee_ID = ADMIN;
                        NewSSUsers.EmployeeName = "系統管理員";
                        NewSSUsers.Password = ADMIN;
                        SSEntities.SSUsers.Add(NewSSUsers);
                        //更新資料
                        SSEntities.SaveChanges();
                    }

                    //找出全部的程式
                    var qryPrograms = from P in SSEntities.SSPrograms
                                      select P.Program_ID;

                    foreach (var P in qryPrograms)
                    {
                        //系統管理者的使用權限是否存在
                        var qry = (from A in SSEntities.SSAuthority
                                   where A.Employee_ID == ADMIN && A.Program_ID == P
                                   select A).FirstOrDefault();
                        if (qry == null)
                        {
                            //新增系統管理者的使用權限
                            SSAuthority NewAuthority = new SSAuthority();
                            NewAuthority.Employee_ID = ADMIN;
                            NewAuthority.Program_ID = P;
                            NewAuthority.Run = true;
                            NewAuthority.Edit = true;
                            SSEntities.SSAuthority.Add(NewAuthority);
                        }
                    }
                    //更新資料
                    SSEntities.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "啟動錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //設定全部程式是否可以執行
        private void SyncProgramsRight()
        {
            using (var SSEntities = new SmartShoppingEntities())
            {
                try
                {
                    int sProgramID;
                    //從MenuStrip1控制項集合找出每一個控制項
                    foreach (var tsmi in menuStrip1.Items)
                    {
                        if (!(tsmi is ToolStripItem))
                        {
                            continue;
                        }
                        //找出MenuStrip1.Items的子控制項
                        foreach (var SubItem in
                            ((ToolStripMenuItem)(tsmi)).DropDownItems)
                        {
                            //判斷找出的控制項是否為ToolStripMenuItem類別
                            if (SubItem is ToolStripMenuItem)
                            {
                                sProgramID = (int)((ToolStripMenuItem)SubItem).Tag;
                                //取得是否有執行程式的權限
                                ((ToolStripMenuItem)SubItem).Enabled = CheckProgramRight(sProgramID);
                            }
                            else
                            { continue;}
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "啟動錯誤", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        //檢查指定程式是否有執行權限
        private bool CheckProgramRight(int ProgramID)
        {
            var blnRun = false;
            //檢查指定的程式是否有執行權限
            using (var SSEntities = new SmartShoppingEntities())
            {
                var qryAuth = (from M in SSEntities.SSAuthority
                               where M.Employee_ID == FUserID&& M.Program_ID == ProgramID
                               select M).FirstOrDefault();
                if (qryAuth != null)
                {
                    blnRun = Convert.ToBoolean(qryAuth.Run);
                }
            }
            return blnRun;
        }
        #endregion
        #region 其他共用的方法

        //開啟視窗前的確認
        private bool CheckWindowOpened(string ChildWindowName)
        {
            bool Opened = true;

            //檢查已開啟的子視窗
            for (int iChildren = 0; iChildren < MdiChildren.Length; iChildren++)
            {
                //判斷正要開啟的視窗是否已開啟
                if (MdiChildren[iChildren].Name == ChildWindowName)
                {
                    //將已開啟的視窗帶到最上層
                    MdiChildren[iChildren].BringToFront();
                    Opened = false;
                }
            }
            return Opened;
        }
        #endregion

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

        private void 進貨單ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseOrders why = new frmPurchaseOrders();
            why.MdiParent = this;
            why.Show();
        }

        private void miCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void 進貨作業ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPurchaseOrders why = new frmPurchaseOrders();
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

        private void 使用者維護ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserPassword userPassword = new frmUserPassword();
            userPassword.MdiParent = this;
            userPassword.labelUserName.Text = FUserName + " 您好";
            userPassword.Show();
        }
    }
}
