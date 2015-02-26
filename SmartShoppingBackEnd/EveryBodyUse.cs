using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartShoppingBackEnd
{
    class EveryBodyUse
    {
        public string CheckProductIDandGetProductName(string productID, bool CheckDiscontinue = false)
        {

            bool FCheck = false;
            bool Discontinued = false;
            string ProductName="";
            using (var SSEntities = new SmartShoppingEntities())
            {
                var q = (from p in SSEntities.Products
                         where p.Product_ID.ToString() == productID
                         select new { p.Product_ID, p.Discontinued,p.ProductName }).FirstOrDefault();
                if (q != null)
                {
                    FCheck = true;
                    Discontinued = q.Discontinued;
                    ProductName=q.ProductName;
                }
            }
            if (!FCheck)
            {
                if (productID == null)
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
                if (CheckDiscontinue && Discontinued)
                {
                    MessageBox.Show("此為停售商品", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (FCheck)
            {
                return ProductName;
            }
            else
            {
                return "無此商品";
            }
        }
    }

    public class ExTag
    {
        public Dictionary<string, object> TagDictionary { get; set; }

        public ExTag()//Cunstractor
        {
            this.TagDictionary = new Dictionary<string, object>();
        }

        public void Add(string key, object value)
        {
            this.TagDictionary.Add(key, value);
        }

        public object Get(string key)
        {
            return this.TagDictionary[key];
        }
    }
}
