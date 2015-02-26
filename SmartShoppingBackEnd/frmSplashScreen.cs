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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void fmSplashScreen_Load(object sender, EventArgs e)
        {
            LbApplicationTitle.Text = "";
            LbCompany.Text = "";
            object[] attributes;
            //應用程式標題             
            attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(
                                 typeof(AssemblyProductAttribute), false);
            if (attributes.Length != 0)
            {
                LbApplicationTitle.Text = ((AssemblyProductAttribute)attributes[0]).Product;
            }
            //版本
            LbVersion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            //公司
            attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(
                                  typeof(AssemblyCompanyAttribute), false);
            if (attributes.Length != 0)
            {
                LbCompany.Text = ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
    }
}
