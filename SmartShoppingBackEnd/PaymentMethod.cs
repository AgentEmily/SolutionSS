//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartShoppingBackEnd
{
    using System;
    using System.Collections.Generic;
    
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            this.Orders = new HashSet<Orders>();
            this.PurchaseOrders = new HashSet<PurchaseOrders>();
        }
    
        public int PaymentMethod_ID { get; set; }
        public string PaymentMethod1 { get; set; }
    
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<PurchaseOrders> PurchaseOrders { get; set; }
    }
}
