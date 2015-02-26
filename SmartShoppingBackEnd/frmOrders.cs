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
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
        }

        string Btn_Status = "Browser";
        int lviOrderID;
        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (CheckAllValue())
            {
                this.Validate();
                this.ordersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.smartShoppingDataSet);
                Btn_Status = "Browser";
                ButtonSetting();
            }
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Status' 資料表。您可以視需要進行移動或移除。
            this.statusTableAdapter.Fill(this.smartShoppingDataSet.Status);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.PaymentMethod' 資料表。您可以視需要進行移動或移除。
            this.paymentMethodTableAdapter.Fill(this.smartShoppingDataSet.PaymentMethod);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.ShipMethod' 資料表。您可以視需要進行移動或移除。
            this.shipMethodTableAdapter.Fill(this.smartShoppingDataSet.ShipMethod);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.smartShoppingDataSet.Products);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.OrderDetail' 資料表。您可以視需要進行移動或移除。
            this.orderDetailTableAdapter.Fill(this.smartShoppingDataSet.OrderDetail);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Orders' 資料表。您可以視需要進行移動或移除。
            this.ordersTableAdapter.Fill(this.smartShoppingDataSet.Orders);
            ButtonSetting();

        }

        private void ButtonSetting()
        {
            if (Btn_Status == "Browser")
            {
                foreach (Control x in this.splitContainer2.Panel1.Controls)
                {
                    if (x is TextBox)
                    {
                        ((TextBox)x).ReadOnly = true;
                    }
                }
                linkLabel1.Visible = false;
                orderDetailDataGridView.ReadOnly = true;
                orderDateDateTimePicker.Enabled = false;
                arrivalDateDateTimePicker.Enabled = false;
                this.orderDetailDataGridView.Columns["Delete"].Visible = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = true; // 新增
                toolStripButton1.Enabled = true;           // 修改
                bindingNavigatorDeleteItem.Enabled = true; // 刪除
                toolStripButton3.Enabled = true;           // 查詢
                ordersBindingNavigatorSaveItem.Enabled = false;  //儲存
                toolStripButton2.Enabled = false;            // 取消
            }
            else if (Btn_Status == "Insert" || Btn_Status == "Modify")
            { 
                foreach (Control x in this.splitContainer2.Panel1.Controls)
                {
                    if (x is TextBox)
                    {
                        ((TextBox)x).ReadOnly = false;
                    }
                }
                orderDateDateTimePicker.Enabled = true;
                arrivalDateDateTimePicker.Enabled = true;
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = false; // 新增
                toolStripButton1.Enabled = false;           // 修改
                bindingNavigatorDeleteItem.Enabled = false; // 刪除
                toolStripButton3.Enabled = false;           // 查詢
                ordersBindingNavigatorSaveItem.Enabled = true;  //儲存
                toolStripButton2.Enabled = true;            // 取消
                if (Btn_Status == "Modify")
                {
                    orderDetailDataGridView.ReadOnly = false;
                    this.orderDetailDataGridView.Columns["Delete"].Visible = true;
                }
                if (Btn_Status == "Insert")
                {
                    orderDetailDataGridView.ReadOnly = true;
                    comboBox1.SelectedValue = -1;
                    comboBox2.SelectedValue = -1;
                    comboBox3.SelectedValue = -1;
                    linkLabel1.Visible = true;
                }
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Btn_Status = "Insert";
            ButtonSetting();
            orderDateDateTimePicker.Value = DateTime.Today.Date;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {   
            Btn_Status = "Modify";
            ButtonSetting();
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要刪除?", "訊息", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.orderDetailTableAdapter.DeleteQuery(lviOrderID);
                this.Validate();
                this.ordersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.smartShoppingDataSet);
            }
            else
            {
                // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Orders' 資料表。您可以視需要進行移動或移除。
                this.ordersTableAdapter.Fill(this.smartShoppingDataSet.Orders);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Btn_Status = "Browser";
            ButtonSetting();
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.OrderDetail' 資料表。您可以視需要進行移動或移除。
            this.orderDetailTableAdapter.Fill(this.smartShoppingDataSet.OrderDetail);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Orders' 資料表。您可以視需要進行移動或移除。
            this.ordersTableAdapter.Fill(this.smartShoppingDataSet.Orders);
        }
                        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (sender is ComboBox)
            //{
            //    if (((ComboBox)sender).SelectedValue != null)
            //    {
            //        shipMethod_IDTextBox.Text = ((ComboBox)sender).SelectedValue.ToString();
            //        //this.ordersBindingSource.EndEdit();
            //    }
            //}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (sender is ComboBox)
            //{
            //    if (((ComboBox)sender).SelectedValue != null)
            //    {
            //        paymentMethod_IDTextBox.Text = ((ComboBox)sender).SelectedValue.ToString();
            //        //this.ordersBindingSource.EndEdit();
            //    }
            //}
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (sender is ComboBox)
            //{
            //    if (((ComboBox)sender).SelectedValue != null)
            //    {
            //        status_IDTextBox.Text = ((ComboBox)sender).SelectedValue.ToString();
            //        //this.ordersBindingSource.EndEdit();
            //    }
            //}
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Btn_Status = "Query";
            frmOrdersQuery OrdersQuery = new frmOrdersQuery();
            if (OrdersQuery.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (OrdersQuery.MyComboxText == "訂單編號")
                {
                    this.ordersTableAdapter.FillByOrder_ID(this.smartShoppingDataSet.Orders, OrdersQuery.MyID);
                }
                else if (OrdersQuery.MyComboxText == "會員編號")
                {
                    this.ordersTableAdapter.FillByMember_ID(this.smartShoppingDataSet.Orders, OrdersQuery.MyID);
                }
                else if (OrdersQuery.MyComboxText == "訂單日期")
                {
                    this.ordersTableAdapter.FillByOrderDate(this.smartShoppingDataSet.Orders, Convert.ToDateTime(OrdersQuery.MySDate), Convert.ToDateTime(OrdersQuery.MyEDate));
                }
                else if (OrdersQuery.MyComboxText == "出貨日期")
                {
                    this.ordersTableAdapter.FillByArrivalDate(this.smartShoppingDataSet.Orders, OrdersQuery.MySDate, OrdersQuery.MyEDate);
                }
                else
                {
                    this.ordersTableAdapter.Fill(this.smartShoppingDataSet.Orders);
                }
            }
            OrdersQuery.Dispose();
        }

        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e)
        {
            int.TryParse(order_IDTextBox.Text, out lviOrderID);
        }

        private void orderDetailDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                this.orderDetailBindingSource.RemoveAt(this.orderDetailBindingSource.Position);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CheckAllValue())
            {
                this.Validate();
                this.ordersBindingSource.EndEdit();
                ordersTableAdapter.Update(this.smartShoppingDataSet.Orders);
                orderDetailDataGridView.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("請先完成訂單資料再新增明細");
            }
        }

        private bool CheckAllValue()
        {
            if (orderDateDateTimePicker.Value == null)
            {
                orderDateDateTimePicker.Value = DateTime.Today.Date;
            }
            if (member_IDTextBox.Text.Trim() == "")
            {
                MessageBox.Show("會員編號未輸入！！");
                member_IDTextBox.Focus();
                return false;
            }
            else if (subTotalTextBox.Text.Trim() == "")
            {
                MessageBox.Show("未輸入小計！！");
                subTotalTextBox.Focus();
                return false;
            }
            else if (valueAddTaxTextBox.Text.Trim() == "")
            {
                MessageBox.Show("未輸入稅額！！");
                valueAddTaxTextBox.Focus();
                return false;
            }
            else if (shippingFeeTextBox.Text.Trim() == "")
            {
                MessageBox.Show("未輸入運費！！");
                shippingFeeTextBox.Focus();
                return false;
            }
            else if (amountTextBox.Text.Trim() == "")
            {
                MessageBox.Show("未輸入總計！！");
                amountTextBox.Focus();
                return false;
            }
            else if (comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("請選擇運送方式！！");
                comboBox1.Focus();
                return false;
            }
            else if (comboBox2.Text.Trim() == "")
            {
                MessageBox.Show("請選擇付費方式！！");
                comboBox2.Focus();
                return false;
            }
            else if (comboBox3.Text.Trim() == "")
            {
                MessageBox.Show("請選擇狀態！！");
                comboBox3.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
