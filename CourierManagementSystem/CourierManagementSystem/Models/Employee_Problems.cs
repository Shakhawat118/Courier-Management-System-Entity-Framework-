//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourierManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee_Problems
    {
        public System.DateTime UpdatedDate { get; set; }
        public int Id { get; set; }
        public int Branch_id { get; set; }
        public string Problem { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual User User { get; set; }
    }
}
