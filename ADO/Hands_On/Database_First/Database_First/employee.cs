//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database_First
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public string gender { get; set; }
        public Nullable<double> salary { get; set; }
        public Nullable<int> dept_no { get; set; }
        public string phonenumber { get; set; }
    
        public virtual dept dept { get; set; }
        public virtual dept dept1 { get; set; }
    }
}
