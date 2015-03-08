namespace SmartShoppingBackEnd
{
    partial class frmCategoriesCRUD
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
            System.Windows.Forms.Label category_IDLabel;
            System.Windows.Forms.Label categoryNameLabel;
            System.Windows.Forms.Label pCategory_IDLabel;
            System.Windows.Forms.Label source_IDLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.category_IDTextBox = new System.Windows.Forms.TextBox();
            this.CategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryNameTextBox = new System.Windows.Forms.TextBox();
            this.pCategory_IDComboBox = new System.Windows.Forms.ComboBox();
            this.PCategoriesbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.source_IDComboBox = new System.Windows.Forms.ComboBox();
            this.SourcebindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            category_IDLabel = new System.Windows.Forms.Label();
            categoryNameLabel = new System.Windows.Forms.Label();
            pCategory_IDLabel = new System.Windows.Forms.Label();
            source_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCategoriesbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourcebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // category_IDLabel
            // 
            category_IDLabel.AutoSize = true;
            category_IDLabel.Location = new System.Drawing.Point(12, 10);
            category_IDLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            category_IDLabel.Name = "category_IDLabel";
            category_IDLabel.Size = new System.Drawing.Size(97, 25);
            category_IDLabel.TabIndex = 0;
            category_IDLabel.Text = "類別編號:";
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new System.Drawing.Point(12, 52);
            categoryNameLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new System.Drawing.Size(97, 25);
            categoryNameLabel.TabIndex = 2;
            categoryNameLabel.Text = "類別名稱:";
            // 
            // pCategory_IDLabel
            // 
            pCategory_IDLabel.AutoSize = true;
            pCategory_IDLabel.Location = new System.Drawing.Point(12, 95);
            pCategory_IDLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            pCategory_IDLabel.Name = "pCategory_IDLabel";
            pCategory_IDLabel.Size = new System.Drawing.Size(97, 25);
            pCategory_IDLabel.TabIndex = 4;
            pCategory_IDLabel.Text = "所屬類別:";
            // 
            // source_IDLabel
            // 
            source_IDLabel.AutoSize = true;
            source_IDLabel.Location = new System.Drawing.Point(12, 138);
            source_IDLabel.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            source_IDLabel.Name = "source_IDLabel";
            source_IDLabel.Size = new System.Drawing.Size(97, 25);
            source_IDLabel.TabIndex = 6;
            source_IDLabel.Text = "設定來源:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 64);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(category_IDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.category_IDTextBox);
            this.splitContainer1.Panel1.Controls.Add(categoryNameLabel);
            this.splitContainer1.Panel1.Controls.Add(this.categoryNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(pCategory_IDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.pCategory_IDComboBox);
            this.splitContainer1.Panel1.Controls.Add(source_IDLabel);
            this.splitContainer1.Panel1.Controls.Add(this.source_IDComboBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.categoriesDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 685);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 3;
            // 
            // category_IDTextBox
            // 
            this.category_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CategoriesBindingSource, "Category_ID", true));
            this.category_IDTextBox.Location = new System.Drawing.Point(192, 10);
            this.category_IDTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.category_IDTextBox.Name = "category_IDTextBox";
            this.category_IDTextBox.ReadOnly = true;
            this.category_IDTextBox.Size = new System.Drawing.Size(200, 34);
            this.category_IDTextBox.TabIndex = 1;
            // 
            // CategoriesBindingSource
            // 
            this.CategoriesBindingSource.DataSource = typeof(SmartShoppingBackEnd.Categories);
            // 
            // categoryNameTextBox
            // 
            this.categoryNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CategoriesBindingSource, "CategoryName", true));
            this.categoryNameTextBox.Location = new System.Drawing.Point(192, 54);
            this.categoryNameTextBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.categoryNameTextBox.Name = "categoryNameTextBox";
            this.categoryNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.categoryNameTextBox.TabIndex = 3;
            // 
            // pCategory_IDComboBox
            // 
            this.pCategory_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CategoriesBindingSource, "PCategory_ID", true));
            this.pCategory_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CategoriesBindingSource, "PCategory_ID", true));
            this.pCategory_IDComboBox.DataSource = this.PCategoriesbindingSource;
            this.pCategory_IDComboBox.DisplayMember = "CategoryName";
            this.pCategory_IDComboBox.FormattingEnabled = true;
            this.pCategory_IDComboBox.Location = new System.Drawing.Point(192, 98);
            this.pCategory_IDComboBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.pCategory_IDComboBox.Name = "pCategory_IDComboBox";
            this.pCategory_IDComboBox.Size = new System.Drawing.Size(200, 33);
            this.pCategory_IDComboBox.TabIndex = 5;
            this.pCategory_IDComboBox.ValueMember = "Category_ID";
            // 
            // PCategoriesbindingSource
            // 
            this.PCategoriesbindingSource.DataSource = typeof(SmartShoppingBackEnd.Categories);
            // 
            // source_IDComboBox
            // 
            this.source_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CategoriesBindingSource, "Source_ID", true));
            this.source_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CategoriesBindingSource, "Source_ID", true));
            this.source_IDComboBox.DataSource = this.SourcebindingSource;
            this.source_IDComboBox.DisplayMember = "Source1";
            this.source_IDComboBox.Enabled = false;
            this.source_IDComboBox.FormattingEnabled = true;
            this.source_IDComboBox.Location = new System.Drawing.Point(192, 140);
            this.source_IDComboBox.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.source_IDComboBox.Name = "source_IDComboBox";
            this.source_IDComboBox.Size = new System.Drawing.Size(200, 33);
            this.source_IDComboBox.TabIndex = 7;
            this.source_IDComboBox.ValueMember = "Source_ID";
            // 
            // SourcebindingSource
            // 
            this.SourcebindingSource.DataSource = typeof(SmartShoppingBackEnd.Source);
            // 
            // categoriesDataGridView
            // 
            this.categoriesDataGridView.AllowUserToAddRows = false;
            this.categoriesDataGridView.AllowUserToDeleteRows = false;
            this.categoriesDataGridView.AutoGenerateColumns = false;
            this.categoriesDataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.categoriesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.categoriesDataGridView.DataSource = this.CategoriesBindingSource;
            this.categoriesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.categoriesDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.categoriesDataGridView.Name = "categoriesDataGridView";
            this.categoriesDataGridView.ReadOnly = true;
            this.categoriesDataGridView.RowTemplate.Height = 27;
            this.categoriesDataGridView.Size = new System.Drawing.Size(778, 685);
            this.categoriesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Category_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "類別編號";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "類別名稱";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PCategory_ID";
            this.dataGridViewTextBoxColumn3.HeaderText = "所屬類別";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Source_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "設定來源";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // frmCategoriesCRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(1182, 749);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCategoriesCRUD";
            this.Text = "類別管理";
            this.Load += new System.EventHandler(this.frmCategoriesCRUD_Load);
            this.Controls.SetChildIndex(this.splitContainer1, 0);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCategoriesbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SourcebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource CategoriesBindingSource;
        private System.Windows.Forms.DataGridView categoriesDataGridView;
        private System.Windows.Forms.TextBox category_IDTextBox;
        private System.Windows.Forms.TextBox categoryNameTextBox;
        private System.Windows.Forms.ComboBox pCategory_IDComboBox;
        private System.Windows.Forms.ComboBox source_IDComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource PCategoriesbindingSource;
        private System.Windows.Forms.BindingSource SourcebindingSource;
    }
}