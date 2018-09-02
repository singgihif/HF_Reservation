using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_HotelAndFlight.Controller;

namespace WPF_HotelAndFlight
{
    /// <summary>
    /// Interaction logic for HotelWindow.xaml
    /// </summary>
    public partial class HotelWindow : Window
    {

        public HotelWindow()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            A_HotelController controller = new A_HotelController();
            int HotelID = Convert.ToInt16(HotelId.Text);
            string Hotel_name = Nama_Hotel.Text;
            string Alamat_hotel = Alamat.Text;
            string City = Kota.Text;
            string Kecamatan = Kec.Text;
            string Jalan = Road.Text;
            string phone = Hp.Text;
            string Email = Emails.Text;
            string Manager = Managers.Text;
            controller.InsertHotel(HotelID, Hotel_name, Alamat_hotel, City, Kecamatan, Jalan, phone, Email, Manager);
            MessageBox.Show("Register Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
            MainWindow hasil = new MainWindow();
            hasil.ShowDialog();
        }
    }
}
