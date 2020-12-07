using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourierManagementSystem.Models
{
    public class EmployeeMetaData
    {
        [Required,StringLength(20)]
        public string Name { get; set; }
        public Nullable<System.DateTime> Joining_date { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<double> Salary { get; set; }
        public Nullable<double> Bonus { get; set; }
        [Required]
        public string Contact { get; set; }
        [Required]
        public string Address { get; set; }
        public Nullable<int> Designation { get; set; }
        public Nullable<int> Branch_id { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public int Id { get; set; }
        [Required]
        public string Blood_Group { get; set; }
        [Required]
        public string Qualification { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products1 { get; set; }
    }
}