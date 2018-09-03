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
using System.Data;
using WPF_HotelAndFlight.Model;

namespace WPF_HotelAndFlight
{
    /// <summary>
    /// Interaction logic for HotelWindow.xaml
    /// </summary>
    public partial class HotelWindow : Window
    {
        Flight_ReservationEntities1 _context = new Flight_ReservationEntities1();
        public HotelWindow()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            A_HotelController contr = new A_HotelController();
            string Hotel_name = Nama_Hotel.Text;
            string Alamat_hotel = Alamat.Text;
            string City = Kota.Text;
            string Kecamatan = Kec.Text;
            string Jalan = Road.Text;
            string phone = Hp.Text;
            string Email = Emails.Text;
            string Manager = Managers.Text;
            contr.InsertHotel(Hotel_name, Alamat_hotel, City, Kecamatan, Jalan, phone, Email, Manager);
            MessageBox.Show("Register Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
            HotelWindow hasil = new HotelWindow();
            hasil.ShowDialog();
        }

        private void viewHotelGrid(DataGrid DG)
        {
            DG.ItemsSource = _context.H_Hotel.OrderBy(x => x.Id).ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            viewHotelGrid(HotelGrid);
        }
    }
}
