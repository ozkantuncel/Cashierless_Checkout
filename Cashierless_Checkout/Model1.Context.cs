﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cashierless_Checkout
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CashierlessCheckoutProductEntities : DbContext
    {
        public CashierlessCheckoutProductEntities()
            : base("name=CashierlessCheckoutProductEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_Category> TBL_Category { get; set; }
        public virtual DbSet<TBL_Product> TBL_Product { get; set; }
        public virtual DbSet<TBL_Producter> TBL_Producter { get; set; }
        public virtual DbSet<TBL_Barcode> TBL_Barcode { get; set; }
    }
}
