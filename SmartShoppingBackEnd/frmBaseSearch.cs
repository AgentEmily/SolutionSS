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

        public virtual void fmBaseDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
