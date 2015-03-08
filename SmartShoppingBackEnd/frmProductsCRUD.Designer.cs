namespace SmartShoppingBackEnd
{
    partial class frmProductsCRUD
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label product_IDLabel;
            System.Windows.Forms.Label productNameLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label qtyperUnitLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label discontinuedLabel;
            System.Windows.Forms.Label category_IDLabel;
            System.Windows.Forms.Label brand_IDLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label lastReceiptDateLabel;
            System.Windows.Forms.Label lastDeliveryDateLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label commentLabel;
            this.ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BrandsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.product_IDTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.qtyperUnitTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.discontinuedCheckBox = new System.Windows.Forms.CheckBox();
            this.category_IDComboBox = new System.Windows.Forms.ComboBox();
            this.brand_IDComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.lastReceiptDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastDeliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.productsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exLabel1 = new ExControls.ExLabel();
            product_IDLabel = new System.Windows.Forms.Label();
            productNameLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            qtyperUnitLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            discontinuedLabel = new System.Windows.Forms.Label();
            category_IDLabel = new System.Windows.Forms.Label();
            brand_IDLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            lastReceiptDateLabel = new System.Windows.Forms.Label();
            lastDeliveryDateLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // product_IDLabel
            // 
            product_IDLabel.AutoSize = true;
            product_IDLabel.Location = new System.Drawing.Point(12, 10);
            product_IDLabel.Margin = new System.Windows.Forms.Padding(10);
            product_IDLabel.Name = "product_IDLabel";
            product_IDLabel.Size = new System.Drawing.Size(97, 25);
            product_IDLabel.TabIndex = 0;
            product_IDLabel.Text = "產品編號:";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new System.Drawing.Point(12, 49);
            productNameLabel.Margin = new System.Windows.Forms.Padding(10);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new System.Drawing.Size(97, 25);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "產品名稱:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(12, 89);
            unitPriceLabel.Margin = new System.Windows.Forms.Padding(10);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(57, 25);
            unitPriceLabel.TabIndex = 4;
            unitPriceLabel.Text = "單價:";
            // 
            // qtyperUnitLabel
            // 
            qtyperUnitLabel.AutoSize = true;
            qtyperUnitLabel.Location = new System.Drawing.Point(12, 129);
            qtyperUnitLabel.Margin = new System.Windows.Forms.Padding(10);
            qtyperUnitLabel.Name = "qtyperUnitLabel";
            qtyperUnitLabel.Size = new System.Drawing.Size(97, 25);
            qtyperUnitLabel.TabIndex = 6;
            qtyperUnitLabel.Text = "包裝數量:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(12, 169);
            stockLabel.Margin = new System.Windows.Forms.Padding(10);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(77, 25);
            stockLabel.TabIndex = 8;
            stockLabel.Text = "庫存量:";
            // 
            // discontinuedLabel
            // 
            discontinuedLabel.AutoSize = true;
            discontinuedLabel.Location = new System.Drawing.Point(12, 209);
            discontinuedLabel.Margin = new System.Windows.Forms.Padding(10);
            discontinuedLabel.Name = "discontinuedLabel";
            discontinuedLabel.Size = new System.Drawing.Size(77, 25);
            discontinuedLabel.TabIndex = 10;
            discontinuedLabel.Text = "銷售中:";
            // 
            // category_IDLabel
            // 
            category_IDLabel.AutoSize = true;
            category_IDLabel.Location = new System.Drawing.Point(12, 245);
            category_IDLabel.Margin = new System.Windows.Forms.Padding(10);
            category_IDLabel.Name = "category_IDLabel";
            category_IDLabel.Size = new System.Drawing.Size(97, 25);
            category_IDLabel.TabIndex = 12;
            category_IDLabel.Text = "類別名稱:";
            // 
            // brand_IDLabel
            // 
            brand_IDLabel.AutoSize = true;
            brand_IDLabel.Location = new System.Drawing.Point(12, 284);
            brand_IDLabel.Margin = new System.Windows.Forms.Padding(10);
            brand_IDLabel.Name = "brand_IDLabel";
            brand_IDLabel.Size = new System.Drawing.Size(97, 25);
            brand_IDLabel.TabIndex = 14;
            brand_IDLabel.Text = "品牌名稱:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 322);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(10);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(97, 25);
            descriptionLabel.TabIndex = 16;
            descriptionLabel.Text = "商品敘述:";
            // 
            // lastReceiptDateLabel
            // 
            lastReceiptDateLabel.AutoSize = true;
            lastReceiptDateLabel.Location = new System.Drawing.Point(12, 429);
            lastReceiptDateLabel.Margin = new System.Windows.Forms.Padding(10);
            lastReceiptDateLabel.Name = "lastReceiptDateLabel";
            lastReceiptDateLabel.Size = new System.Drawing.Size(117, 25);
            lastReceiptDateLabel.TabIndex = 18;
            lastReceiptDateLabel.Text = "最後進貨日:";
            // 
            // lastDeliveryDateLabel
            // 
            lastDeliveryDateLabel.AutoSize = true;
            lastDeliveryDateLabel.Location = new System.Drawing.Point(12, 469);
            lastDeliveryDateLabel.Margin = new System.Windows.Forms.Padding(10);
            lastDeliveryDateLabel.Name = "lastDeliveryDateLabel";
            lastDeliveryDateLabel.Size = new System.Drawing.Size(117, 25);
            lastDeliveryDateLabel.TabIndex = 20;
            lastDeliveryDateLabel.Text = "最後出貨日:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(12, 509);
            startDateLabel.Margin = new System.Windows.Forms.Padding(10);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(77, 25);
            startDateLabel.TabIndex = 22;
            startDateLabel.Text = "上架日:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(12, 549);
            endDateLabel.Margin = new System.Windows.Forms.Padding(10);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(77, 25);
            endDateLabel.TabIndex = 24;
            endDateLabel.Text = "下架日:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(12, 589);
            commentLabel.Margin = new System.Windows.Forms.Padding(10);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(57, 25);
            commentLabel.TabIndex = 26;
            commentLabel.Text = "備註:";
            // 
            // ProductsBindingSource
            // 
            this.ProductsBindingSource.DataSource = typeof(SmartShoppingBackEnd.Products);
            // 
            // CategoriesBindingSource
            // 
            this.CategoriesBindingSource.DataSource = typeof(SmartShoppingBackEnd.Categories);
            // 
            // BrandsBindingSource
            // 
            this.BrandsBindingSource.DataSource = typeof(SmartShoppingBackEnd.Brands);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.exLabel1);
            this.splitContainer1.Panel1.Controls.Add(product_IDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.product_IDTextBox);
            this.splitContainer1.Panel1.Controls.Add(productNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.productNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(unitPriceLabel);
            this.splitContainer1.Panel1.Controls.Add(this.unitPriceTextBox);
            this.splitContainer1.Panel1.Controls.Add(qtyperUnitLabel);
            this.splitContainer1.Panel1.Controls.Add(this.qtyperUnitTextBox);
            this.splitContainer1.Panel1.Controls.Add(stockLabel);
            this.splitContainer1.Panel1.Controls.Add(this.stockTextBox);
            this.splitContainer1.Panel1.Controls.Add(discontinuedLabel);
            this.splitContainer1.Panel1.Controls.Add(this.discontinuedCheckBox);
            this.splitContainer1.Panel1.Controls.Add(category_IDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.category_IDComboBox);
            this.splitContainer1.Panel1.Controls.Add(brand_IDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.brand_IDComboBox);
            this.splitContainer1.Panel1.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel1.Controls.Add(this.descriptionTextBox);
            this.splitContainer1.Panel1.Controls.Add(lastReceiptDateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.lastReceiptDateDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(lastDeliveryDateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.lastDeliveryDateDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(startDateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.startDateDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(endDateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.endDateDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(commentLabel);
            this.splitContainer1.Panel1.Controls.Add(this.commentTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.productsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 691);
            this.splitContainer1.SplitterDistance = 408;
            this.splitContainer1.TabIndex = 3;
            // 
            // product_IDTextBox
            // 
            this.product_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductsBindingSource, "Product_ID", true));
            this.product_IDTextBox.Location = new System.Drawing.Point(200, 10);
            this.product_IDTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.product_IDTextBox.Name = "product_IDTextBox";
            this.product_IDTextBox.ReadOnly = true;
            this.product_IDTextBox.Size = new System.Drawing.Size(200, 34);
            this.product_IDTextBox.TabIndex = 1;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductsBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(200, 49);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.productNameTextBox.TabIndex = 3;
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductsBindingSource, "UnitPrice", true));
            this.unitPriceTextBox.Location = new System.Drawing.Point(200, 89);
            this.unitPriceTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(200, 34);
            this.unitPriceTextBox.TabIndex = 5;
            // 
            // qtyperUnitTextBox
            // 
            this.qtyperUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductsBindingSource, "QtyperUnit", true));
            this.qtyperUnitTextBox.Location = new System.Drawing.Point(200, 129);
            this.qtyperUnitTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.qtyperUnitTextBox.Name = "qtyperUnitTextBox";
            this.qtyperUnitTextBox.Size = new System.Drawing.Size(200, 34);
            this.qtyperUnitTextBox.TabIndex = 7;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductsBindingSource, "Stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(200, 169);
            this.stockTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(200, 34);
            this.stockTextBox.TabIndex = 9;
            // 
            // discontinuedCheckBox
            // 
            this.discontinuedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.ProductsBindingSource, "Discontinued", true));
            this.discontinuedCheckBox.Location = new System.Drawing.Point(200, 209);
            this.discontinuedCheckBox.Margin = new System.Windows.Forms.Padding(10);
            this.discontinuedCheckBox.Name = "discontinuedCheckBox";
            this.discontinuedCheckBox.Size = new System.Drawing.Size(200, 36);
            this.discontinuedCheckBox.TabIndex = 11;
            this.discontinuedCheckBox.Text = "銷售中";
            this.discontinuedCheckBox.UseVisualStyleBackColor = true;
            // 
            // category_IDComboBox
            // 
            this.category_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ProductsBindingSource, "Category_ID", true));
            this.category_IDComboBox.DataSource = this.CategoriesBindingSource;
            this.category_IDComboBox.DisplayMember = "CategoryName";
            this.category_IDComboBox.FormattingEnabled = true;
            this.category_IDComboBox.Location = new System.Drawing.Point(200, 245);
            this.category_IDComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.category_IDComboBox.Name = "category_IDComboBox";
            this.category_IDComboBox.Size = new System.Drawing.Size(200, 33);
            this.category_IDComboBox.TabIndex = 13;
            this.category_IDComboBox.ValueMember = "Category_ID";
            // 
            // brand_IDComboBox
            // 
            this.brand_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ProductsBindingSource, "Brand_ID", true));
            this.brand_IDComboBox.DataSource = this.BrandsBindingSource;
            this.brand_IDComboBox.DisplayMember = "BrandName";
            this.brand_IDComboBox.FormattingEnabled = true;
            this.brand_IDComboBox.Location = new System.Drawing.Point(200, 284);
            this.brand_IDComboBox.Margin = new System.Windows.Forms.Padding(10);
            this.brand_IDComboBox.Name = "brand_IDComboBox";
            this.brand_IDComboBox.Size = new System.Drawing.Size(200, 33);
            this.brand_IDComboBox.TabIndex = 15;
            this.brand_IDComboBox.ValueMember = "Brand_ID";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductsBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(200, 322);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 99);
            this.descriptionTextBox.TabIndex = 17;
            // 
            // lastReceiptDateDateTimePicker
            // 
            this.lastReceiptDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ProductsBindingSource, "LastReceiptDate", true));
            this.lastReceiptDateDateTimePicker.Enabled = false;
            this.lastReceiptDateDateTimePicker.Location = new System.Drawing.Point(200, 429);
            this.lastReceiptDateDateTimePicker.Margin = new System.Windows.Forms.Padding(10);
            this.lastReceiptDateDateTimePicker.Name = "lastReceiptDateDateTimePicker";
            this.lastReceiptDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.lastReceiptDateDateTimePicker.TabIndex = 19;
            // 
            // lastDeliveryDateDateTimePicker
            // 
            this.lastDeliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ProductsBindingSource, "LastDeliveryDate", true));
            this.lastDeliveryDateDateTimePicker.Enabled = false;
            this.lastDeliveryDateDateTimePicker.Location = new System.Drawing.Point(200, 469);
            this.lastDeliveryDateDateTimePicker.Margin = new System.Windows.Forms.Padding(10);
            this.lastDeliveryDateDateTimePicker.Name = "lastDeliveryDateDateTimePicker";
            this.lastDeliveryDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.lastDeliveryDateDateTimePicker.TabIndex = 21;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ProductsBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(200, 509);
            this.startDateDateTimePicker.Margin = new System.Windows.Forms.Padding(10);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.startDateDateTimePicker.TabIndex = 23;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ProductsBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(200, 549);
            this.endDateDateTimePicker.Margin = new System.Windows.Forms.Padding(10);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.endDateDateTimePicker.TabIndex = 25;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductsBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(200, 589);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(200, 99);
            this.commentTextBox.TabIndex = 27;
            // 
            // productsDataGridView
            // 
            this.productsDataGridView.AllowUserToAddRows = false;
            this.productsDataGridView.AllowUserToDeleteRows = false;
            this.productsDataGridView.AllowUserToOrderColumns = true;
            this.productsDataGridView.AutoGenerateColumns = false;
            this.productsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.productsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.productsDataGridView.DataSource = this.ProductsBindingSource;
            this.productsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.productsDataGridView.Name = "productsDataGridView";
            this.productsDataGridView.ReadOnly = true;
            this.productsDataGridView.RowTemplate.Height = 27;
            this.productsDataGridView.Size = new System.Drawing.Size(770, 691);
            this.productsDataGridView.TabIndex = 0;
            this.productsDataGridView.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Product_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "商品編號";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn2.HeaderText = "商品名稱";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn3.HeaderText = "單價";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "QtyperUnit";
            this.dataGridViewTextBoxColumn4.HeaderText = "包裝單位";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Stock";
            this.dataGridViewTextBoxColumn5.HeaderText = "庫存量";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Discontinued";
            this.dataGridViewCheckBoxColumn1.HeaderText = "銷售中";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            this.dataGridViewCheckBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Category_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "類別編號";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Brand_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "廠牌編號";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "商品敘述";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "LastReceiptDate";
            this.dataGridViewTextBoxColumn9.HeaderText = "最後進貨日";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 150;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LastDeliveryDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "最後出貨日";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "上架日";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 150;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "EndDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "下架日";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn13.HeaderText = "備註";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // exLabel1
            // 
            this.exLabel1.BackColor = System.Drawing.Color.Transparent;
            this.exLabel1.BackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(157)))));
            this.exLabel1.BackColorStart = System.Drawing.Color.Orange;
            this.exLabel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.exLabel1.Location = new System.Drawing.Point(14, 633);
            this.exLabel1.Name = "exLabel1";
            this.exLabel1.Size = new System.Drawing.Size(69, 18);
            this.exLabel1.TabIndex = 26;
            this.exLabel1.Text = "Demo";
            this.exLabel1.Click += new System.EventHandler(this.exLabel1_Click);
            // 
            // frmProductsCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(1182, 749);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "frmProductsCRUD";
            this.Text = "商品基本資料維護";
            this.Load += new System.EventHandler(this.frmProductsCRUD_Load);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrandsBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ProductsBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView productsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.TextBox product_IDTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox qtyperUnitTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.CheckBox discontinuedCheckBox;
        private System.Windows.Forms.ComboBox category_IDComboBox;
        private System.Windows.Forms.ComboBox brand_IDComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker lastReceiptDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker lastDeliveryDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.BindingSource CategoriesBindingSource;
        private System.Windows.Forms.BindingSource BrandsBindingSource;
        private ExControls.ExLabel exLabel1;

    }
}
