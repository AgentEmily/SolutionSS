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
    
    public partial class Categories
    {
        public Categories()
        {
            this.Categories1 = new HashSet<Categories>();
            this.Categories11 = new HashSet<Categories>();
            this.InsideShoppingList = new HashSet<InsideShoppingList>();
            this.OutsideShoppingList = new HashSet<OutsideShoppingList>();
            this.Products = new HashSet<Products>();
            this.RolesDetail = new HashSet<RolesDetail>();
        }
    
        public int Category_ID { get; set; }
        public string CategoryName { get; set; }
        public Nullable<int> PCategory_ID { get; set; }
        public int Source_ID { get; set; }
    
        public virtual ICollection<Categories> Categories1 { get; set; }
        public virtual Categories Categories2 { get; set; }
        public virtual ICollection<Categories> Categories11 { get; set; }
        public virtual Categories Categories3 { get; set; }
        public virtual Source Source { get; set; }
        public virtual ICollection<InsideShoppingList> InsideShoppingList { get; set; }
        public virtual ICollection<OutsideShoppingList> OutsideShoppingList { get; set; }
        public virtual ICollection<Products> Products { get; set; }
        public virtual ICollection<RolesDetail> RolesDetail { get; set; }
    }
}
