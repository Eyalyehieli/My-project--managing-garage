//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderFromSupplierDetailTable
    {
        public int Id { get; set; }
        public Nullable<int> amount { get; set; }
        public string notes { get; set; }
        public Nullable<int> active { get; set; }
        public string name { get; set; }
        public string materialType { get; set; }
        public Nullable<int> supplier_id { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<int> orderFromSupplier_id { get; set; }
    
        public virtual orderFromSupplierTable orderFromSupplierTable { get; set; }
        public virtual supplierTable supplierTable { get; set; }
    }
}
