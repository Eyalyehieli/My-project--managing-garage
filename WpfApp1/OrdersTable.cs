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
    
    public partial class OrdersTable
    {
        public int Id { get; set; }
        public Nullable<int> costumer_id { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<int> costPrice { get; set; }
        public string invoiceNumber { get; set; }
        public Nullable<int> product_id { get; set; }
    
        public virtual CostumersTable CostumersTable { get; set; }
        public virtual ProductTable ProductTable { get; set; }
    }
}
