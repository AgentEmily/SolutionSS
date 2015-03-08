using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShoppingBackEnd
{
    public partial class frmRoleAnalysis : Form
    {
        public frmRoleAnalysis()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FromOrderToSmart();
            this.RoleXProductTableAdapter.Fill(this.reportDS.RoleXProduct);

            this.reportViewer1.RefreshReport();
        }

        private void FromOrderToSmart()
        {
            using (SmartShoppingEntities db=new SmartShoppingEntities())
            {
                db.Database.ExecuteSqlCommand("TRUNCATE TABLE [RoleSmart]");

                var q = from r in db.View_RoleXProduct
                        select r;//只從新增的開始讀?上次讀到幾要存起來
                foreach (var item in q.ToList())
                {
                    //檢查RoleSmart資料表是否有此Role X Product的紀錄
                            var qry = (from P in db.RoleSmart
                                       where P.RoleID==item.Roles_ID&&P.ProductID==item.Product_ID
                                       select P).FirstOrDefault();
                            if (qry==null)
                            {
                                //新增程式代碼記錄
                                var NewRS = new RoleSmart();
                                NewRS.RoleID = item.Roles_ID;
                                NewRS.ProductID = item.Product_ID;
                                NewRS.TimesPurchased = 1;
                                NewRS.OrderBilling = item.Amount;
                               

                                //加入程式代碼
                                db.Entry(NewRS).State = EntityState.Added;
                                db.SaveChanges();

                            }
                            else
                            {
                                RoleSmart rs = db.RoleSmart.Find(item.Roles_ID, item.Product_ID);
                                rs.TimesPurchased += 1;
                                rs.OrderBilling += item.Amount;
                                db.Entry(rs).State = EntityState.Modified;
                                db.SaveChanges();

                            }
                }
            }
        }

        private void frmRoleAnalysis_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'reportDS.RoleXProduct' 資料表。您可以視需要進行移動或移除。
            this.RoleXProductTableAdapter.Fill(this.reportDS.RoleXProduct);

            this.reportViewer1.RefreshReport();
        }
    }
}
