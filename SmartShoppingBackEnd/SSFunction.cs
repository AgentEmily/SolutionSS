using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShoppingBackEnd
{
    class SSFunction
    {
        //檢查商品ID是否存在..(並回傳商品名稱)
        public bool CheckProductIDandGetProductName(string productID, bool CheckDiscontinue = false)
        {
            
            bool FCheck=false;
            bool Discontinued=false;
            using (var SSEntities=new SmartShoppingEntities2())
            {
                var q = (from p in SSEntities.Products
                        where p.Product_ID商品編號.ToString() == productID
                        select new { p.Product_ID商品編號, p.Discontinued }).FirstOrDefault();
                if (q!=null)
                {
                    FCheck = true;
                    Discontinued = q.Discontinued;
                }
            }
            if (!FCheck)
            {
                if (productID==null)
                {
                    MessageBox.Show("請輸入要查詢的商品", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("找不到商品", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (CheckDiscontinue&&Discontinued)
                {
                    MessageBox.Show("此為停售商品", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return FCheck; 
        }

        //檢查廠商ID是否存在
        public bool CheckVendorID(string vendorID)
        {

            bool FCheck = false;
            
            using (var SSEntities = new SmartShoppingEntities2())
            {
                var q = (from v in SSEntities.Vendors
                         where v.Vendor_ID.ToString() == vendorID
                         select new { v.Vendor_ID}).FirstOrDefault();
                if (q != null)
                {
                    FCheck = true;
                    
                }
            }
            if (!FCheck)
            {
                if (vendorID == null)
                {
                    MessageBox.Show("請輸入要查詢的廠商", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("找不到廠商", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            return FCheck;
        }

        //檢查會員是否存在
        public bool CheckMemberID(string memberID)
        {

            bool FCheck = false;
            
            using (var SSEntities = new SmartShoppingEntities2())
            {
                var q = (from m in SSEntities.Member
                         where m.Member_ID會員編號.ToString() == memberID
                         select new { m.Member_ID會員編號 }).FirstOrDefault();
                if (q != null)
                {
                    FCheck = true;
                   
                }
            }
            if (!FCheck)
            {
                if (memberID == null)
                {
                    MessageBox.Show("請輸入要查詢的會員", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("找不到此會員", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
            return FCheck;
        }

        //用PID get Pname
        public string GetProductName(string productID)
        {

            string productName = "";
            using (var SSEntities = new SmartShoppingEntities2())
            {
                var q = (from p in SSEntities.Products
                         where p.Product_ID商品編號.ToString() == productID
                         select new { p.ProductName商品名稱}).FirstOrDefault();
                if (q != null)
                {
                    productName = q.ToString();
                }
            }
            
            return productName;
        }

        //檢查使用者權限
        //public bool CheckUserAuthority(string prgramID, int Operation)
    }
}
