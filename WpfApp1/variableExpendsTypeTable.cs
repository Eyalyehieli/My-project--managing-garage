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
    
    public partial class variableExpendsTypeTable
    {
        public variableExpendsTypeTable()
        {
            this.variableExpendsTable = new HashSet<variableExpendsTable>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public Nullable<int> cost { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string notes { get; set; }
        public Nullable<int> active { get; set; }
    
        public virtual ICollection<variableExpendsTable> variableExpendsTable { get; set; }
    }
}
