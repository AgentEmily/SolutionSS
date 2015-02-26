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
    public partial class frmOrdersQuery : Form
    {
        public frmOrdersQuery()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                if (((ComboBox)sender).Text == "訂單編號")
                {
                    label2.Text = "訂單編號";
                    label2.Visible = true;
                    textBox1.Visible = true;
                    label3.Top = 167;
                    label3.Visible = false;
                    dateTimePicker1.Top = 167;
                    dateTimePicker1.Visible = false;
                    dateTimePicker2.Top = 167;
                    dateTimePicker2.Visible = false;
                }
                else if (((ComboBox)sender).Text == "會員編號")
                {
                    label2.Text = "會員編號";
                    label2.Visible = true;
                    textBox1.Visible = true;
                    label3.Top = 167;
                    label3.Visible = false;
                    dateTimePicker1.Top = 167;
                    dateTimePicker1.Visible = false;
                    dateTimePicker2.Top = 167;
                    dateTimePicker2.Visible = false;
                }
                else if (((ComboBox)sender).Text == "訂單日期")
                {
                    label2.Visible = false;
                    textBox1.Visible = false;
                    label3.Top = 108;
                    label3.Visible = true;
                    dateTimePicker1.Top = 108;
                    dateTimePicker1.Visible = true;
                    dateTimePicker2.Top = 108;
                    dateTimePicker2.Visible = true;
                }
                else if (((ComboBox)sender).Text == "出貨日期")
                {
                    label2.Visible = false;
                    textBox1.Visible = false;
                    label3.Top = 108;
                    label3.Visible = true;
                    dateTimePicker1.Top = 108;
                    dateTimePicker1.Visible = true;
                    dateTimePicker2.Top = 108;
                    dateTimePicker2.Visible = true;
                }
                else
                {
                    label2.Visible = false;
                    textBox1.Visible = false;
                    label3.Top = 167;
                    label3.Visible = false;
                    dateTimePicker1.Top = 167;
                    dateTimePicker1.Visible = false;
                    dateTimePicker2.Top = 167;
                    dateTimePicker2.Visible = false;
                }
            }
        }
        private string ComboxText;

        public string MyComboxText
        {
            get { return ComboxText; }
            set { ComboxText = value; }
        }

        private int ID;

        public int MyID
        {
            get { return ID; }
            set { ID = value; }
        }

        private string SDate;

        public string MySDate
        {
            get { return SDate; }
            set { SDate = value; }
        }

        private string EDate;

        public string MyEDate
        {
            get { return EDate; }
            set { EDate = value; }
        }
        private void Btn_OK_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == "")
            {
                MessageBox.Show("未選擇查詢條件，請選擇！！");
                return;
            }
            MyComboxText = comboBox1.Text;
            if (comboBox1.Text == "訂單編號")
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("請輸入訂單編號！！");
                    return;
                }
                if (!int.TryParse(textBox1.Text, out ID))
                {
                    MessageBox.Show("訂單編號請輸入正整數！！");
                    return;
                }
            }
            else if (comboBox1.Text == "會員編號")
            {
                if (textBox1.Text.Trim() == "")
                {
                    MessageBox.Show("請輸入會員編號！！");
                    return;
                }
                if (!int.TryParse(textBox1.Text, out ID))
                {
                    MessageBox.Show("會員編號請輸入正整數！！");
                    return;
                }
            }
            else if (comboBox1.Text == "訂單日期")
            {
                if (dateTimePicker1.Value == null)
                {
                    MessageBox.Show("請輸入起始日期！！");
                    return;
                }
                if (dateTimePicker2.Value == null)
                {
                    MessageBox.Show("請輸入迄止日期！！");
                    return;
                }
                MySDate = dateTimePicker1.Value.Date.ToString();
                MyEDate = dateTimePicker2.Value.Date.ToString();
            }
            else if (comboBox1.Text == "出貨日期")
            {
                if (dateTimePicker1.Value == null)
                {
                    MessageBox.Show("請輸入起始日期！！");
                    return;
                }
                if (dateTimePicker2.Value == null)
                {
                    MessageBox.Show("請輸入迄止日期！！");
                    return;
                }
                MySDate = dateTimePicker1.Value.Date.ToString();
                MyEDate = dateTimePicker2.Value.Date.ToString();
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
