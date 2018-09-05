using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_HotelAndFlight.Model;
using System.Data.Entity;

namespace WPF_HotelAndFlight.Controller
{
    class A_BookingdateController
    {
        Flight_ReservationEntities1 _context = new Flight_ReservationEntities1();

        public void InsertBookingDate(DateTime Tglbooking, int IdUser)
        {
            HF_Booking call = new HF_Booking();
            {
                call.Booking_date = Tglbooking;
                call.HF_CustomerID = IdUser;
            };
            try
            {
                _context.HF_Booking.Add(call);
                var result = _context.SaveChanges();

            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
    }
}
