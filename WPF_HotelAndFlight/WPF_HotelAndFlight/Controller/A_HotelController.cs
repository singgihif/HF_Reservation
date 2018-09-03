using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF_HotelAndFlight.Model;

namespace WPF_HotelAndFlight.Controller
{
    class A_HotelController
    {
        Flight_ReservationEntities1 _context = new Flight_ReservationEntities1();
        private string v1;
        private string v2;

        // =========================================== INSERT =============================================
        public void InsertHotel(string Hotel_name, string Alamat_hotel, string  City, string Kecamatan, string Jalan, string phone, string email, string Manager)
        {
            H_Hotel call = new H_Hotel();
            {
                call.Hotel_Name = Hotel_name;
                call.Alamat = Alamat_hotel;
                call.Kota = City;
                call.Kecamatan = Kecamatan;
                call.Jalan = Jalan;
                call.Phone = phone;
                call.Email = email;
                call.Manager = Manager;
            };
            try
            {
                _context.H_Hotel.Add(call);
                var result = _context.SaveChanges();

            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }

        public void ViewHotel(string Hotel_name, string Alamat_hotel, string City, string Kecamatan, string Jalan, string phone, string email, string Manager)
        {


        }
        // =========================================== READ =============================================
        public List<H_Hotel> HotelGrid()
        {
            var getalls = _context.H_Hotel.ToList();
            foreach (H_Hotel user in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                : " + user.Id);
                System.Console.WriteLine("Alamat          : " + user.Alamat);
                System.Console.WriteLine("Kota             : " + user.Kota);
                System.Console.WriteLine("Kecamatan           : " + user.Kecamatan);
                System.Console.WriteLine("Jalan              : " + user.Jalan);
                System.Console.WriteLine("Phone             : " + user.Phone);
                System.Console.WriteLine("Email             : " + user.Email);
                System.Console.WriteLine("Manager              : " + user.Manager);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public H_Hotel GetById(int input)
        {
            var user = _context.H_Hotel.Find(input);
            if (user == null)
            {
                System.Console.WriteLine("Id tersebut tidak ada");
            }
            return user;
        }
        public int UpdateHotel(int input)
        {
            System.Console.Write("Nama Hotel      : ");
            string Hotel_name = System.Console.ReadLine();
            System.Console.Write("Alamat      : ");
            string Alamat_hotel = System.Console.ReadLine();
            System.Console.Write("Kota    : ");
            string City = System.Console.ReadLine();
            System.Console.Write("Kecamatan     : ");
            string Kecamatan = System.Console.ReadLine();
            System.Console.Write("Jalan       : ");
            string Jalan = System.Console.ReadLine();
            System.Console.Write("Phone         : ");
            string phone = System.Console.ReadLine();
            System.Console.Write("Email         : ");
            string email = System.Console.ReadLine();
            System.Console.Write("Manager         : ");
            string Manager = System.Console.ReadLine();
            int hotelid = Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("MASUKKAN ULANG ID          : ");
            string id_dpt = System.Console.ReadLine();

            var getmhs = _context.H_Hotel.Find(Convert.ToInt16(id_dpt));
            if (getmhs == null)
            {
                System.Console.Write("TIDAK ADA ID HOTEL : " + id_dpt);
            }
            else
            {
                H_Hotel call = GetById(input);
                call.Hotel_Name = Hotel_name;
                call.Alamat = Alamat_hotel;
                call.Kota = City;
                call.Kecamatan = Kecamatan;
                call.Jalan = Jalan;
                call.Phone = phone;
                call.Email = email;
                call.Manager = Manager;
                call.Id = hotelid;

                _context.Entry(call).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
            }
            return input;
        }
        // =========================================== DELETE =============================================
        public void DeleteHotel(int input)
        {
            var x = (from y in _context.H_Hotel where y.Id == input select y).FirstOrDefault();
            _context.H_Hotel.Remove(x);
            _context.SaveChanges();
        }
    }
}