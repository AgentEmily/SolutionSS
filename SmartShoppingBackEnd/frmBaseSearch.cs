using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;

namespace SmartShoppingBackEnd
{
    public partial class frmBaseSearch : Form
    {
        public frmBaseSearch()
        {
            InitializeComponent();
        }

        //允許關閉對話方塊
        bool FCanClose = true;
        //取得或設定是否允許關閉對話方塊
        public bool CanClose
        {
            get
            {
                return FCanClose;
            }
            set
            {
                FCanClose = value;
            }
        }

        private void frmBaseSearch_Load(object sender, EventArgs e)
        {
            //frmBaseSearch初始位置
            this.Left = 10;
            this.Top = 10;

            //移動frmBaseSearch至指定位置
            this.timer1.Enabled = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public virtual void frmBaseSearch_Closing(object sender, FormClosingEventArgs e)
        {
            if(CanClose==false)
            { MessageBox.Show("作業進行中，禁止關閉視窗"); }
            e.Cancel = (!FCanClose);
        }

        //時間效果的位移量
        int left = 5, top = 5;

        //取得螢幕長寬
        int W = SystemInformation.PrimaryMonitorSize.Width / 3;
        int H = SystemInformation.PrimaryMonitorSize.Height / 5;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((this.Left <= W)&&(this.Top<=H))
            {
                //讓frmBaseSearch移動.
                this.Left += left;
                this.Top += top;
            }
            else
            {
                //停止frmBaseSearch的移動
                this.timer1.Enabled = false;
            }
        }
    }
}
