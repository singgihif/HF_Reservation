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
    
    public partial class HF_Payment
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> Booking_date { get; set; }
        public Nullable<int> HF_CustomerID { get; set; }
        public Nullable<int> HotelbookingID { get; set; }
        public Nullable<int> FlightbookingID { get; set; }
        public Nullable<System.DateTime> Duedate { get; set; }
        public Nullable<int> Total { get; set; }
    
        public virtual F_DetailBooking F_DetailBooking { get; set; }
        public virtual H_Detailbooking H_Detailbooking { get; set; }
        public virtual HF_User HF_User { get; set; }
    }
}
