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
    
    public partial class orderDetailsTable
    {
        public int Id { get; set; }
        public Nullable<int> discount { get; set; }
        public Nullable<int> amount { get; set; }
        public string notes { get; set; }
        public Nullable<int> active { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string typeOfTree { get; set; }
        public string color { get; set; }
        public string shoeing { get; set; }
        public Nullable<int> cost { get; set; }
        public Nullable<int> costPrice { get; set; }
        public Nullable<int> orders_id { get; set; }
        public Nullable<int> costumers_id { get; set; }
    
        public virtual CostumersTable CostumersTable { get; set; }
        public virtual OrdersTable OrdersTable { get; set; }
    }
}
