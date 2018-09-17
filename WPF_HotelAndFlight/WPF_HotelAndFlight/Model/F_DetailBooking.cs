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
    
    public partial class F_DetailBooking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public F_DetailBooking()
        {
            this.HF_Payment = new HashSet<HF_Payment>();
        }
    
        public int Id { get; set; }
        public Nullable<int> HF_BookingID { get; set; }
        public string Name { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public Nullable<System.DateTime> Date_flight { get; set; }
        public Nullable<int> Subtotal { get; set; }
        public Nullable<int> F_CouponID { get; set; }
        public Nullable<int> F_Maskapai_FlightclassID { get; set; }
        public string Status { get; set; }
    
        public virtual F_Coupon F_Coupon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HF_Payment> HF_Payment { get; set; }
        public virtual F_Maskapai_Flightclass F_Maskapai_Flightclass { get; set; }
    }
}
