//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_HotelAndFlight.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class H_Facility
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public H_Facility()
        {
            this.H_Roomtype_Facility = new HashSet<H_Roomtype_Facility>();
        }
    
        public int Id { get; set; }
        public string Facllity_Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<H_Roomtype_Facility> H_Roomtype_Facility { get; set; }
    }
}
