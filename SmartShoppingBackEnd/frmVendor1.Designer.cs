namespace SmartShoppingBackEnd
{
    partial class frmVendor1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendor1));
            System.Windows.Forms.Label vendorEmailLabel;
            System.Windows.Forms.Label paymentMethod_IDLabel;
            System.Windows.Forms.Label vendorAddressLabel;
            System.Windows.Forms.Label vendorPhoneLabel;
            System.Windows.Forms.Label representativeLabel;
            System.Windows.Forms.Label vendorNameLabel;
            System.Windows.Forms.Label unifiedBusinessNumbeLabel;
            this.smartShoppingDataSet = new SmartShoppingBackEnd.SmartShoppingDataSet();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorsTableAdapter = new SmartShoppingBackEnd.SmartShoppingDataSetTableAdapters.VendorsTableAdapter();
            this.tableAdapterManager = new SmartShoppingBackEnd.SmartShoppingDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.vendorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vendorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.vendorEmailTextBox = new System.Windows.Forms.TextBox();
            this.paymentMethod_IDTextBox = new System.Windows.Forms.TextBox();
            this.vendorAddressTextBox = new System.Windows.Forms.TextBox();
            this.vendorPhoneTextBox = new System.Windows.Forms.TextBox();
            this.representativeTextBox = new System.Windows.Forms.TextBox();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.unifiedBusinessNumbeTextBox = new System.Windows.Forms.TextBox();
            this.vendorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            vendorEmailLabel = new System.Windows.Forms.Label();
            paymentMethod_IDLabel = new System.Windows.Forms.Label();
            vendorAddressLabel = new System.Windows.Forms.Label();
            vendorPhoneLabel = new System.Windows.Forms.Label();
            representativeLabel = new System.Windows.Forms.Label();
            vendorNameLabel = new System.Windows.Forms.Label();
            unifiedBusinessNumbeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.smartShoppingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingNavigator)).BeginInit();
            this.vendorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // smartShoppingDataSet
            // 
            this.smartShoppingDataSet.DataSetName = "SmartShoppingDataSet";
            this.smartShoppingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataMember = "Vendors";
            this.vendorsBindingSource.DataSource = this.smartShoppingDataSet;
            // 
            // vendorsTableAdapter
            // 
            this.vendorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BrandsTableAdapter = null;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.InsideShoppingListTableAdapter = null;
            this.tableAdapterManager.MemberRoleTableAdapter = null;
            this.tableAdapterManager.MemberTableAdapter = null;
            this.tableAdapterManager.OrderDetailTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.OutsideShoppingListTableAdapter = null;
            this.tableAdapterManager.OutSide完成日紀錄TableAdapter = null;
            this.tableAdapterManager.PaymentMethodTableAdapter = null;
            this.tableAdapterManager.ProductPictureTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.PromotionDetailTableAdapter = null;
            this.tableAdapterManager.promotionTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderDetail進貨明細TableAdapter = null;
            this.tableAdapterManager.PurchaseOrder進貨單TableAdapter = null;
            this.tableAdapterManager.ReturnsTableAdapter = null;
            this.tableAdapterManager.RolesDetailTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.RoyaltyTableAdapter = null;
            this.tableAdapterManager.ShipMethodTableAdapter = null;
            this.tableAdapterManager.ShippingTableAdapter = null;
            this.tableAdapterManager.SSBackEndAuthorityTableAdapter = null;
            this.tableAdapterManager.SSBackEndProgramTableAdapter = null;
            this.tableAdapterManager.SSBackEndUserTableAdapter = null;
            this.tableAdapterManager.Status_PurchaseOrderTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SmartShoppingBackEnd.SmartShoppingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VendorsTableAdapter = this.vendorsTableAdapter;
            this.tableAdapterManager.商品評論TableAdapter = null;
            this.tableAdapterManager.回購週期TableAdapter = null;
            this.tableAdapterManager.回購週期設定紀錄TableAdapter = null;
            this.tableAdapterManager.設定來源TableAdapter = null;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(27, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // vendorsBindingNavigatorSaveItem
            // 
            this.vendorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vendorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vendorsBindingNavigatorSaveItem.Image")));
            this.vendorsBindingNavigatorSaveItem.Name = "vendorsBindingNavigatorSaveItem";
            this.vendorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vendorsBindingNavigatorSaveItem.Text = "儲存資料";
            this.vendorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.vendorsBindingNavigatorSaveItem_Click);
            // 
            // vendorsBindingNavigator
            // 
            this.vendorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vendorsBindingNavigator.BindingSource = this.vendorsBindingSource;
            this.vendorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vendorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vendorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vendorsBindingNavigatorSaveItem});
            this.vendorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vendorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vendorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vendorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vendorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vendorsBindingNavigator.Name = "vendorsBindingNavigator";
            this.vendorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vendorsBindingNavigator.Size = new System.Drawing.Size(1127, 25);
            this.vendorsBindingNavigator.TabIndex = 0;
            this.vendorsBindingNavigator.Text = "bindingNavigator1";
            // 
            // vendorEmailTextBox
            // 
            this.vendorEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorEmail", true));
            this.vendorEmailTextBox.Location = new System.Drawing.Point(155, 268);
            this.vendorEmailTextBox.Name = "vendorEmailTextBox";
            this.vendorEmailTextBox.Size = new System.Drawing.Size(176, 22);
            this.vendorEmailTextBox.TabIndex = 16;
            // 
            // vendorEmailLabel
            // 
            vendorEmailLabel.AutoSize = true;
            vendorEmailLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            vendorEmailLabel.Location = new System.Drawing.Point(41, 271);
            vendorEmailLabel.Name = "vendorEmailLabel";
            vendorEmailLabel.Size = new System.Drawing.Size(111, 19);
            vendorEmailLabel.TabIndex = 15;
            vendorEmailLabel.Text = "廠商電子郵件 : ";
            // 
            // paymentMethod_IDTextBox
            // 
            this.paymentMethod_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "PaymentMethod_ID", true));
            this.paymentMethod_IDTextBox.Location = new System.Drawing.Point(155, 227);
            this.paymentMethod_IDTextBox.Name = "paymentMethod_IDTextBox";
            this.paymentMethod_IDTextBox.Size = new System.Drawing.Size(175, 22);
            this.paymentMethod_IDTextBox.TabIndex = 14;
            // 
            // paymentMethod_IDLabel
            // 
            paymentMethod_IDLabel.AutoSize = true;
            paymentMethod_IDLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            paymentMethod_IDLabel.Location = new System.Drawing.Point(6, 228);
            paymentMethod_IDLabel.Name = "paymentMethod_IDLabel";
            paymentMethod_IDLabel.Size = new System.Drawing.Size(137, 19);
            paymentMethod_IDLabel.TabIndex = 13;
            paymentMethod_IDLabel.Text = "廠商付款方式編號 :";
            // 
            // vendorAddressTextBox
            // 
            this.vendorAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorAddress", true));
            this.vendorAddressTextBox.Location = new System.Drawing.Point(155, 192);
            this.vendorAddressTextBox.Name = "vendorAddressTextBox";
            this.vendorAddressTextBox.Size = new System.Drawing.Size(266, 22);
            this.vendorAddressTextBox.TabIndex = 12;
            // 
            // vendorAddressLabel
            // 
            vendorAddressLabel.AutoSize = true;
            vendorAddressLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            vendorAddressLabel.Location = new System.Drawing.Point(67, 195);
            vendorAddressLabel.Name = "vendorAddressLabel";
            vendorAddressLabel.Size = new System.Drawing.Size(77, 19);
            vendorAddressLabel.TabIndex = 11;
            vendorAddressLabel.Text = "公司地址 :";
            // 
            // vendorPhoneTextBox
            // 
            this.vendorPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorPhone", true));
            this.vendorPhoneTextBox.Location = new System.Drawing.Point(155, 151);
            this.vendorPhoneTextBox.Name = "vendorPhoneTextBox";
            this.vendorPhoneTextBox.Size = new System.Drawing.Size(175, 22);
            this.vendorPhoneTextBox.TabIndex = 10;
            // 
            // vendorPhoneLabel
            // 
            vendorPhoneLabel.AutoSize = true;
            vendorPhoneLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            vendorPhoneLabel.Location = new System.Drawing.Point(68, 154);
            vendorPhoneLabel.Name = "vendorPhoneLabel";
            vendorPhoneLabel.Size = new System.Drawing.Size(77, 19);
            vendorPhoneLabel.TabIndex = 9;
            vendorPhoneLabel.Text = "行動電話 :";
            // 
            // representativeTextBox
            // 
            this.representativeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Representative", true));
            this.representativeTextBox.Location = new System.Drawing.Point(154, 116);
            this.representativeTextBox.Name = "representativeTextBox";
            this.representativeTextBox.Size = new System.Drawing.Size(176, 22);
            this.representativeTextBox.TabIndex = 8;
            // 
            // representativeLabel
            // 
            representativeLabel.AutoSize = true;
            representativeLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            representativeLabel.Location = new System.Drawing.Point(83, 119);
            representativeLabel.Name = "representativeLabel";
            representativeLabel.Size = new System.Drawing.Size(62, 19);
            representativeLabel.TabIndex = 7;
            representativeLabel.Text = "聯絡人 :";
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorName", true));
            this.vendorNameTextBox.Location = new System.Drawing.Point(155, 78);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.vendorNameTextBox.TabIndex = 6;
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            vendorNameLabel.Location = new System.Drawing.Point(69, 78);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(77, 19);
            vendorNameLabel.TabIndex = 5;
            vendorNameLabel.Text = "廠商名稱 :";
            // 
            // unifiedBusinessNumbeTextBox
            // 
            this.unifiedBusinessNumbeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "UnifiedBusinessNumbe", true));
            this.unifiedBusinessNumbeTextBox.Location = new System.Drawing.Point(154, 45);
            this.unifiedBusinessNumbeTextBox.Name = "unifiedBusinessNumbeTextBox";
            this.unifiedBusinessNumbeTextBox.Size = new System.Drawing.Size(175, 22);
            this.unifiedBusinessNumbeTextBox.TabIndex = 4;
            // 
            // unifiedBusinessNumbeLabel
            // 
            unifiedBusinessNumbeLabel.AutoSize = true;
            unifiedBusinessNumbeLabel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            unifiedBusinessNumbeLabel.Location = new System.Drawing.Point(69, 45);
            unifiedBusinessNumbeLabel.Name = "unifiedBusinessNumbeLabel";
            unifiedBusinessNumbeLabel.Size = new System.Drawing.Size(77, 19);
            unifiedBusinessNumbeLabel.TabIndex = 3;
            unifiedBusinessNumbeLabel.Text = "統一編號 :";
            // 
            // vendorsDataGridView
            // 
            this.vendorsDataGridView.AutoGenerateColumns = false;
            this.vendorsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.vendorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.vendorsDataGridView.DataSource = this.vendorsBindingSource;
            this.vendorsDataGridView.Location = new System.Drawing.Point(442, 45);
            this.vendorsDataGridView.Name = "vendorsDataGridView";
            this.vendorsDataGridView.RowTemplate.Height = 24;
            this.vendorsDataGridView.Size = new System.Drawing.Size(643, 415);
            this.vendorsDataGridView.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Vendor_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Vendor_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UnifiedBusinessNumbe";
            this.dataGridViewTextBoxColumn2.HeaderText = "UnifiedBusinessNumbe";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VendorName";
            this.dataGridViewTextBoxColumn3.HeaderText = "VendorName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Representative";
            this.dataGridViewTextBoxColumn4.HeaderText = "Representative";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VendorPhone";
            this.dataGridViewTextBoxColumn5.HeaderText = "VendorPhone";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "VendorAddress";
            this.dataGridViewTextBoxColumn6.HeaderText = "VendorAddress";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PaymentMethod_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "PaymentMethod_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "VendorEmail";
            this.dataGridViewTextBoxColumn8.HeaderText = "VendorEmail";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmVendor1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 495);
            this.Controls.Add(this.vendorsDataGridView);
            this.Controls.Add(unifiedBusinessNumbeLabel);
            this.Controls.Add(this.unifiedBusinessNumbeTextBox);
            this.Controls.Add(vendorNameLabel);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(representativeLabel);
            this.Controls.Add(this.representativeTextBox);
            this.Controls.Add(vendorPhoneLabel);
            this.Controls.Add(this.vendorPhoneTextBox);
            this.Controls.Add(vendorAddressLabel);
            this.Controls.Add(this.vendorAddressTextBox);
            this.Controls.Add(paymentMethod_IDLabel);
            this.Controls.Add(this.paymentMethod_IDTextBox);
            this.Controls.Add(vendorEmailLabel);
            this.Controls.Add(this.vendorEmailTextBox);
            this.Controls.Add(this.vendorsBindingNavigator);
            this.Name = "frmVendor1";
            this.Text = "frmVendor1";
            this.Load += new System.EventHandler(this.frmVendor1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.smartShoppingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingNavigator)).EndInit();
            this.vendorsBindingNavigator.ResumeLayout(false);
            this.vendorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SmartShoppingDataSet smartShoppingDataSet;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private SmartShoppingDataSetTableAdapters.VendorsTableAdapter vendorsTableAdapter;
        private SmartShoppingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton vendorsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator vendorsBindingNavigator;
        private System.Windows.Forms.TextBox vendorEmailTextBox;
        private System.Windows.Forms.TextBox paymentMethod_IDTextBox;
        private System.Windows.Forms.TextBox vendorAddressTextBox;
        private System.Windows.Forms.TextBox vendorPhoneTextBox;
        private System.Windows.Forms.TextBox representativeTextBox;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox unifiedBusinessNumbeTextBox;
        private System.Windows.Forms.DataGridView vendorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

    }
}