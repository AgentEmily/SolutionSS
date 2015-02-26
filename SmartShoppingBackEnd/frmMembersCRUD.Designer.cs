namespace SmartShoppingBackEnd
{
    partial class frmMembersCRUD
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
            System.Windows.Forms.Label memberNameLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label birthdateLabel;
            System.Windows.Forms.Label telPhoneLabel;
            System.Windows.Forms.Label mobilePhoneLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label deliveryAddressLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label m_PictureLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label member_IDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.exLabel1 = new ExControls.ExLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.member_IDTextBox = new System.Windows.Forms.TextBox();
            this.memberNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.birthdateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.telPhoneTextBox = new System.Windows.Forms.TextBox();
            this.mobilePhoneTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.m_PicturePictureBox = new System.Windows.Forms.PictureBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.membersdataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            memberNameLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            birthdateLabel = new System.Windows.Forms.Label();
            telPhoneLabel = new System.Windows.Forms.Label();
            mobilePhoneLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            deliveryAddressLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            m_PictureLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            member_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_PicturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // memberNameLabel
            // 
            memberNameLabel.AutoSize = true;
            memberNameLabel.Location = new System.Drawing.Point(12, 50);
            memberNameLabel.Margin = new System.Windows.Forms.Padding(10);
            memberNameLabel.Name = "memberNameLabel";
            memberNameLabel.Size = new System.Drawing.Size(97, 25);
            memberNameLabel.TabIndex = 2;
            memberNameLabel.Text = "會員姓名:";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(12, 90);
            usernameLabel.Margin = new System.Windows.Forms.Padding(10);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(97, 25);
            usernameLabel.TabIndex = 4;
            usernameLabel.Text = "會員帳號:";
            // 
            // birthdateLabel
            // 
            birthdateLabel.AutoSize = true;
            birthdateLabel.Location = new System.Drawing.Point(12, 130);
            birthdateLabel.Margin = new System.Windows.Forms.Padding(10);
            birthdateLabel.Name = "birthdateLabel";
            birthdateLabel.Size = new System.Drawing.Size(57, 25);
            birthdateLabel.TabIndex = 8;
            birthdateLabel.Text = "生日:";
            // 
            // telPhoneLabel
            // 
            telPhoneLabel.AutoSize = true;
            telPhoneLabel.Location = new System.Drawing.Point(12, 170);
            telPhoneLabel.Margin = new System.Windows.Forms.Padding(10);
            telPhoneLabel.Name = "telPhoneLabel";
            telPhoneLabel.Size = new System.Drawing.Size(57, 25);
            telPhoneLabel.TabIndex = 10;
            telPhoneLabel.Text = "電話:";
            // 
            // mobilePhoneLabel
            // 
            mobilePhoneLabel.AutoSize = true;
            mobilePhoneLabel.Location = new System.Drawing.Point(12, 210);
            mobilePhoneLabel.Margin = new System.Windows.Forms.Padding(10);
            mobilePhoneLabel.Name = "mobilePhoneLabel";
            mobilePhoneLabel.Size = new System.Drawing.Size(57, 25);
            mobilePhoneLabel.TabIndex = 12;
            mobilePhoneLabel.Text = "手機:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 250);
            addressLabel.Margin = new System.Windows.Forms.Padding(10);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(57, 25);
            addressLabel.TabIndex = 14;
            addressLabel.Text = "地址:";
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Location = new System.Drawing.Point(12, 290);
            deliveryAddressLabel.Margin = new System.Windows.Forms.Padding(10);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new System.Drawing.Size(97, 25);
            deliveryAddressLabel.TabIndex = 16;
            deliveryAddressLabel.Text = "貨運地址:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 330);
            emailLabel.Margin = new System.Windows.Forms.Padding(10);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(97, 25);
            emailLabel.TabIndex = 18;
            emailLabel.Text = "電子信箱:";
            // 
            // m_PictureLabel
            // 
            m_PictureLabel.AutoSize = true;
            m_PictureLabel.Location = new System.Drawing.Point(12, 370);
            m_PictureLabel.Margin = new System.Windows.Forms.Padding(10);
            m_PictureLabel.Name = "m_PictureLabel";
            m_PictureLabel.Size = new System.Drawing.Size(97, 25);
            m_PictureLabel.TabIndex = 20;
            m_PictureLabel.Text = "會員圖片:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(12, 526);
            commentLabel.Margin = new System.Windows.Forms.Padding(10);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(57, 25);
            commentLabel.TabIndex = 22;
            commentLabel.Text = "備註:";
            // 
            // member_IDLabel
            // 
            member_IDLabel.AutoSize = true;
            member_IDLabel.Location = new System.Drawing.Point(12, 10);
            member_IDLabel.Margin = new System.Windows.Forms.Padding(10);
            member_IDLabel.Name = "member_IDLabel";
            member_IDLabel.Size = new System.Drawing.Size(97, 25);
            member_IDLabel.TabIndex = 0;
            member_IDLabel.Text = "會員編號:";
            // 
            // MembersBindingSource
            // 
            this.MembersBindingSource.DataSource = typeof(SmartShoppingBackEnd.Members);
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
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(member_IDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.member_IDTextBox);
            this.splitContainer1.Panel1.Controls.Add(memberNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.memberNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(usernameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.usernameTextBox);
            this.splitContainer1.Panel1.Controls.Add(birthdateLabel);
            this.splitContainer1.Panel1.Controls.Add(this.birthdateDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(telPhoneLabel);
            this.splitContainer1.Panel1.Controls.Add(this.telPhoneTextBox);
            this.splitContainer1.Panel1.Controls.Add(mobilePhoneLabel);
            this.splitContainer1.Panel1.Controls.Add(this.mobilePhoneTextBox);
            this.splitContainer1.Panel1.Controls.Add(addressLabel);
            this.splitContainer1.Panel1.Controls.Add(this.addressTextBox);
            this.splitContainer1.Panel1.Controls.Add(deliveryAddressLabel);
            this.splitContainer1.Panel1.Controls.Add(this.deliveryAddressTextBox);
            this.splitContainer1.Panel1.Controls.Add(emailLabel);
            this.splitContainer1.Panel1.Controls.Add(this.emailTextBox);
            this.splitContainer1.Panel1.Controls.Add(m_PictureLabel);
            this.splitContainer1.Panel1.Controls.Add(this.m_PicturePictureBox);
            this.splitContainer1.Panel1.Controls.Add(commentLabel);
            this.splitContainer1.Panel1.Controls.Add(this.commentTextBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.membersdataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 691);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 3;
            // 
            // exLabel1
            // 
            this.exLabel1.BackColor = System.Drawing.Color.Transparent;
            this.exLabel1.BackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(206)))), ((int)(((byte)(157)))));
            this.exLabel1.BackColorStart = System.Drawing.Color.Orange;
            this.exLabel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.exLabel1.Location = new System.Drawing.Point(28, 584);
            this.exLabel1.Name = "exLabel1";
            this.exLabel1.Size = new System.Drawing.Size(69, 18);
            this.exLabel1.TabIndex = 25;
            this.exLabel1.Text = "Demo";
            this.exLabel1.Click += new System.EventHandler(this.exLabel1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 24;
            this.button1.Text = "選擇";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // member_IDTextBox
            // 
            this.member_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MembersBindingSource, "Member_ID", true));
            this.member_IDTextBox.Location = new System.Drawing.Point(192, 10);
            this.member_IDTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.member_IDTextBox.Name = "member_IDTextBox";
            this.member_IDTextBox.ReadOnly = true;
            this.member_IDTextBox.Size = new System.Drawing.Size(200, 34);
            this.member_IDTextBox.TabIndex = 1;
            // 
            // memberNameTextBox
            // 
            this.memberNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MembersBindingSource, "MemberName", true));
            this.memberNameTextBox.Location = new System.Drawing.Point(192, 50);
            this.memberNameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.memberNameTextBox.Name = "memberNameTextBox";
            this.memberNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.memberNameTextBox.TabIndex = 3;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MembersBindingSource, "Username", true));
            this.usernameTextBox.Location = new System.Drawing.Point(192, 90);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 34);
            this.usernameTextBox.TabIndex = 5;
            // 
            // birthdateDateTimePicker
            // 
            this.birthdateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.MembersBindingSource, "Birthdate", true));
            this.birthdateDateTimePicker.Location = new System.Drawing.Point(192, 130);
            this.birthdateDateTimePicker.Margin = new System.Windows.Forms.Padding(10);
            this.birthdateDateTimePicker.Name = "birthdateDateTimePicker";
            this.birthdateDateTimePicker.Size = new System.Drawing.Size(200, 34);
            this.birthdateDateTimePicker.TabIndex = 9;
            // 
            // telPhoneTextBox
            // 
            this.telPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MembersBindingSource, "TelPhone", true));
            this.telPhoneTextBox.Location = new System.Drawing.Point(192, 170);
            this.telPhoneTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.telPhoneTextBox.Name = "telPhoneTextBox";
            this.telPhoneTextBox.Size = new System.Drawing.Size(200, 34);
            this.telPhoneTextBox.TabIndex = 11;
            // 
            // mobilePhoneTextBox
            // 
            this.mobilePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MembersBindingSource, "MobilePhone", true));
            this.mobilePhoneTextBox.Location = new System.Drawing.Point(192, 210);
            this.mobilePhoneTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.mobilePhoneTextBox.Name = "mobilePhoneTextBox";
            this.mobilePhoneTextBox.Size = new System.Drawing.Size(200, 34);
            this.mobilePhoneTextBox.TabIndex = 13;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MembersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(192, 250);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 34);
            this.addressTextBox.TabIndex = 15;
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MembersBindingSource, "DeliveryAddress", true));
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(192, 290);
            this.deliveryAddressTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(200, 34);
            this.deliveryAddressTextBox.TabIndex = 17;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MembersBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(192, 330);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 34);
            this.emailTextBox.TabIndex = 19;
            // 
            // m_PicturePictureBox
            // 
            this.m_PicturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_PicturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.MembersBindingSource, "M_Picture", true));
            this.m_PicturePictureBox.Location = new System.Drawing.Point(192, 370);
            this.m_PicturePictureBox.Margin = new System.Windows.Forms.Padding(10);
            this.m_PicturePictureBox.Name = "m_PicturePictureBox";
            this.m_PicturePictureBox.Size = new System.Drawing.Size(200, 150);
            this.m_PicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_PicturePictureBox.TabIndex = 21;
            this.m_PicturePictureBox.TabStop = false;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MembersBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(192, 526);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(200, 150);
            this.commentTextBox.TabIndex = 23;
            // 
            // membersdataGridView
            // 
            this.membersdataGridView.AllowUserToAddRows = false;
            this.membersdataGridView.AllowUserToDeleteRows = false;
            this.membersdataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.membersdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.membersdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn14});
            this.membersdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.membersdataGridView.Location = new System.Drawing.Point(0, 0);
            this.membersdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.membersdataGridView.Name = "membersdataGridView";
            this.membersdataGridView.ReadOnly = true;
            this.membersdataGridView.Size = new System.Drawing.Size(778, 691);
            this.membersdataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Member_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "會員編號";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MemberName";
            this.dataGridViewTextBoxColumn2.HeaderText = "會員姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Username";
            this.dataGridViewTextBoxColumn3.HeaderText = "會員帳號";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Birthdate";
            this.dataGridViewTextBoxColumn7.HeaderText = "生日";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TelPhone";
            this.dataGridViewTextBoxColumn8.HeaderText = "電話";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MobilePhone";
            this.dataGridViewTextBoxColumn9.HeaderText = "手機";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn10.HeaderText = "地址";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DeliveryAddress";
            this.dataGridViewTextBoxColumn11.HeaderText = "貨運地址";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn12.HeaderText = "電子信箱";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "M_Picture";
            this.dataGridViewImageColumn1.HeaderText = "會員樸片";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn14.HeaderText = "備註";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmMembersCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(1182, 749);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimizeBox = false;
            this.Name = "frmMembersCRUD";
            this.Text = "會員基本資料維護";
            this.Load += new System.EventHandler(this.frmMembersCRUD_Load);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MembersBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_PicturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource MembersBindingSource;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView membersdataGridView;
        private System.Windows.Forms.TextBox memberNameTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.DateTimePicker birthdateDateTimePicker;
        private System.Windows.Forms.TextBox telPhoneTextBox;
        private System.Windows.Forms.TextBox mobilePhoneTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.PictureBox m_PicturePictureBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox member_IDTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private ExControls.ExLabel exLabel1;
    }
}
