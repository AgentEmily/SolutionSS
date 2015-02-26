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
    public partial class frmPurchaseOrder : Form
    {
        public frmPurchaseOrder()
        {
            InitializeComponent();
        }
        string btnStatus = "";
        int delval;
        private void frmPurchaseOrder_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.PurchaseOrderDetail' 資料表。您可以視需要進行移動或移除。
            this.purchaseOrderDetailTableAdapter.Fill(this.smartShoppingDataSet.PurchaseOrderDetail);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Status' 資料表。您可以視需要進行移動或移除。
            this.statusTableAdapter.Fill(this.smartShoppingDataSet.Status);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.PaymentMethod' 資料表。您可以視需要進行移動或移除。
            this.paymentMethodTableAdapter.Fill(this.smartShoppingDataSet.PaymentMethod);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Vendors' 資料表。您可以視需要進行移動或移除。
            this.vendorsTableAdapter.Fill(this.smartShoppingDataSet.Vendors);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.PurchaseOrders' 資料表。您可以視需要進行移動或移除。
            this.purchaseOrdersTableAdapter.Fill(this.smartShoppingDataSet.PurchaseOrders);
            this.PurchaseBindingNavigator.BindingSource = purchaseOrdersBindingSource;
            Btn_Status_true();
            ChangeReadOnlyTrue();
      }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            btnStatus = "Insert";
            ChangeReadOnlyfalse();
            this.purchaseOrderDetailDataGridView.ReadOnly = true;
            Btn_Status_false();
            this.orderDateDateTimePicker.Value = DateTime.Today;


        }
        private void Btn_Status_false()
        {
            
            bindingNavigatorAddNewItem.Enabled = false; // 新增
            toolStripButton1.Enabled = false;           // 修改
            bindingNavigatorDeleteItem.Enabled = false; // 刪除
            toolStripButton3.Enabled = false;           // 查詢
            purchaseOrderBindingNavigatorSaveItem.Enabled = true; // 儲存
            toolStripButton2.Enabled = true;            // 取消
        }
        private void Btn_Status_true()
        {
            bindingNavigatorAddNewItem.Enabled = true; // 新增
            toolStripButton1.Enabled = true;           // 修改
            bindingNavigatorDeleteItem.Enabled = true; // 刪除
            toolStripButton3.Enabled = true;           // 查詢
            purchaseOrderBindingNavigatorSaveItem.Enabled = false; // 儲存
            toolStripButton2.Enabled = false;          // 取消
        }
        private void ChangeReadOnlyfalse()
        {
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
            invoiceNumberTextBox.Enabled = true;
            invoiceNumberTextBox.ReadOnly = false;
            this.orderDateDateTimePicker.Enabled = true;
            this.purchaseOrderDetailDataGridView.ReadOnly = false;
        }
        private void ChangeReadOnlyTrue()
        {
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
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            btnStatus = "Delete";
            Btn_Status_false();
        }

        private void purchaseOrderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (btnStatus == "Delete")
            {
                this.purchaseOrderDetailTableAdapter.DeleteQuery(delval);
            }
            //先判斷哪一格沒有寫   再try catch save
            if (CheckAllValue())
            {
                try
                {
            this.Validate();
            this.purchaseOrdersBindingSource.EndEdit();
            this.purchaseOrderDetailBindingSource.EndEdit();
            this.purchaseOrderDetailTableAdapter.Update(this.smartShoppingDataSet.PurchaseOrderDetail);
            this.purchaseOrdersTableAdapter.Update(this.smartShoppingDataSet.PurchaseOrders);
            
            
            
            
            ChangeReadOnlyTrue();
            Btn_Status_true();
            purchaseOrderDetailDataGridView.Columns["Delete"].Visible = false;
            btnStatus = "Save";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
                
            }
            
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            btnStatus = "Update";
            ChangeReadOnlyfalse();
            Btn_Status_false();
            purchaseOrderDetailDataGridView.Columns["Delete"].Visible = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ChangeReadOnlyTrue();
            Btn_Status_true();
            purchaseOrderDetailDataGridView.Columns["Delete"].Visible = false;
            btnStatus = "Cancel";
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.PurchaseOrderDetail進貨明細' 資料表。您可以視需要進行移動或移除。
            this.purchaseOrderDetailTableAdapter.Fill(this.smartShoppingDataSet.PurchaseOrderDetail);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.PurchaseOrder進貨單' 資料表。您可以視需要進行移動或移除。
            this.purchaseOrdersTableAdapter.Fill(this.smartShoppingDataSet.PurchaseOrders);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private bool CheckAllValue()
        {
            bool passed=false;
            if (this.orderDateDateTimePicker.Value is DBNull)
            {
                this.orderDateDateTimePicker.Value = DateTime.Today;
            }
            if (this.comboBox3.Text=="")
            {
                this.comboBox3.Text = "1";}

            if (this.comboBox1.Text=="")
            {
                MessageBox.Show("請選擇供應商");
                this.comboBox1.Focus();
                
                return passed;
            }
            
            else if (this.subTotalTextBox.Text=="")
            {
                MessageBox.Show("請輸入進貨金額");
                this.subTotalTextBox.Focus();
                return passed;
            }
            else if (this.comboBox2.Text=="")
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

        private void subTotalTextBox_Leave(object sender, EventArgs e)
        {
            int subtotal=0;
            if (int.TryParse(this.subTotalTextBox.Text,out subtotal))
            {
                this.valueAddTaxTextBox.Text = (subtotal * 0.05).ToString();
                this.amountLabel2.Text = (double.Parse(this.valueAddTaxTextBox.Text) + subtotal).ToString();
                this.purchaseOrdersBindingSource.EndEdit();
            }
            else
            {
                MessageBox.Show("金額必須為整數");
            }
            
        }

        private void purchaseOrderDetailDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                this.purchaseOrderDetailBindingSource.RemoveAt(this.purchaseOrderDetailBindingSource.Position);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedValue != null)
            {
                
                //this.purchaseOrdersBindingSource.EndEdit();
            }
        }

        private void orderDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (((DateTimePicker)sender).Value != null)
            {
                //this.purchaseOrdersBindingSource.EndEdit();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedValue != null)
            {
                //this.purchaseOrdersBindingSource.EndEdit();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((ComboBox)sender).SelectedValue != null)
            {
                //this.purchaseOrdersBindingSource.EndEdit();
            }
        }




    }
}
