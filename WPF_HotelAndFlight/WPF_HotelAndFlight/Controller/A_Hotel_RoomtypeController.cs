using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_HotelAndFlight.Model;

namespace WPF_HotelAndFlight.Controller
{
    class A_Hotel_RoomtypeController
    {
        Flight_ReservationEntities1 _context = new Flight_ReservationEntities1();

        // =========================================== INSERT =============================================
        public void InsertTipeHotel(int Harga, int Stok, string Gambar, string Deskripsi, int RoomtypeID, int HotelID)
        {
            H_Hotel_Roomtype call = new H_Hotel_Roomtype();
            {
                call.Price = Harga;
                call.Available = Stok;
                call.Image = Gambar;
                call.Description = Deskripsi;
                call.H_RoomtypeID = RoomtypeID;
                call.H_HotelID = HotelID;
            };
            try
            {
                _context.H_Hotel_Roomtype.Add(call);
                var result = _context.SaveChanges();

            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }

        public void InsertTypehotel()
        {
            Console.Clear();
            System.Console.Write("Id Hotel      : ");
            int Id = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Tipe Kamar       : ");
            int Type = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Harga      : ");
            int Harga = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Jumlah Kamar     : ");
            int Stok = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Deskripsi       : ");
            string Deskripsi = System.Console.ReadLine();
            System.Console.Write("Gambar       : ");
            string Gambar = System.Console.ReadLine();
            int TypeHotelID = Convert.ToInt32(System.Console.ReadLine());

            H_Hotel_Roomtype call = new H_Hotel_Roomtype();
            {
                call.H_HotelID = Id;
                call.H_RoomtypeID = Type;
                call.Price = Harga;
                call.Available = Stok;
                call.Description = Deskripsi;
                call.Image = Gambar;
                call.Id = TypeHotelID;
            };
            try
            {
                _context.H_Hotel_Roomtype.Add(call);
                var result = _context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<H_Hotel_Roomtype> GetAllTypeHotel()
        {
            var getalls = _context.H_Hotel_Roomtype.ToList();
            foreach (H_Hotel_Roomtype user in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                : " + user.H_HotelID);
                System.Console.WriteLine("Username          : " + user.H_Roomtype);
                System.Console.WriteLine("Name              : " + user.Price);
                System.Console.WriteLine("Address           : " + user.Available);
                System.Console.WriteLine("City              : " + user.Description);
                System.Console.WriteLine("Phone             : " + user.Image);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public H_Hotel_Roomtype GetById(int input)
        {
            var user = _context.H_Hotel_Roomtype.Find(input);
            if (user == null)
            {
                System.Console.WriteLine("Id tersebut tidak ada");
            }
            return user;
        }
        public int UpdateTypeHotel(int input)
        {
            System.Console.Write("Id Hotel      : ");
            int Id = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Tipe Kamar       : ");
            int Type = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Harga      : ");
            int Harga = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Jumlah Kamar     : ");
            int Stok = Convert.ToInt32(System.Console.ReadLine());
            System.Console.Write("Deskripsi       : ");
            string Deskripsi = System.Console.ReadLine();
            System.Console.Write("Gambar       : ");
            string Gambar = System.Console.ReadLine();
            int TypeHotelID = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("MASUKKAN ULANG ID          : ");
            string id_dpt = System.Console.ReadLine();

            var getmhs = _context.H_Hotel_Roomtype.Find(Convert.ToInt16(id_dpt));
            if (getmhs == null)
            {
                System.Console.Write("TIDAK ADA ID : " + id_dpt);
            }
            else
            {
                H_Hotel_Roomtype call = GetById(input);
                call.H_HotelID = Id;
                call.H_RoomtypeID = Type;
                call.Price = Harga;
                call.Available = Stok;
                call.Description = Deskripsi;
                call.Image = Gambar;
                call.Id = TypeHotelID;

                _context.Entry(call).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void DeleteTypeHotel(int input)
        {
            var x = (from y in _context.H_Hotel_Roomtype where y.Id == input select y).FirstOrDefault();
            _context.H_Hotel_Roomtype.Remove(x);
            _context.SaveChanges();
        }
    }
}
