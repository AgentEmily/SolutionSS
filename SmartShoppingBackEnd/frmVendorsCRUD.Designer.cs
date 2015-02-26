namespace SmartShoppingBackEnd
{
    partial class frmVendorsCRUD
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
            System.Windows.Forms.Label vendorNameLabel;
            System.Windows.Forms.Label unifiedBusinessNumberLabel;
            System.Windows.Forms.Label representativeLabel;
            System.Windows.Forms.Label telPhoneLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label mobilePhoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label deliveryAddressLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.vendor_IDLabel = new System.Windows.Forms.Label();
            this.lastDeliveryDateLabel = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lastDeliveryDatetextBox = new System.Windows.Forms.TextBox();
            this.VendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendor_IDTextBox = new System.Windows.Forms.TextBox();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.unifiedBusinessNumberTextBox = new System.Windows.Forms.TextBox();
            this.representativeTextBox = new System.Windows.Forms.TextBox();
            this.telPhoneTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.mobilePhoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.vendorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exLabel1 = new ExControls.ExLabel();
            vendorNameLabel = new System.Windows.Forms.Label();
            unifiedBusinessNumberLabel = new System.Windows.Forms.Label();
            representativeLabel = new System.Windows.Forms.Label();
            telPhoneLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            mobilePhoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            deliveryAddressLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VendorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Location = new System.Drawing.Point(12, 55);
            vendorNameLabel.Margin = new System.Windows.Forms.Padding(10);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(97, 25);
            vendorNameLabel.TabIndex = 0;
            vendorNameLabel.Text = "廠商名稱:";
            // 
            // unifiedBusinessNumberLabel
            // 
            unifiedBusinessNumberLabel.AutoSize = true;
            unifiedBusinessNumberLabel.Location = new System.Drawing.Point(12, 97);
            unifiedBusinessNumberLabel.Margin = new System.Windows.Forms.Padding(10);
            unifiedBusinessNumberLabel.Name = "unifiedBusinessNumberLabel";
            unifiedBusinessNumberLabel.Size = new System.Drawing.Size(97, 25);
            unifiedBusinessNumberLabel.TabIndex = 2;
            unifiedBusinessNumberLabel.Text = "統一編號:";
            // 
            // representativeLabel
            // 
            representativeLabel.AutoSize = true;
            representativeLabel.Location = new System.Drawing.Point(12, 137);
            representativeLabel.Margin = new System.Windows.Forms.Padding(10);
            representativeLabel.Name = "representativeLabel";
            representativeLabel.Size = new System.Drawing.Size(77, 25);
            representativeLabel.TabIndex = 4;
            representativeLabel.Text = "聯絡人:";
            // 
            // telPhoneLabel
            // 
            telPhoneLabel.AutoSize = true;
            telPhoneLabel.Location = new System.Drawing.Point(12, 177);
            telPhoneLabel.Margin = new System.Windows.Forms.Padding(10);
            telPhoneLabel.Name = "telPhoneLabel";
            telPhoneLabel.Size = new System.Drawing.Size(57, 25);
            telPhoneLabel.TabIndex = 6;
            telPhoneLabel.Text = "電話:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(12, 217);
            faxLabel.Margin = new System.Windows.Forms.Padding(10);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(57, 25);
            faxLabel.TabIndex = 8;
            faxLabel.Text = "傳真:";
            // 
            // mobilePhoneLabel
            // 
            mobilePhoneLabel.AutoSize = true;
            mobilePhoneLabel.Location = new System.Drawing.Point(12, 257);
            mobilePhoneLabel.Margin = new System.Windows.Forms.Padding(10);
            mobilePhoneLabel.Name = "mobilePhoneLabel";
            mobilePhoneLabel.Size = new System.Drawing.Size(57, 25);
            mobilePhoneLabel.TabIndex = 10;
            mobilePhoneLabel.Text = "手機:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 297);
            addressLabel.Margin = new System.Windows.Forms.Padding(10);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(57, 25);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "地址:";
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Location = new System.Drawing.Point(12, 337);
            deliveryAddressLabel.Margin = new System.Windows.Forms.Padding(10);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new System.Drawing.Size(97, 25);
            deliveryAddressLabel.TabIndex = 14;
            deliveryAddressLabel.Text = "發貨地址:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 377);
            emailLabel.Margin = new System.Windows.Forms.Padding(10);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(97, 25);
            emailLabel.TabIndex = 16;
            emailLabel.Text = "電子郵件:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(12, 462);
            commentLabel.Margin = new System.Windows.Forms.Padding(10);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(57, 25);
            commentLabel.TabIndex = 18;
            commentLabel.Text = "備註:";
            // 
            // vendor_IDLabel
            // 
            this.vendor_IDLabel.AutoSize = true;
            this.vendor_IDLabel.Location = new System.Drawing.Point(12, 10);
            this.vendor_IDLabel.Margin = new System.Windows.Forms.Padding(10);
            this.vendor_IDLabel.Name = "vendor_IDLabel";
            this.vendor_IDLabel.Size = new System.Drawing.Size(97, 25);
            this.vendor_IDLabel.TabIndex = 22;
            this.vendor_IDLabel.Text = "廠商編號:";
            // 
            // lastDeliveryDateLabel
            // 
            this.lastDeliveryDateLabel.AutoSize = true;
            this.lastDeliveryDateLabel.Location = new System.Drawing.Point(12, 419);
            this.lastDeliveryDateLabel.Margin = new System.Windows.Forms.Padding(10);
            this.lastDeliveryDateLabel.Name = "lastDeliveryDateLabel";
            this.lastDeliveryDateLabel.Size = new System.Drawing.Size(137, 25);
            this.lastDeliveryDateLabel.TabIndex = 24;
            this.lastDeliveryDateLabel.Text = "最後進貨日期:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 58);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.exLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.lastDeliveryDateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.lastDeliveryDatetextBox);
            this.splitContainer1.Panel1.Controls.Add(this.vendor_IDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.vendor_IDTextBox);
            this.splitContainer1.Panel1.Controls.Add(vendorNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.vendorNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(unifiedBusinessNumberLabel);
            this.splitContainer1.Panel1.Controls.Add(this.unifiedBusinessNumberTextBox);
            this.splitContainer1.Panel1.Controls.Add(representativeLabel);
            this.splitContainer1.Panel1.Controls.Add(this.representativeTextBox);
            this.splitContainer1.Panel1.Controls.Add(telPhoneLabel);
            this.splitContainer1.Panel1.Controls.Add(this.telPhoneTextBox);
            this.splitContainer1.Panel1.Controls.Add(faxLabel);
            this.splitContainer1.Panel1.Controls.Add(this.faxTextBox);
            this.splitContainer1.Panel1.Controls.Add(mobilePhoneLabel);
            this.splitContainer1.Panel1.Controls.Add(this.mobilePhoneTextBox);
            this.splitContainer1.Panel1.Controls.Add(addressLabel);
            this.splitContainer1.Panel1.Controls.Add(this.addressTextBox);
            this.splitContainer1.Panel1.Controls.Add(deliveryAddressLabel);
            this.splitContainer1.Panel1.Controls.Add(this.deliveryAddressTextBox);
            this.splitContainer1.Panel1.Controls.Add(emailLabel);
            this.splitContainer1.Panel1.Controls.Add(this.emailTextBox);
            this.splitContainer1.Panel1.Controls.Add(commentLabel);
            this.splitContainer1.Panel1.Controls.Add(this.commentTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.vendorsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 695);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.TabIndex = 3;
            // 
            // lastDeliveryDatetextBox
            // 
            this.lastDeliveryDatetextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VendorsBindingSource, "LastDeliveryDate", true));
            this.lastDeliveryDatetextBox.Location = new System.Drawing.Point(200, 419);
            this.lastDeliveryDatetextBox.Margin = new System.Windows.Forms.Padding(10);
            this.lastDeliveryDatetextBox.Name = "lastDeliveryDatetextBox";
            this.lastDeliveryDatetextBox.ReadOnly = true;
            this.lastDeliveryDatetextBox.Size = new System.Drawing.Size(200, 34);
            this.lastDeliveryDatetextBox.TabIndex = 25;
            // 
            // VendorsBindingSource
            // 
            this.VendorsBindingSource.DataSource = typeof(SmartShoppingBackEnd.Vendors);
            // 
            // vendor_IDTextBox
            // 
            this.vendor_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VendorsBindingSource, "Vendor_ID", true));
            this.vendor_IDTextBox.Location = new System.Drawing.Point(200, 10);
            this.vendor_IDTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.vendor_IDTextBox.Name = "vendor_IDTextBox";
            this.vendor_IDTextBox.ReadOnly = true;
            this.vendor_IDTextBox.Size = new System.Drawing.Size(200, 34);
            this.vendor_IDTextBox.TabIndex = 23;
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VendorsBindingSource, "VendorName", true));
            this.vendorNameTextBox.Location = new System.Drawing.Point(200, 55);
            this.vendorNameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.vendorNameTextBox.TabIndex = 1;
            // 
            // unifiedBusinessNumberTextBox
            // 
            this.unifiedBusinessNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VendorsBindingSource, "UnifiedBusinessNumber", true));
            this.unifiedBusinessNumberTextBox.Location = new System.Drawing.Point(200, 97);
            this.unifiedBusinessNumberTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.unifiedBusinessNumberTextBox.Name = "unifiedBusinessNumberTextBox";
            this.unifiedBusinessNumberTextBox.Size = new System.Drawing.Size(200, 34);
            this.unifiedBusinessNumberTextBox.TabIndex = 3;
            // 
            // representativeTextBox
            // 
            this.representativeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VendorsBindingSource, "Representative", true));
            this.representativeTextBox.Location = new System.Drawing.Point(200, 137);
            this.representativeTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.representativeTextBox.Name = "representativeTextBox";
            this.representativeTextBox.Size = new System.Drawing.Size(200, 34);
            this.representativeTextBox.TabIndex = 5;
            // 
            // telPhoneTextBox
            // 
            this.telPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VendorsBindingSource, "TelPhone", true));
            this.telPhoneTextBox.Location = new System.Drawing.Point(200, 177);
            this.telPhoneTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.telPhoneTextBox.Name = "telPhoneTextBox";
            this.telPhoneTextBox.Size = new System.Drawing.Size(200, 34);
            this.telPhoneTextBox.TabIndex = 7;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VendorsBindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(200, 217);
            this.faxTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(200, 34);
            this.faxTextBox.TabIndex = 9;
            // 
            // mobilePhoneTextBox
            // 
            this.mobilePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VendorsBindingSource, "MobilePhone", true));
            this.mobilePhoneTextBox.Location = new System.Drawing.Point(200, 257);
            this.mobilePhoneTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.mobilePhoneTextBox.Name = "mobilePhoneTextBox";
            this.mobilePhoneTextBox.Size = new System.Drawing.Size(200, 34);
            this.mobilePhoneTextBox.TabIndex = 11;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VendorsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(200, 297);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 34);
            this.addressTextBox.TabIndex = 13;
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VendorsBindingSource, "DeliveryAddress", true));
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(200, 337);
            this.deliveryAddressTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(200, 34);
            this.deliveryAddressTextBox.TabIndex = 15;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VendorsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(200, 377);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 34);
            this.emailTextBox.TabIndex = 17;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VendorsBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(200, 462);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(200, 150);
            this.commentTextBox.TabIndex = 19;
            // 
            // vendorsDataGridView
            // 
            this.vendorsDataGridView.AllowUserToAddRows = false;
            this.vendorsDataGridView.AllowUserToDeleteRows = false;
            this.vendorsDataGridView.AutoGenerateColumns = false;
            this.vendorsDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vendorsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vendorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.vendorsDataGridView.DataSource = this.VendorsBindingSource;
            this.vendorsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vendorsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.vendorsDataGridView.Name = "vendorsDataGridView";
            this.vendorsDataGridView.ReadOnly = true;
            this.vendorsDataGridView.RowTemplate.Height = 27;
            this.vendorsDataGridView.Size = new System.Drawing.Size(769, 695);
            this.vendorsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Vendor_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "廠商編號";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VendorName";
            this.dataGridViewTextBoxColumn2.HeaderText = "廠商名稱";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnifiedBusinessNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "統一編號";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Representative";
            this.dataGridViewTextBoxColumn4.HeaderText = "聯絡人";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TelPhone";
            this.dataGridViewTextBoxColumn5.HeaderText = "電話";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Fax";
            this.dataGridViewTextBoxColumn6.HeaderText = "傳真";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MobilePhone";
            this.dataGridViewTextBoxColumn7.HeaderText = "手機";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn8.HeaderText = "地址";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DeliveryAddress";
            this.dataGridViewTextBoxColumn9.HeaderText = "發貨地址";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn10.HeaderText = "電子郵件";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "LastDeliveryDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "最後進貨日期";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn12.HeaderText = "備註";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // exLabel1
            // 
            this.exLabel1.BackColor = System.Drawing.Color.Transparent;
            this.exLabel1.BackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(157)))));
            this.exLabel1.BackColorStart = System.Drawing.Color.Orange;
            this.exLabel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.exLabel1.Location = new System.Drawing.Point(20, 553);
            this.exLabel1.Name = "exLabel1";
            this.exLabel1.Size = new System.Drawing.Size(69, 18);
            this.exLabel1.TabIndex = 26;
            this.exLabel1.Text = "Demo";
            this.exLabel1.Click += new System.EventHandler(this.exLabel1_Click);
            // 
            // frmVendorsCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "frmVendorsCRUD";
            this.Text = "廠商基本資料維護";
            this.Load += new System.EventHandler(this.frmVendorsCRUD_Load);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VendorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView vendorsDataGridView;
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
        private System.Windows.Forms.BindingSource VendorsBindingSource;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox unifiedBusinessNumberTextBox;
        private System.Windows.Forms.TextBox representativeTextBox;
        private System.Windows.Forms.TextBox telPhoneTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox mobilePhoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox vendor_IDTextBox;
        private System.Windows.Forms.TextBox lastDeliveryDatetextBox;
        private System.Windows.Forms.Label vendor_IDLabel;
        private System.Windows.Forms.Label lastDeliveryDateLabel;
        private ExControls.ExLabel exLabel1;
    }
}
