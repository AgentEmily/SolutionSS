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
    
    public partial class promotion
    {
        public promotion()
        {
            this.Products = new HashSet<Products>();
        }
    
        public int Promotion_ID商品促銷編號 { get; set; }
        public string Description描述 { get; set; }
        public string Type類型 { get; set; }
        public Nullable<System.DateTime> StartDate起始日 { get; set; }
        public Nullable<System.DateTime> EndDate終止日 { get; set; }
    
        public virtual ICollection<Products> Products { get; set; }
    }
}