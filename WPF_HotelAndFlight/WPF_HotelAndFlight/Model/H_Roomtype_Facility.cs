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
    
    public partial class H_Roomtype_Facility
    {
        public int Id { get; set; }
        public Nullable<int> H_FacilityID { get; set; }
        public Nullable<int> H_RoomtypeID { get; set; }
    
        public virtual H_Facility H_Facility { get; set; }
        public virtual H_Roomtype H_Roomtype { get; set; }
    }
}
