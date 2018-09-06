using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_HotelAndFlight.Model;

namespace WPF_HotelAndFlight.Controller
{
    class A_Roomtype_FacilityController
    {
        Flight_ReservationEntities2 _context = new Flight_ReservationEntities2();

        public void InsertFasilitaskamar(int IdFasilitas, int IdKamar)
        {
            H_Roomtype_Facility call = new H_Roomtype_Facility();
            {
                call.H_FacilityID = IdFasilitas;
                call.H_RoomtypeID = IdKamar;
            };
            try
            {
                _context.H_Roomtype_Facility.Add(call);
                var result = _context.SaveChanges();

            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
    }
}
