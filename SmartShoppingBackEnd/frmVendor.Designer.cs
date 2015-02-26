namespace SmartShoppingBackEnd
{
    partial class frmVendor
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
            System.Windows.Forms.Label paymentMethod_IDLabel;
            System.Windows.Forms.Label representativeLabel;
            System.Windows.Forms.Label unifiedBusinessNumbeLabel;
            System.Windows.Forms.Label vendor_IDLabel;
            System.Windows.Forms.Label vendorAddressLabel;
            System.Windows.Forms.Label vendorEmailLabel;
            System.Windows.Forms.Label vendorNameLabel;
            System.Windows.Forms.Label vendorPhoneLabel;
            System.Windows.Forms.Label paymentMethod_ID付款方式編號Label;
            System.Windows.Forms.Label paymentMethod付款方式Label;
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vendorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentMethod_IDTextBox = new System.Windows.Forms.TextBox();
            this.representativeTextBox = new System.Windows.Forms.TextBox();
            this.unifiedBusinessNumbeTextBox = new System.Windows.Forms.TextBox();
            this.vendor_IDTextBox = new System.Windows.Forms.TextBox();
            this.vendorAddressTextBox = new System.Windows.Forms.TextBox();
            this.vendorEmailTextBox = new System.Windows.Forms.TextBox();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.vendorPhoneTextBox = new System.Windows.Forms.TextBox();
            this.paymentMethod_ID付款方式編號TextBox = new System.Windows.Forms.TextBox();
            this.paymentMethod付款方式TextBox = new System.Windows.Forms.TextBox();
            paymentMethod_IDLabel = new System.Windows.Forms.Label();
            representativeLabel = new System.Windows.Forms.Label();
            unifiedBusinessNumbeLabel = new System.Windows.Forms.Label();
            vendor_IDLabel = new System.Windows.Forms.Label();
            vendorAddressLabel = new System.Windows.Forms.Label();
            vendorEmailLabel = new System.Windows.Forms.Label();
            vendorNameLabel = new System.Windows.Forms.Label();
            vendorPhoneLabel = new System.Windows.Forms.Label();
            paymentMethod_ID付款方式編號Label = new System.Windows.Forms.Label();
            paymentMethod付款方式Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 53);
            this.button1.TabIndex = 17;
            this.button1.Text = "查詢進貨紀錄";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(462, 377);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 34;
            // 
            // vendorsBindingSource
            // 
            this.vendorsBindingSource.DataSource = typeof(SmartShoppingBackEnd.Vendors);
            // 
            // paymentMethod_IDLabel
            // 
            paymentMethod_IDLabel.AutoSize = true;
            paymentMethod_IDLabel.Location = new System.Drawing.Point(12, 63);
            paymentMethod_IDLabel.Name = "paymentMethod_IDLabel";
            paymentMethod_IDLabel.Size = new System.Drawing.Size(152, 18);
            paymentMethod_IDLabel.TabIndex = 34;
            paymentMethod_IDLabel.Text = "Payment Method ID:";
            // 
            // paymentMethod_IDTextBox
            // 
            this.paymentMethod_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "PaymentMethod_ID", true));
            this.paymentMethod_IDTextBox.Location = new System.Drawing.Point(203, 60);
            this.paymentMethod_IDTextBox.Name = "paymentMethod_IDTextBox";
            this.paymentMethod_IDTextBox.Size = new System.Drawing.Size(100, 29);
            this.paymentMethod_IDTextBox.TabIndex = 35;
            // 
            // representativeLabel
            // 
            representativeLabel.AutoSize = true;
            representativeLabel.Location = new System.Drawing.Point(12, 98);
            representativeLabel.Name = "representativeLabel";
            representativeLabel.Size = new System.Drawing.Size(116, 18);
            representativeLabel.TabIndex = 36;
            representativeLabel.Text = "Representative:";
            // 
            // representativeTextBox
            // 
            this.representativeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Representative", true));
            this.representativeTextBox.Location = new System.Drawing.Point(203, 95);
            this.representativeTextBox.Name = "representativeTextBox";
            this.representativeTextBox.Size = new System.Drawing.Size(100, 29);
            this.representativeTextBox.TabIndex = 37;
            // 
            // unifiedBusinessNumbeLabel
            // 
            unifiedBusinessNumbeLabel.AutoSize = true;
            unifiedBusinessNumbeLabel.Location = new System.Drawing.Point(12, 133);
            unifiedBusinessNumbeLabel.Name = "unifiedBusinessNumbeLabel";
            unifiedBusinessNumbeLabel.Size = new System.Drawing.Size(185, 18);
            unifiedBusinessNumbeLabel.TabIndex = 38;
            unifiedBusinessNumbeLabel.Text = "Unified Business Numbe:";
            // 
            // unifiedBusinessNumbeTextBox
            // 
            this.unifiedBusinessNumbeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "UnifiedBusinessNumbe", true));
            this.unifiedBusinessNumbeTextBox.Location = new System.Drawing.Point(203, 130);
            this.unifiedBusinessNumbeTextBox.Name = "unifiedBusinessNumbeTextBox";
            this.unifiedBusinessNumbeTextBox.Size = new System.Drawing.Size(100, 29);
            this.unifiedBusinessNumbeTextBox.TabIndex = 39;
            // 
            // vendor_IDLabel
            // 
            vendor_IDLabel.AutoSize = true;
            vendor_IDLabel.Location = new System.Drawing.Point(12, 168);
            vendor_IDLabel.Name = "vendor_IDLabel";
            vendor_IDLabel.Size = new System.Drawing.Size(86, 18);
            vendor_IDLabel.TabIndex = 40;
            vendor_IDLabel.Text = "Vendor ID:";
            // 
            // vendor_IDTextBox
            // 
            this.vendor_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "Vendor_ID", true));
            this.vendor_IDTextBox.Location = new System.Drawing.Point(203, 165);
            this.vendor_IDTextBox.Name = "vendor_IDTextBox";
            this.vendor_IDTextBox.Size = new System.Drawing.Size(100, 29);
            this.vendor_IDTextBox.TabIndex = 41;
            // 
            // vendorAddressLabel
            // 
            vendorAddressLabel.AutoSize = true;
            vendorAddressLabel.Location = new System.Drawing.Point(12, 203);
            vendorAddressLabel.Name = "vendorAddressLabel";
            vendorAddressLabel.Size = new System.Drawing.Size(124, 18);
            vendorAddressLabel.TabIndex = 42;
            vendorAddressLabel.Text = "Vendor Address:";
            // 
            // vendorAddressTextBox
            // 
            this.vendorAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorAddress", true));
            this.vendorAddressTextBox.Location = new System.Drawing.Point(203, 200);
            this.vendorAddressTextBox.Name = "vendorAddressTextBox";
            this.vendorAddressTextBox.Size = new System.Drawing.Size(100, 29);
            this.vendorAddressTextBox.TabIndex = 43;
            // 
            // vendorEmailLabel
            // 
            vendorEmailLabel.AutoSize = true;
            vendorEmailLabel.Location = new System.Drawing.Point(12, 238);
            vendorEmailLabel.Name = "vendorEmailLabel";
            vendorEmailLabel.Size = new System.Drawing.Size(109, 18);
            vendorEmailLabel.TabIndex = 44;
            vendorEmailLabel.Text = "Vendor Email:";
            // 
            // vendorEmailTextBox
            // 
            this.vendorEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorEmail", true));
            this.vendorEmailTextBox.Location = new System.Drawing.Point(203, 235);
            this.vendorEmailTextBox.Name = "vendorEmailTextBox";
            this.vendorEmailTextBox.Size = new System.Drawing.Size(100, 29);
            this.vendorEmailTextBox.TabIndex = 45;
            // 
            // vendorNameLabel
            // 
            vendorNameLabel.AutoSize = true;
            vendorNameLabel.Location = new System.Drawing.Point(12, 273);
            vendorNameLabel.Name = "vendorNameLabel";
            vendorNameLabel.Size = new System.Drawing.Size(109, 18);
            vendorNameLabel.TabIndex = 46;
            vendorNameLabel.Text = "Vendor Name:";
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorName", true));
            this.vendorNameTextBox.Location = new System.Drawing.Point(203, 270);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(100, 29);
            this.vendorNameTextBox.TabIndex = 47;
            // 
            // vendorPhoneLabel
            // 
            vendorPhoneLabel.AutoSize = true;
            vendorPhoneLabel.Location = new System.Drawing.Point(12, 308);
            vendorPhoneLabel.Name = "vendorPhoneLabel";
            vendorPhoneLabel.Size = new System.Drawing.Size(109, 18);
            vendorPhoneLabel.TabIndex = 48;
            vendorPhoneLabel.Text = "Vendor Phone:";
            // 
            // vendorPhoneTextBox
            // 
            this.vendorPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "VendorPhone", true));
            this.vendorPhoneTextBox.Location = new System.Drawing.Point(203, 305);
            this.vendorPhoneTextBox.Name = "vendorPhoneTextBox";
            this.vendorPhoneTextBox.Size = new System.Drawing.Size(100, 29);
            this.vendorPhoneTextBox.TabIndex = 49;
            // 
            // paymentMethod_ID付款方式編號Label
            // 
            paymentMethod_ID付款方式編號Label.AutoSize = true;
            paymentMethod_ID付款方式編號Label.Location = new System.Drawing.Point(12, 377);
            paymentMethod_ID付款方式編號Label.Name = "paymentMethod_ID付款方式編號Label";
            paymentMethod_ID付款方式編號Label.Size = new System.Drawing.Size(260, 18);
            paymentMethod_ID付款方式編號Label.TabIndex = 49;
            paymentMethod_ID付款方式編號Label.Text = "Payment Method ID付款方式編號:";
            // 
            // paymentMethod_ID付款方式編號TextBox
            // 
            this.paymentMethod_ID付款方式編號TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "PaymentMethod.PaymentMethod_ID付款方式編號", true));
            this.paymentMethod_ID付款方式編號TextBox.Location = new System.Drawing.Point(278, 374);
            this.paymentMethod_ID付款方式編號TextBox.Name = "paymentMethod_ID付款方式編號TextBox";
            this.paymentMethod_ID付款方式編號TextBox.Size = new System.Drawing.Size(100, 29);
            this.paymentMethod_ID付款方式編號TextBox.TabIndex = 50;
            // 
            // paymentMethod付款方式Label
            // 
            paymentMethod付款方式Label.AutoSize = true;
            paymentMethod付款方式Label.Location = new System.Drawing.Point(12, 412);
            paymentMethod付款方式Label.Name = "paymentMethod付款方式Label";
            paymentMethod付款方式Label.Size = new System.Drawing.Size(201, 18);
            paymentMethod付款方式Label.TabIndex = 51;
            paymentMethod付款方式Label.Text = "Payment Method付款方式:";
            // 
            // paymentMethod付款方式TextBox
            // 
            this.paymentMethod付款方式TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorsBindingSource, "PaymentMethod.PaymentMethod付款方式", true));
            this.paymentMethod付款方式TextBox.Location = new System.Drawing.Point(278, 409);
            this.paymentMethod付款方式TextBox.Name = "paymentMethod付款方式TextBox";
            this.paymentMethod付款方式TextBox.Size = new System.Drawing.Size(100, 29);
            this.paymentMethod付款方式TextBox.TabIndex = 52;
            // 
            // frmVendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.ClientSize = new System.Drawing.Size(1020, 696);
            this.Controls.Add(paymentMethod_ID付款方式編號Label);
            this.Controls.Add(this.paymentMethod_ID付款方式編號TextBox);
            this.Controls.Add(paymentMethod付款方式Label);
            this.Controls.Add(this.paymentMethod付款方式TextBox);
            this.Controls.Add(paymentMethod_IDLabel);
            this.Controls.Add(this.paymentMethod_IDTextBox);
            this.Controls.Add(representativeLabel);
            this.Controls.Add(this.representativeTextBox);
            this.Controls.Add(unifiedBusinessNumbeLabel);
            this.Controls.Add(this.unifiedBusinessNumbeTextBox);
            this.Controls.Add(vendor_IDLabel);
            this.Controls.Add(this.vendor_IDTextBox);
            this.Controls.Add(vendorAddressLabel);
            this.Controls.Add(this.vendorAddressTextBox);
            this.Controls.Add(vendorEmailLabel);
            this.Controls.Add(this.vendorEmailTextBox);
            this.Controls.Add(vendorNameLabel);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(vendorPhoneLabel);
            this.Controls.Add(this.vendorPhoneTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendor";
            this.Load += new System.EventHandler(this.frmVendor_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.vendorPhoneTextBox, 0);
            this.Controls.SetChildIndex(vendorPhoneLabel, 0);
            this.Controls.SetChildIndex(this.vendorNameTextBox, 0);
            this.Controls.SetChildIndex(vendorNameLabel, 0);
            this.Controls.SetChildIndex(this.vendorEmailTextBox, 0);
            this.Controls.SetChildIndex(vendorEmailLabel, 0);
            this.Controls.SetChildIndex(this.vendorAddressTextBox, 0);
            this.Controls.SetChildIndex(vendorAddressLabel, 0);
            this.Controls.SetChildIndex(this.vendor_IDTextBox, 0);
            this.Controls.SetChildIndex(vendor_IDLabel, 0);
            this.Controls.SetChildIndex(this.unifiedBusinessNumbeTextBox, 0);
            this.Controls.SetChildIndex(unifiedBusinessNumbeLabel, 0);
            this.Controls.SetChildIndex(this.representativeTextBox, 0);
            this.Controls.SetChildIndex(representativeLabel, 0);
            this.Controls.SetChildIndex(this.paymentMethod_IDTextBox, 0);
            this.Controls.SetChildIndex(paymentMethod_IDLabel, 0);
            this.Controls.SetChildIndex(this.paymentMethod付款方式TextBox, 0);
            this.Controls.SetChildIndex(paymentMethod付款方式Label, 0);
            this.Controls.SetChildIndex(this.paymentMethod_ID付款方式編號TextBox, 0);
            this.Controls.SetChildIndex(paymentMethod_ID付款方式編號Label, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vendorsBindingSource;
        private System.Windows.Forms.TextBox paymentMethod_IDTextBox;
        private System.Windows.Forms.TextBox representativeTextBox;
        private System.Windows.Forms.TextBox unifiedBusinessNumbeTextBox;
        private System.Windows.Forms.TextBox vendor_IDTextBox;
        private System.Windows.Forms.TextBox vendorAddressTextBox;
        private System.Windows.Forms.TextBox vendorEmailTextBox;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.TextBox vendorPhoneTextBox;
        private System.Windows.Forms.TextBox paymentMethod_ID付款方式編號TextBox;
        private System.Windows.Forms.TextBox paymentMethod付款方式TextBox;
    }
}
