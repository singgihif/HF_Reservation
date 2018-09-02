using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_HotelAndFlight.Controller;

namespace WPF_HotelAndFlight
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            int menudefault;
        mdefault:
            Console.WriteLine("==================[ HOTEL ]==================");
            Console.WriteLine("||    1. CREATE      ||    3. UPDATE       ||");
            Console.WriteLine("||    2. READ        ||    4. DELETE       ||");
            Console.WriteLine("||                5. EXIT                  ||");
            Console.WriteLine("=============================================");
            Console.Write("Tentukan Pilihanmu : "); menudefault = Convert.ToInt32(Console.ReadLine());
            switch (menudefault)
            {
                case 1:
                    Program mc1 = new Program();
                    mc1.m1();
                    break;
                case 2:
                    Program mc2 = new Program();
                    mc2.m2();
                    break;
                case 3:
                    Program mc3 = new Program();
                    mc3.m3();
                    break;
                case 4:
                    Program mc4 = new Program();
                    mc4.m4();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto mdefault;
            }
            Console.ReadKey(true);
        }

        public void isimenu()
        {
            Console.WriteLine("||    1. USER        ||    4. CATEGORY     ||");
            Console.WriteLine("||    2. HOTEL       ||    5. SUBCATEGORY  ||");
            Console.WriteLine("||    3. TIPE HOTEL  ||    6. TICKET       ||");
            Console.WriteLine("||                7. EXIT                  ||");
            Console.WriteLine("=============================================");
        }
        public void m1()
        {
            int menu1;
        m1:
            Console.Clear();
            Console.WriteLine("================== CREATE ===================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu1 = Convert.ToInt32(Console.ReadLine());
            switch (menu1)
            {
                case 1:
                    A_HotelController panggilrole = new A_HotelController();
                    panggilrole.InsertHotel();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    goto m1;
                case 6:
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m1;
            }
            Console.ReadKey(true);
        }
        public void m2()
        {
            int menu2;
        m2:
            Console.Clear();
            Console.WriteLine("=================== READ ====================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu2 = Convert.ToInt32(Console.ReadLine());
            switch (menu2)
            {
                case 1:
                    A_HotelController panggilhotel = new A_HotelController();
                    panggilhotel.GetAllHotel();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 6:
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m2;
            }
            Console.ReadKey(true);
        }
        public void m3()
        {
            int menu3, input1, input2, input3, input4, input5;
        m3:
            Console.Clear();
            Console.WriteLine("================== UPDATE ===================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu3 = Convert.ToInt32(Console.ReadLine());
            switch (menu3)
            {
                case 1:
                    System.Console.Write("Masukkan Id yang ingin di ubah : ");
                    input1 = Convert.ToInt32(System.Console.ReadLine());
                    A_HotelController panggilhotel = new A_HotelController();
                    panggilhotel.UpdateHotel(input1);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 6:
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m3;
            }
            Console.ReadKey(true);
        }
        public void m4()
        {
            int menu4, input1, input2, input3, input4, input5;
        m4:
            Console.Clear();
            Console.WriteLine("================== DELETE ===================");
            isimenu();
            Console.Write("Tentukan Pilihanmu : "); menu4 = Convert.ToInt32(Console.ReadLine());
            switch (menu4)
            {
                case 1:
                    System.Console.Write("Masukkan Id yang ingin di hapus : ");
                    input1 = Convert.ToInt32(System.Console.ReadLine());
                    A_HotelController panggilrole = new A_HotelController();
                    panggilrole.DeleteHotel(input1);
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                
                case 6:
                    Console.WriteLine("=============================================");
                    Console.WriteLine("Sukses");
                    break;
                case 7:
                    Console.Clear();
                    Console.WriteLine("Press Any Key...");
                    break;
                default:
                    Console.WriteLine("Input Salah !!");
                    Console.WriteLine("\n");
                    goto m4;
            }
        } */
    }
}
