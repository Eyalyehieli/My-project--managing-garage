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
    
    public partial class EmployeeTable
    {
        public EmployeeTable()
        {
            this.ExpensesTable = new HashSet<ExpensesTable>();
            this.OrdersTable = new HashSet<OrdersTable>();
        }
    
        public int Id { get; set; }
        public string first_Name { get; set; }
        public string last_Name { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string E_mail { get; set; }
        public string notes { get; set; }
        public Nullable<int> active { get; set; }
        public Nullable<int> salary { get; set; }
    
        public virtual ICollection<ExpensesTable> ExpensesTable { get; set; }
        public virtual ICollection<OrdersTable> OrdersTable { get; set; }
    }
}
