﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cashierless_Checkout.entity.old_sales
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CashierlessCheckoutOldSalesDBEntities : DbContext
    {
        public CashierlessCheckoutOldSalesDBEntities()
            : base("name=CashierlessCheckoutOldSalesDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_Sales_History> TBL_Sales_History { get; set; }
    }
}
