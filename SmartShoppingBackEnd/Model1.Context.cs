﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SmartShoppingEntities2 : DbContext
    {
        public SmartShoppingEntities2()
            : base("name=SmartShoppingEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Brands> Brands { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<InsideShoppingList> InsideShoppingList { get; set; }
        public virtual DbSet<Member> Member { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OutsideShoppingList> OutsideShoppingList { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethod { get; set; }
        public virtual DbSet<ProductPicture> ProductPicture { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<promotion> promotion { get; set; }
        public virtual DbSet<PurchaseOrderDetail進貨明細> PurchaseOrderDetail進貨明細 { get; set; }
        public virtual DbSet<PurchaseOrder進貨單> PurchaseOrder進貨單 { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolesDetail> RolesDetail { get; set; }
        public virtual DbSet<ShipMethod> ShipMethod { get; set; }
        public virtual DbSet<SSBackEndProgram> SSBackEndProgram { get; set; }
        public virtual DbSet<SSBackEndUser> SSBackEndUser { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Status_PurchaseOrder> Status_PurchaseOrder { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Vendors> Vendors { get; set; }
        public virtual DbSet<回購週期> 回購週期 { get; set; }
        public virtual DbSet<回購週期設定紀錄> 回購週期設定紀錄 { get; set; }
        public virtual DbSet<商品評論> 商品評論 { get; set; }
        public virtual DbSet<設定來源> 設定來源 { get; set; }
        public virtual DbSet<Returns> Returns { get; set; }
        public virtual DbSet<Royalty> Royalty { get; set; }
        public virtual DbSet<Shipping> Shipping { get; set; }
    }
}