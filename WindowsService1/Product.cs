//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsService1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public Product()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
    
        public int Product_ID { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public string QtyperUnit { get; set; }
        public int Stock { get; set; }
        public bool Discontinued { get; set; }
        public Nullable<int> Category_ID { get; set; }
        public Nullable<int> Brand_ID { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> LastReceiptDate { get; set; }
        public Nullable<System.DateTime> LastDeliveryDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string Comment { get; set; }
    
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
