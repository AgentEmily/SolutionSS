namespace SmartShoppingBackEnd
{
    partial class ServiceAutoMailing
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.smartShoppingDataSet1 = new WindowsService1.SmartShoppingDataSet();
            this.insideEmailListTableAdapter1 = new WindowsService1.SmartShoppingDataSetTableAdapters.InsideEmailListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartShoppingDataSet1)).BeginInit();
            // 
            // smartShoppingDataSet1
            // 
            this.smartShoppingDataSet1.DataSetName = "SmartShoppingDataSet";
            this.smartShoppingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // insideEmailListTableAdapter1
            // 
            this.insideEmailListTableAdapter1.ClearBeforeFill = true;
            // 
            // ServiceAutoMailing
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smartShoppingDataSet1)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private WindowsService1.SmartShoppingDataSet smartShoppingDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private WindowsService1.SmartShoppingDataSetTableAdapters.InsideEmailListTableAdapter insideEmailListTableAdapter1;
    }
}
