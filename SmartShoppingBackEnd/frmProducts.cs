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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        string Btn_Status = "Browse";
        int delval;
        private void frmProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'smartShoppingDataSet.Brands' table. You can move, or remove it, as needed.
            this.brandsTableAdapter.Fill(this.smartShoppingDataSet.Brands);
            // TODO: This line of code loads data into the 'smartShoppingDataSet.Categories_Status' table. You can move, or remove it, as needed.
            this.categories_StatusTableAdapter.Fill(this.smartShoppingDataSet.Categories_Status);
           
            // TODO: This line of code loads data into the 'smartShoppingDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.smartShoppingDataSet.Products);
            // TODO: This line of code loads data into the 'smartShoppingDataSet.Categories_P' table. You can move, or remove it, as needed.
            
            this.rolesBindingNavigator.BindingSource = productsBindingSource;

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //this.rolesNameTextBox.ReadOnly = false;
            //this.discontinuedCheckBox.CheckState = CheckState.Unchecked;//prevent null issue useless!!
            this.productsDataGridView.ReadOnly = true;
            Btn_Status_false();
            Btn_Status = "Insert";
            this.productNameTextBox.Focus();
        }
        private void Btn_Status_true()
        {
            bindingNavigatorAddNewItem.Enabled = true;
            toolStripButton1.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            rolesBindingNavigatorSaveItem.Enabled = false;
            toolStripButton2.Enabled = false;
            //this.rolesNameTextBox.ReadOnly = true;
            //this.panel1.BackColor = Color.Transparent;
        }

        private void Btn_Status_false()
        {
            bindingNavigatorAddNewItem.Enabled = false;
            toolStripButton1.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            rolesBindingNavigatorSaveItem.Enabled = true;
            toolStripButton2.Enabled = true;
            //this.rolesNameTextBox.ReadOnly = false;
            //this.panel1.BackColor = Color.Plum;

        }

        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (Btn_Status == "Delete")
            {
                this.productsTableAdapter.DeleteQuery(delval);
            }

            this.Validate();
            this.productsBindingSource.EndEdit();
           
            this.productsTableAdapter.Update(this.smartShoppingDataSet.Products);
            rolesTableAdapter.Update(this.smartShoppingDataSet.Roles);
            this.productsDataGridView.Columns["Delete"].Visible = false;
            Btn_Status = "Save";
            //this.rolesNameTextBox.ReadOnly = true;
            this.productsDataGridView.ReadOnly = true;
            Btn_Status_true();
            //寫error provider功能
        }
    }
}
