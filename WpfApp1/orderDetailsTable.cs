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
        public orderDetailsTable()
        {
            this.OrdersTable = new HashSet<OrdersTable>();
        }
    
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
        public string cost { get; set; }
        public string costPrice { get; set; }
    
        public virtual ICollection<OrdersTable> OrdersTable { get; set; }
    }
}
