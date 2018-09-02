using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_HotelAndFlight.Model;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Data;

namespace WPF_HotelAndFlight.Controller
{
    class UserController
    {
        Flight_ReservationEntities1 context = new Flight_ReservationEntities1();
        // =========================================== LOGIN =============================================
        public bool login(string Username, string Password)
        {

            bool cek = false;
            SqlConnection con = new SqlConnection("Server=SINGGIHPRATAMA;Database=Flight_Reservation;Trusted_Connection=true");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from HF_User where Username='" + Username + "'  and Passwords='" + Password + "'", con);
            cmd.CommandType = CommandType.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count > 0)
            {
                cek = true;
            }
            else
            {
                cek = false;
            }
            return cek;
        }

        // =========================================== INSERT =============================================
        public void Insert(string data1, string data2, string data3, string data4, string data5, int data6)
        {
            HF_User call = new HF_User();
            {
                call.Name = data1;
                call.Username = data2;
                call.Email = data3;
                call.Location = data4;
                call.Passwords = data5;
                call.RoleID = data6;
            };
            try
            {
                context.HF_User.Add(call);
                var result = context.SaveChanges();
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }
        // =========================================== READ =============================================
        public List<HF_User> Read()
        {
            var getalls = context.HF_User.ToList();
            foreach (HF_User data in getalls)
            {
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
                System.Console.WriteLine("ID                : " + data.Id);
                System.Console.WriteLine("NAME              : " + data.Name);
                System.Console.WriteLine("USERNAME          : " + data.Username);
                System.Console.WriteLine("LOCATION          : " + data.Location);
                System.Console.WriteLine("EMAIL             : " + data.Email);
                System.Console.WriteLine("USER              : " + data.Role.Roles);
                System.Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
            }
            Console.ReadKey(true);
            return getalls;
        }
        // =========================================== UPDATE =============================================
        public HF_User GetById(int input)
        {
            var dataid = context.HF_User.Find(input);
            if (dataid == null)
            {
                System.Console.WriteLine("ID " + input + " NOT FOUND");
            }
            return dataid;
        }
        public int Update(int input)
        {
            System.Console.Write("NAME             : ");
            string field1 = System.Console.ReadLine();
            System.Console.Write("USERNAME         : ");
            string field2 = System.Console.ReadLine();
            System.Console.Write("LOCATION         : ");
            string field3 = System.Console.ReadLine();
            System.Console.Write("EMAIL         : ");
            string field4 = System.Console.ReadLine();
            System.Console.Write("LEVEL         : ");
            string field5 = System.Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("=============================================");
            System.Console.Write("PLEASE INPUT  ID : ");
            string id_dpt = System.Console.ReadLine();

            var getid = context.HF_User.Find(Convert.ToInt16(id_dpt));
            if (getid == null)
            {
                System.Console.Write("NOT FOUND ID " + id_dpt);
            }
            else
            {
                HF_User updatedata = GetById(input);
                updatedata.Name = field1;
                updatedata.Username = field2;
                updatedata.Location = field3;
                updatedata.Email = field4;
                updatedata.Passwords = field5;

                context.Entry(updatedata).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
            return input;
        }

        // =========================================== DELETE =============================================
        public void Delete(int input)
        {
            var x = (from y in context.HF_User where y.Id == input select y).FirstOrDefault();
            context.HF_User.Remove(x);
            context.SaveChanges();
        }
    }
}
