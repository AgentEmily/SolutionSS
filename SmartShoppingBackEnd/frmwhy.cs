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
    public partial class frmwhy : Form
    {
        public frmwhy()
        {
            InitializeComponent();
        }

        private void purchaseOrdersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.purchaseOrdersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.smartShoppingDataSet);

        }

        private void frmwhy_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.smartShoppingDataSet.Products);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.PurchaseOrderDetail' 資料表。您可以視需要進行移動或移除。
            this.purchaseOrderDetailTableAdapter.Fill(this.smartShoppingDataSet.PurchaseOrderDetail);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Status' 資料表。您可以視需要進行移動或移除。
            this.statusTableAdapter.Fill(this.smartShoppingDataSet.Status);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.PaymentMethod' 資料表。您可以視需要進行移動或移除。
            this.paymentMethodTableAdapter.Fill(this.smartShoppingDataSet.PaymentMethod);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Vendors' 資料表。您可以視需要進行移動或移除。
            this.vendorsTableAdapter.Fill(this.smartShoppingDataSet.Vendors);
            // TODO: This line of code loads data into the 'smartShoppingDataSet.PurchaseOrders' table. You can move, or remove it, as needed.
            this.purchaseOrdersTableAdapter.Fill(this.smartShoppingDataSet.PurchaseOrders);
            this.PurchaseBindingNavigator.BindingSource = purchaseOrdersBindingSource;
            this.purchaseOrdersBindingSource.DataError += purchaseOrdersBindingSource_DataError;
            this.purchaseOrderDetailBindingSource.DataError += purchaseOrderDetailBindingSource_DataError;
            this.purchaseOrdersDataGridView.DataError += purchaseOrdersDataGridView_DataError;
            this.purchaseOrderDetailDataGridView.DataError += purchaseOrderDetailDataGridView_DataError;
            ButtonSetting();
        }

        void purchaseOrderDetailDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("請完整填寫訂購商品資料");
        }

        void purchaseOrdersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("請完整填寫訂單資料");
        }

        void purchaseOrderDetailBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show("請完整填寫資料");
        }

        void purchaseOrdersBindingSource_DataError(object sender, BindingManagerDataErrorEventArgs e)
        {
            MessageBox.Show("請完整填寫資料");
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void purchaseOrderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            purchaseOrderDetailDataGridView.Columns["Delete"].Visible = false;
            
            if (CheckAllValue())
            {
                this.Validate();
            this.purchaseOrdersBindingSource.EndEdit();
            this.purchaseOrdersTableAdapter.Update(this.smartShoppingDataSet.PurchaseOrders);

            this.purchaseOrderDetailBindingSource.EndEdit();
            this.purchaseOrderDetailTableAdapter.Update(this.smartShoppingDataSet.PurchaseOrderDetail);
            }
            else
            {
                //MessageBox.Show("請將資料正確填寫");
            }

            status = "browse";
            ButtonSetting();
            
        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            this.orderDateDateTimePicker.Value = DateTime.Today;
            status = "addnew";
            ButtonSetting();
            
        }

        private bool CheckAllValue()
        {
            bool passed = false;
            if (this.orderDateDateTimePicker.Value==null)
            {
                this.orderDateDateTimePicker.Value = DateTime.Today;
            }
            if (this.comboBox3.Text == "")
            {
                this.comboBox3.Text = "1";
            }

            if (this.comboBox1.Text == "")
            {
                MessageBox.Show("請選擇供應商");
                this.comboBox1.Focus();

                return passed;
            }

            else if (this.subTotalTextBox.Text == "")
            {
                MessageBox.Show("請輸入進貨金額");
                this.subTotalTextBox.Focus();
                return passed;
            }
            else if (this.comboBox2.Text == "")
            {
                MessageBox.Show("請選擇付款方式");
                this.comboBox2.Focus();
                return passed;
            }

            else
            {
                passed = true;
                return passed;
            }
        }

        private void orderDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void subTotalTextBox_Leave(object sender, EventArgs e)
        {
            int subtotal = 0;
            if (int.TryParse(this.subTotalTextBox.Text, out subtotal))
            {
                this.valueAddTaxTextBox.Text = (Math.Round(subtotal * 0.05)).ToString();
                this.label8.Text = (double.Parse(this.valueAddTaxTextBox.Text) + subtotal).ToString();
                
            }
            else
            {
                MessageBox.Show("金額必須為整數");
            }
        }
 int subtotal;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            subtotal = 0;
            for (int i = 0; i < this.purchaseOrderDetailDataGridView.Rows.Count-1; i++)
			{
               
                subtotal += (int)this.purchaseOrderDetailDataGridView.Rows[i].Cells[3].Value;
                
                
			}

            this.subTotalTextBox.Text = subtotal.ToString();
            
        }

        private void subTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            if (status!="browse")
            {
                int subtotal = 0;
            if (int.TryParse(this.subTotalTextBox.Text, out subtotal))
            {
                this.valueAddTaxTextBox.Text = (Math.Round(subtotal * 0.05)).ToString();
                this.label8.Text = (double.Parse(this.valueAddTaxTextBox.Text) + subtotal).ToString();

            }
            else
            {
                MessageBox.Show("金額必須為整數");
            }
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            purchaseOrderDetailDataGridView.Columns["Delete"].Visible = true;
            status = "modify";
            ButtonSetting();
        }

        private void purchaseOrderDetailDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this.purchaseOrderDetailBindingSource.RemoveAt(this.purchaseOrderDetailBindingSource.Position);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            purchaseOrderDetailDataGridView.Columns["Delete"].Visible = false;
            
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.PurchaseOrderDetail進貨明細' 資料表。您可以視需要進行移動或移除。
            this.purchaseOrderDetailTableAdapter.Fill(this.smartShoppingDataSet.PurchaseOrderDetail);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.PurchaseOrder進貨單' 資料表。您可以視需要進行移動或移除。
            this.purchaseOrdersTableAdapter.Fill(this.smartShoppingDataSet.PurchaseOrders);

            status = "browse";
            ButtonSetting();
        }

        string status = "browse";
        private void ButtonSetting()
        {
            //browse add modify 
            if (status=="browse")
            {
                this.linkLabel2.Visible = false;
                this.linkLabel1.Visible = false;

                foreach (Control crt in splitContainer2.Panel1.Controls)
            {
                if (crt is TextBox)
                {
                    ((TextBox)crt).ReadOnly = true;
                }
            }
            this.comboBox1.Enabled = false;
            this.comboBox2.Enabled = false;
            this.comboBox3.Enabled = false;

           this.orderDateDateTimePicker.Enabled = false;

            this.purchaseOrderDetailDataGridView.ReadOnly = true;
            this.purchaseOrdersDataGridView.ReadOnly = true;

            bindingNavigatorAddNewItem.Enabled = true; // 新增
            toolStripButton1.Enabled = true;           // 修改
            bindingNavigatorDeleteItem.Enabled = true; // 刪除
            toolStripButton3.Enabled = true;           // 查詢
            purchaseOrderBindingNavigatorSaveItem.Enabled = false; // 儲存
            toolStripButton2.Enabled = false;          // 取消
            }
            else if (status=="addnew"||status=="modify")
            {
                if (status=="addnew")
                {
                    this.linkLabel2.Visible = true;
                }
                foreach (Control crt in splitContainer2.Panel1.Controls)
            {
                if (crt is TextBox)
                {
                    ((TextBox)crt).ReadOnly = false;
                }
            }
            this.comboBox1.Enabled = true;
            this.comboBox2.Enabled = true;
            this.comboBox3.Enabled = true;

           this.orderDateDateTimePicker.Enabled = true;//All 右上角end

           if (status=="addnew")
           {
               this.purchaseOrderDetailDataGridView.ReadOnly = true;
           }
           else
           {
               this.purchaseOrderDetailDataGridView.ReadOnly = false;
           }
                
            

            bindingNavigatorAddNewItem.Enabled = false; // 新增
            toolStripButton1.Enabled = false;           // 修改
            bindingNavigatorDeleteItem.Enabled = false; // 刪除
            toolStripButton3.Enabled = false;           // 查詢
            purchaseOrderBindingNavigatorSaveItem.Enabled = true; // 儲存
            toolStripButton2.Enabled = true;          // 取消
            }
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CheckAllValue())
            {
                this.Validate();
            this.purchaseOrdersBindingSource.EndEdit();
            this.purchaseOrdersTableAdapter.Update(this.smartShoppingDataSet.PurchaseOrders);
            this.purchaseOrderDetailDataGridView.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("請先完成訂單資料再新增明細");
            }
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmPurchaseOrderQuery frmQuery = new frmPurchaseOrderQuery();
            frmQuery.ShowDialog();
            if (frmQuery.dlgResult == System.Windows.Forms.DialogResult.OK)
            {
                if (frmQuery.My進貨單號 != 0)
                {
                    this.purchaseOrdersTableAdapter.FillByPuchaseOrder_ID(this.smartShoppingDataSet.PurchaseOrders, frmQuery.My進貨單號);
                }
                else if ((frmQuery.My訂單日期起 != "") && (frmQuery.My訂單日期迄 != ""))
                {
                    this.purchaseOrdersTableAdapter.FillByOrderDate(this.smartShoppingDataSet.PurchaseOrders, Convert.ToDateTime(frmQuery.My訂單日期起), Convert.ToDateTime(frmQuery.My訂單日期迄));
                }
                else
                {
                    this.purchaseOrdersTableAdapter.Fill(this.smartShoppingDataSet.PurchaseOrders);
                }
            }
        }

        private void label10_MouseDown(object sender, MouseEventArgs e)
        {
            if (status=="modify"||status=="addnew")
            {
                this.linkLabel1.Visible = true;
            }
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪除?","訊息",MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                
                    this.purchaseOrderDetailTableAdapter.DeleteQuery(delva1);
                    this.Validate();
                    this.purchaseOrdersBindingSource.EndEdit();
                    this.purchaseOrdersTableAdapter.Update(this.smartShoppingDataSet.PurchaseOrders);

            }
            else
            {
                this.purchaseOrdersTableAdapter.Fill(this.smartShoppingDataSet.PurchaseOrders);
            }
        }
        int delva1;
        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {
            
            int.TryParse(purchaseOrder_IDTextBox.Text,out delva1);
        }

        private void exLabel1_Click(object sender, EventArgs e)
        {
                    }
    }
}
