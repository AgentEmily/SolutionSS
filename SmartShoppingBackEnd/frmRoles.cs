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
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }
        string Btn_Status = "Browse";
        int delval;
        private void rolesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (Btn_Status == "Delete")
            {
                this.rolesDetailTableAdapter.DeleteQuery(delval);
            }
            
            this.Validate();
            this.rolesBindingSource.EndEdit();
            this.rolesDetailBindingSource.EndEdit();
            this.rolesDetailTableAdapter.Update(this.smartShoppingDataSet.RolesDetail);
            rolesTableAdapter.Update(this.smartShoppingDataSet.Roles);
            this.rolesDetailDataGridView.Columns["Delete"].Visible = false;
            Btn_Status = "Save";
            this.rolesNameTextBox.ReadOnly = true;
            this.rolesDetailDataGridView.ReadOnly = true;
            Btn_Status_true();

        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Categories_Status' 資料表。您可以視需要進行移動或移除。
            this.categories_StatusTableAdapter.Fill(this.smartShoppingDataSet.Categories_Status);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.RolesDetail' 資料表。您可以視需要進行移動或移除。
            this.rolesDetailTableAdapter.Fill(this.smartShoppingDataSet.RolesDetail);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.RolesDetail' 資料表。您可以視需要進行移動或移除。
            this.rolesDetailTableAdapter.Fill(this.smartShoppingDataSet.RolesDetail);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Roles' 資料表。您可以視需要進行移動或移除。
            this.rolesTableAdapter.Fill(this.smartShoppingDataSet.Roles);
            Btn_Status_true();
        }

        private void Btn_Status_true()
        {
            bindingNavigatorAddNewItem.Enabled = true;
            toolStripButton1.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            rolesBindingNavigatorSaveItem.Enabled = false;
            toolStripButton2.Enabled = false;
            this.rolesNameTextBox.ReadOnly = true;
            this.panel1.BackColor = Color.Transparent;
        }

        private void Btn_Status_false()
        {
            bindingNavigatorAddNewItem.Enabled = false;
            toolStripButton1.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            rolesBindingNavigatorSaveItem.Enabled = true;
            toolStripButton2.Enabled = true;
            this.rolesNameTextBox.ReadOnly = false;
            this.panel1.BackColor = Color.Plum;
            
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.rolesNameTextBox.ReadOnly = false;
            this.rolesDetailDataGridView.ReadOnly = true;
            Btn_Status_false();
            Btn_Status = "Insert";
            this.rolesNameTextBox.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.rolesNameTextBox.ReadOnly = false;
            this.rolesDetailDataGridView.ReadOnly = false;
            this.rolesDetailDataGridView.Columns["Delete"].Visible = true;
            Btn_Status_false();
            Btn_Status = "Update";
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            Btn_Status_false();
            Btn_Status = "Delete";
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Btn_Status = "Cancel";
            this.rolesDetailDataGridView.Columns["Delete"].Visible = false;
            this.rolesNameTextBox.ReadOnly = true;
            this.rolesDetailDataGridView.ReadOnly = true;
            Btn_Status_true();
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Categories' 資料表。您可以視需要進行移動或移除。
            this.rolesDetailTableAdapter.Fill(this.smartShoppingDataSet.RolesDetail);
            // TODO:  這行程式碼會將資料載入 'smartShoppingDataSet.Roles' 資料表。您可以視需要進行移動或移除。
            this.rolesTableAdapter.Fill(this.smartShoppingDataSet.Roles);
        }

        private void rolesDetailDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                this.rolesDetailBindingSource.RemoveAt(this.rolesDetailBindingSource.Position);
            }
        }

        private void rolesDetailDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.rolesNameTextBox.ReadOnly = false;
            this.rolesDetailDataGridView.ReadOnly = false;
            this.rolesDetailDataGridView.Columns["Delete"].Visible = true;
            Btn_Status_false();
            Btn_Status = "Update";
        }

        private void rolesDetailDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.rolesNameTextBox.ReadOnly = false;
            this.rolesDetailDataGridView.ReadOnly = false;
            this.rolesDetailDataGridView.Columns["Delete"].Visible = true;
            Btn_Status_false();
            Btn_Status = "Update";
        }

        private void rolesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
