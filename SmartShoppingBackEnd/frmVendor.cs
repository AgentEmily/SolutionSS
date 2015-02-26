using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SmartShoppingBackEnd
{
    public partial class frmVendor : SmartShoppingBackEnd.frmBase
    {
        public frmVendor()
        {
            InitializeComponent();
        }

        private void frmVendor_Load(object sender, EventArgs e)
        {
            BS = vendorsBindingSource;
            IDFieldName = "Vendor_ID";
            TableName = "Vendors";
            using (SmartShoppingEntities2 SSEntities = new SmartShoppingEntities2())
            {
                var q = (from v in SSEntities.Vendors
                        orderby v.Vendor_ID descending
                        select v.Vendor_ID).FirstOrDefault();
                //this.dataGridView1.DataSource = q.ToList();//no mapping for the 3 new ones

                    if (q!=null)
                    {
                        PrimaryID = q.ToString();
                    }
                    else
                    {
                        PrimaryID = "";
                    }

                }
                FillData();
                AllowDelete = true;
            
        }

        public override void FillData()
        {
            using(SmartShoppingEntities2 SSEntities = new SmartShoppingEntities2())
	{
        var q = from v in SSEntities.Vendors
                where v.Vendor_ID.ToString() == PrimaryID
                select v;
        //vendorsBindingSource.DataSource = q;
        this.dataGridView1.DataSource = q.ToList();
	}
            

        }
    }
}
