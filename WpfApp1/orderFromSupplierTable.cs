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
    
    public partial class orderFromSupplierTable
    {
        public int Id { get; set; }
        public Nullable<int> supplier_id { get; set; }
        public string shippingNumber { get; set; }
        public string receptionNumber { get; set; }
        public Nullable<int> employee_id { get; set; }
        public Nullable<int> orderFromSupplierDetail_id { get; set; }
        public Nullable<System.DateTime> orderDate { get; set; }
        public Nullable<System.DateTime> supplyingDate { get; set; }
        public string notes { get; set; }
        public Nullable<int> active { get; set; }
    
        public virtual EmployeeTable EmployeeTable { get; set; }
        public virtual orderFromSupplierDetailTable orderFromSupplierDetailTable { get; set; }
        public virtual supplierTable supplierTable { get; set; }
    }
}
