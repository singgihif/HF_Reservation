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
    
    public partial class F_Coupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public F_Coupon()
        {
            this.F_DetailBooking = new HashSet<F_DetailBooking>();
            this.F_Maskapai = new HashSet<F_Maskapai>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> Date_start { get; set; }
        public Nullable<System.DateTime> Date_end { get; set; }
        public Nullable<int> Promo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<F_DetailBooking> F_DetailBooking { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<F_Maskapai> F_Maskapai { get; set; }
    }
}
