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
    
    public partial class F_Maskapai_Flightclass
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public F_Maskapai_Flightclass()
        {
            this.F_DetailBooking = new HashSet<F_DetailBooking>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Seat_available { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public Nullable<int> F_FlightclassID { get; set; }
        public Nullable<int> F_MaskapaiID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<F_DetailBooking> F_DetailBooking { get; set; }
        public virtual F_Flightclass F_Flightclass { get; set; }
        public virtual F_Maskapai F_Maskapai { get; set; }
    }
}
