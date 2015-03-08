using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SmartShoppingBackEnd.Properties;

namespace SmartShoppingBackEnd
{
    public partial class frmRelateProducts : Form
    {
        public frmRelateProducts()
        {
            InitializeComponent();
           
        }

        private void frmRelateProducts_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.ReportTable' 資料表。您可以視需要進行移動或移除。
            this.ReportTableTableAdapter.Fill(this.smartShoppingDataSet.ReportTable);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet1.DataTable1' 資料表。您可以視需要進行移動或移除。
            this.dataTable1TableAdapter.Fill(this.smartShoppingDataSet1.DataTable1);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.View_ProductxMember' 資料表。您可以視需要進行移動或移除。


            this.reportViewer1.RefreshReport();
            
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void SaveToDB()
        {
            SmartShoppingEntities SSE = new SmartShoppingEntities();
            //清空
            SSE.Database.ExecuteSqlCommand("TRUNCATE TABLE [RecommendationChart]");

            var q = from p in SSE.Products
                    select p.Product_ID;//目前所有的order
            var list = q.ToList();
            for (int i = 0; i < list.Count; i++)//每一個PID
            {
                int PID = list[i];
                string p = "P" + PID.ToString();
                List<MyRelateProduct> Products = GetRelateProductTop5(p);//PID一個一個進查詢
                for (int k = 0; k < Products.Count; k++)
                {
                    using (SqlConnection conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
                {

                    string commStr = "insert into RecommendationChart (PID, NO, Score, NOName) values (@PID, @NO, @Score, @NOName)";

                    using (SqlCommand cmd = new SqlCommand(commStr, conn))
                    {



                        conn.Open();
                        cmd.Parameters.AddWithValue("@PID", PID);

                        cmd.Parameters.AddWithValue("@NO", Products[k].PID);
                        cmd.Parameters.AddWithValue("@Score", Products[k].Score);
                        cmd.Parameters.AddWithValue("@NOName", Products[k].ProductName);
                        
                        
                      
                        cmd.ExecuteNonQuery();

                        conn.Close();


                    }
                }
                }
                
            }
            //存好了顯示出來

        }

        //private List<MyRelateProduct> GetRelateProductTop5v2(string p)
        //{
            
        //}



        //private void button1_Click(object sender, EventArgs e)
        //{
        //    List<int> members = new List<int>();
        //    using (SqlConnection conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
        //    {
        //        using (SqlCommand cmd = new SqlCommand("getrelateproduct", conn))
        //        {
                    
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            cmd.Parameters.AddWithValue("@pid", 1);//write for loop till no products
        //            conn.Open();
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            while (dr.Read())
        //            {
        //                members.Add((int)dr[0]);
        //            }
        //            conn.Close();

        //        }
        //        string memberstr="";
        //        for (int i = 0; i < members.Count; i++)
        //    {
        //        if (i < members.Count - 1)
        //        {
        //            memberstr += members[i].ToString() + ",";
        //        }
        //        else
        //        {
        //            memberstr += members[i].ToString();
        //        }
			
        //    }
                
        //        using (SqlCommand cmd = new SqlCommand("getbestrelate", conn))
        //        {
        //            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        //            //write for loop till no members. put all products in a list and count 
        //            cmd.Parameters.AddWithValue("@mid", "");//cant use string, must use int one by one
        //            conn.Open();
        //            SqlDataReader dr = cmd.ExecuteReader();
        //            while (dr.Read())
        //            {
        //                listBox1.Items.Add(dr["Product_ID"].ToString());
        //            }
        //            conn.Close();
        //        }
        //    }
        //}

        ////int First = 0;
        ////int Second = 0;
        ////int Third = 0;
        ////int Fourth = 0;
        ////below way give you a count of each item in the List...still too stupid!
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    List<int> countProduct = new List<int>();
        //    countProduct.Add(1);
        //    countProduct.Add(2);
        //    countProduct.Add(2);
        //    countProduct.Add(2);
        //    for (int i = 0; i < countProduct.Count(); i++)
        //    {
        //        this.listBox1.Items.Add(countProduct[i] + "(" + countProduct.Count(j => j.Equals(countProduct[i])) + ")");
        //    }
                
            
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;

            button4_Click(sender, e);

            SmartShoppingEntities SSE = new SmartShoppingEntities();
            var q = from o in SSE.Orders
                    select o.Order_ID;//目前所有的order
            var list = q.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                List<int> Products = GetProductID(list[i]);//由orderID 拿到該單的產品ID List
            AddToRelationTable(Products);
            }//加進table裡面
            
            //顯現出來
            
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.ReportTable' 資料表。您可以視需要進行移動或移除。
            this.ReportTableTableAdapter.FillByPID(this.smartShoppingDataSet.ReportTable, 1);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet1.DataTable1' 資料表。您可以視需要進行移動或移除。
            this.dataTable1TableAdapter.Fill(this.smartShoppingDataSet1.DataTable1);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.View_ProductxMember' 資料表。您可以視需要進行移動或移除。


            this.reportViewer1.RefreshReport();

            this.reportViewer2.RefreshReport();

            
        }

        List<int> OriginalProducts=new List<int>();
        private void AddToRelationTable(List<int> Products)
        {

            if (Products.Count==1)
            {
                return;//只買一個的單沒有關聯性
            }
            double n = Products.Count;//這筆單的數量, 正規化要除以n-1
          // List<int> OriginalProducts = Products;
            for (int i = 0; i < n; i++)//要update幾筆資料
            {
                
                Products.Sort();
                string Target = Products[i].ToString();//基準商品
                Products.RemoveAt(i);
                OriginalProducts.Add((int.Parse(Target)));
                string SetStr = string.Format("{0:#,0.##}", 1 / (n - 1));
                for (int j = 0; j < n-1; j++)//剩下的要+1/n-1
                {
                    //if (j < n - 2)
                    //{
                    //    SetStr += string.Format("[{0}]+={1:#,0.##}", Products[j].ToString(), 1 / (n - 1)) + ",";
                    //}
                    //else
                    //{
                    //    SetStr += string.Format("[{0}]+={1:#,0.##}", Products[j].ToString(), 1 / (n - 1));
                    //}

                    using (SqlConnection conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
                    {
                        //string commStr = "update [dbo].[Recommendation] set"+ SetStr+ "where PID="+Target;
                        string commStr = "update [dbo].[Recommendation] set P" + Target +"+="+SetStr+ "where PID=" + Products[j].ToString();

                        using (SqlCommand cmd = new SqlCommand(commStr, conn))
                        {



                            conn.Open();
                            cmd.ExecuteNonQuery();

                            conn.Close();


                        }
                    }
                    
                }

                

                Products.Add(OriginalProducts[0]);
                OriginalProducts.Clear();
            }

            
        }

        private List<int> GetProductID(int OrderID)//由orderID 拿到該單的產品ID List
        {
            List<int> Products = new List<int>();
            using (SqlConnection conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string commStr = "select Product_ID from OrderDetail where Order_ID=@orderID";

                using (SqlCommand cmd = new SqlCommand(commStr, conn))
                {


                    cmd.Parameters.AddWithValue("@orderID", OrderID);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Products.Add((int)dr[0]);
                    }
                    conn.Close();

                    return Products;

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //清空資料表 把顯示狀態改一下
            this.tabControl1.SelectedIndex = 0;
            
            using (SqlConnection conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string commStr = "Delete from Recommendation";

                using (SqlCommand cmd = new SqlCommand(commStr, conn))
                {
 
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }

                //把產品有幾個長出來
                SmartShoppingEntities SSE=new SmartShoppingEntities();
                var q = from p in SSE.Products
                        select p.Product_ID;
                var list = q.ToList();
                string allother = "";
                string zeros = "";
                for (int i = 1; i <= list.Count; i++)
                {
                    if (i < list.Count)
                    {
                        allother += string.Format("P{0}", i)+",";
                        zeros += "0,";
                    }
                    else
                    {
                        allother += string.Format("P{0}", i);
                        zeros += "0";
                    }
                    
                }
                for (int i = 0; i < list.Count; i++)
                {
                    
                    string commStr2 = "insert into Recommendation (PID, "+allother+") values ("+list[i]+","+zeros+")";
                    //all "0" 還沒寫

                using (SqlCommand cmd = new SqlCommand(commStr2, conn))
                {
 
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                }

                }


            }
            
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.ReportTable' 資料表。您可以視需要進行移動或移除。
            this.ReportTableTableAdapter.Fill(this.smartShoppingDataSet.ReportTable);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet1.DataTable1' 資料表。您可以視需要進行移動或移除。
            this.dataTable1TableAdapter.Fill(this.smartShoppingDataSet1.DataTable1);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.View_ProductxMember' 資料表。您可以視需要進行移動或移除。


            this.reportViewer1.RefreshReport();

            this.reportViewer2.RefreshReport();


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
            this.labelMessage.Hide();
            this.reportViewer2.Visible = true;
            //get a list and bind with the gridview
            //input a P
            EveryBodyUse EBU = new EveryBodyUse();
            string ProductName=EBU.CheckProductIDandGetProductName(this.textBox1.Text);
            this.label1.Text = "查詢產品: "+ProductName;
            if (ProductName!="無此商品")
            {
                string p = "P" + this.textBox1.Text;

                var prod = GetRelateProductTop5(p);
          
                //this.dataGridView1.DataSource = prod;

                this.ReportTableTableAdapter.FillByPID(this.smartShoppingDataSet.ReportTable, int.Parse(this.textBox1.Text));
                this.reportViewer2.RefreshReport();
            }

            
            

        }

        private List<MyRelateProduct> GetRelateProductTop5(string P)
        {
            //判斷有沒有這個欄位
            List<MyRelateProduct> RelateProducts = new List<MyRelateProduct>();
            using (SqlConnection conn = new SqlConnection(Settings.Default.SmartShoppingConnectionString))
            {
                string commStr = "select Top 5 PID," + @P + ", ProductName from Recommendation join Products on Recommendation.PID = Products.Product_ID order by " + @P + " desc";

                using (SqlCommand cmd = new SqlCommand(commStr, conn))
                {

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr[1].ToString()!="0.00")
                        {
                            MyRelateProduct mrp = new MyRelateProduct();
                        mrp.PID = dr[0].ToString();
                        mrp.Score = dr[1].ToString();
                        mrp.ProductName = dr[2].ToString();
                      
                        RelateProducts.Add(mrp);
                        }
                        
                    }
                    conn.Close();

                    return RelateProducts;//寫成for loop存到資料庫

                }
            }

        }

         class MyRelateProduct
        {
            public string PID{get;set;}
            public string Score { get; set; }
            public string ProductName { get; set; }

        }

         private void button2_Click(object sender, EventArgs e)
         {
             //重新根據現在訂單寫入推薦分析結果recommendationchart表
             SaveToDB();
             this.ReportTableTableAdapter.Fill(this.smartShoppingDataSet.ReportTable);
             this.reportViewer3.RefreshReport();
             this.tabControl1.SelectedIndex = 2;
         }

         private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (this.tabControl1.SelectedIndex==1)
             {
                 this.textBox1.Focus();
             }
         }
    }
}
