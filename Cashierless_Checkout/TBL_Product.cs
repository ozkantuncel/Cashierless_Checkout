//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class TBL_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Product()
        {
            this.TBL_Barcode = new HashSet<TBL_Barcode>();
        }
    
        public short id { get; set; }
        public string productName { get; set; }
        public short producerID { get; set; }
        public byte categoryID { get; set; }
        public int price { get; set; }
        public int tax { get; set; }
    
        public virtual TBL_Category TBL_Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Barcode> TBL_Barcode { get; set; }
        public virtual TBL_Producter TBL_Producter { get; set; }
    }
}
