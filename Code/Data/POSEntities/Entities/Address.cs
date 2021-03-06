//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POSEntities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address : ModelBase
    {
        public Address()
        {
            this.People = new HashSet<Person>();
            this.Vendors = new HashSet<Vendor>();
        }
    
        public int ID { get; set; }
        public string StreetName { get; set; }
        public Nullable<int> StreetNumber { get; set; }
        public Nullable<int> HousNumber { get; set; }
        public string City { get; set; }
        public Nullable<int> Zip { get; set; }
    
        public virtual ICollection<Person> People { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
