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
using System.Data.Entity.Validation;
using System.Data.SqlClient;

namespace WPF_HotelAndFlight
{
    /// <summary>
    /// Interaction logic for HotelWindow.xaml
    /// </summary>
    public partial class HotelWindow : Window
    {
        Flight_ReservationEntities5 _context = new Flight_ReservationEntities5();
        public HotelWindow()
        {
            InitializeComponent();
            viewFkamarGrid(FkamarGrid);

        }

        #region Cleartext
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            viewCustomerGrid(CustomerGrid);
            viewHotelGrid(HotelGrid);
            LoadIdComboBox();
            viewFkamarGrid(FkamarGrid);
            LoadIdTRComboBox();
            viewHotelTypeGrid(TypeHotelGrid);
            LoadIduser();
            LoadIdrole();

            Provinsibox.DisplayMemberPath = "name";
            Provinsibox.SelectedValuePath = "id";
            Provinsibox.ItemsSource = _context.provinces.ToList();
            
        }

        private void clearhotel()
        {
            Nama_Hotel.Text = "";
            Kecamatanbox.Text = "";
            Road.Text = "";
            Hp.Text = "";
            Emails.Text = "";
            Managers.Text = "";
            HotelId.Text = "";
        }

        private void clearfkamar()
        {
            Fkamarbox.Text = "";
            Nkamarbox.Text = "";
            Id_Fkamartext.Text = "";
        }

        private void cleartipehotel()
        {
            Hargatext.Text = "";
            stoktext.Text = "";
            Fototext.Text = "";
            Deskripsitext.Text = "";
            Id_Hotelbox.Text = "";
            Id_Tipekamarbox.Text = "";
        }
        #endregion

        #region Simpan
        private void save_Click(object sender, RoutedEventArgs e)
        {
            A_HotelController contr = new A_HotelController();
            contr.InsertHotel(Nama_Hotel.Text, Kecamatanbox.Text, Road.Text, Hp.Text, Emails.Text, Managers.Text);
            MessageBox.Show("Register Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
            HotelWindow hasil = new HotelWindow();
            hasil.ShowDialog();
        }

        private void savefkamar_Click(object sender, RoutedEventArgs e)
        {
            A_Roomtype_FacilityController contr = new A_Roomtype_FacilityController();
            contr.InsertFasilitaskamar(Convert.ToInt32(Nkamarbox.SelectedValue), Convert.ToInt32(Fkamarbox.SelectedValue));
            MessageBox.Show("Register Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
            HotelWindow hasil = new HotelWindow();
            hasil.ShowDialog();
        }

        private void savetipe_Click(object sender, RoutedEventArgs e)
        {
            A_Hotel_RoomtypeController contr = new A_Hotel_RoomtypeController();
            contr.InsertTipeHotel(Convert.ToInt32(Hargatext.Text), Convert.ToInt32(stoktext.Text), Fototext.Text, Deskripsitext.Text, Convert.ToInt32(Id_Tipekamarbox.SelectedValue), Convert.ToInt32(Id_Hotelbox.SelectedValue));
            MessageBox.Show("Register Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
            HotelWindow hasil = new HotelWindow();
            hasil.ShowDialog();
        }

        private void savebooking_Click(object sender, RoutedEventArgs e)
        {
            A_BookingdateController contr = new A_BookingdateController();
            contr.InsertBookingDate(Convert.ToDateTime(Tglbooking.Text), Convert.ToInt32(Iduser.SelectedValue));
            MessageBox.Show("Register Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
            HotelWindow hasil = new HotelWindow();
            hasil.ShowDialog();
        }

        public string getJenisKelaminUser()
        {
            string jk = "";
            if (rbLaki.IsChecked == true)
            {
                jk = "Laki-laki";
            }
            else if (rbPerempuan.IsChecked == true)
            {
                jk = "Perempuan";
            }
            return jk;

        }
        private void savecust_Click(object sender, RoutedEventArgs e)
        {
            UserController contr = new UserController();
            contr.InsertUser(Cust_name.Text, Username.Text, Emailcust.Text, Locationcust.Text, Passwordcust.Text, Convert.ToInt16(Roles_id.SelectedValue), getJenisKelaminUser());
            MessageBox.Show("Register Success", "Message", MessageBoxButton.OK, MessageBoxImage.Information);
            this.Hide();
            HotelWindow hasil = new HotelWindow();
            hasil.ShowDialog();
        }
        #endregion


        #region View
        private void viewHotelGrid(DataGrid DG)
        {
            DG.ItemsSource = _context.H_Hotel.OrderBy(x => x.Id).ToList();
        }

        private void viewCustomerGrid(DataGrid DG)
        {
            DG.ItemsSource = _context.HF_User.OrderBy(x => x.Id).ToList();
        }
        //private void viewFkamarGrid(DataGrid DG)
        //{
        //    var get = _context.H_Roomtype_Facility.Include("H_Facility");
        //    get.H_Facility.Name;
        //}
        private void viewFkamarGrid(DataGrid DG)
        {
            DG.ItemsSource = _context.H_Roomtype_Facility.OrderBy(x => x.Id).ToList();
        }

        private void viewHotelTypeGrid(DataGrid DG)
        {
            DG.ItemsSource = _context.H_Hotel_Roomtype.OrderBy(x => x.Id).ToList();
        }
        #endregion

        #region searchID
        private H_Hotel SearchByIdHotel(int id)
        {
            var dataid = _context.H_Hotel.Find(id);
            if (dataid == null)
            {
                MessageBox.Show("Id " + HotelId + " not found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return dataid;
        }

        private H_Roomtype_Facility SearchByIdFkamar(int id)
        {
            var dataid = _context.H_Roomtype_Facility.Find(id);
            if (dataid == null)
            {
                MessageBox.Show("Id " + Id_Fkamartext + " not found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return dataid;
        }

        private H_Hotel_Roomtype SearchByIdTipehotel(int id)
        {
            var dataid = _context.H_Hotel_Roomtype.Find(id);
            if (dataid == null)
            {
                MessageBox.Show("Id " + Id_Tipehotel + " not found", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return dataid;
        }
        #endregion

        #region SelectionChanged
        private void Provinsibox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string x =Convert.ToString(Provinsibox.SelectedValue);
            Kabupatenbox.DisplayMemberPath = "name";
            Kabupatenbox.SelectedValuePath = "id";
            Kabupatenbox.ItemsSource = _context.regencies.Where(a => a.province_id == x).ToList();
        }
        private void Kabupatenbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string x = Convert.ToString(Kabupatenbox.SelectedValue);
            Kecamatanbox.DisplayMemberPath = "name";
            Kecamatanbox.SelectedValuePath = "id";
            Kecamatanbox.ItemsSource = _context.districts.Where(b => b.regency_id == x).ToList();
        }
        private void Kecamatanbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string x = Convert.ToString(Kecamatanbox.SelectedValue);
            Kelurahanbox.DisplayMemberPath = "name";
            Kelurahanbox.SelectedValuePath = "id";
            Kelurahanbox.ItemsSource = _context.villages.Where(c => c.district_id == x).ToList();
        }

        private void HotelGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = HotelGrid.SelectedItem;

                string data1 = (HotelGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                HotelId.Text = data1;
                string data2 = (HotelGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                Nama_Hotel.Text = data2;
                string data3 = (HotelGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                Kecamatanbox.Text = data3;
                string data4 = (HotelGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                Road.Text = data4;
                string data5 = (HotelGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                Hp.Text = data5;
                string data6 = (HotelGrid.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                Emails.Text = data6;
                string data7 = (HotelGrid.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
                Managers.Text = data7;
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }

        private void FkamarGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = FkamarGrid.SelectedItem;

                string data1 = (FkamarGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                Id_Fkamartext.Text = data1;
                string data2 = (FkamarGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                Fkamarbox.Text = data2;
                string data3 = (FkamarGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                Nkamarbox.Text = data3;
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }

        private void TypeHotelGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = TypeHotelGrid.SelectedItem;

                string data1 = (TypeHotelGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                Id_Tipehotel.Text = data1;
                string data2 = (TypeHotelGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                Hargatext.Text = data2;
                string data3 = (TypeHotelGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                stoktext.Text = data3;
                string data4 = (TypeHotelGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
                Fototext.Text = data4;
                string data5 = (TypeHotelGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                Deskripsitext.Text = data5;
                string data6 = (TypeHotelGrid.SelectedCells[5].Column.GetCellContent(item) as TextBlock).Text;
                Id_Hotelbox.Text = data6;
                string data7 = (TypeHotelGrid.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
                Id_Tipekamarbox.Text = data7;
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }

        private void TglBookingGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object item = TglBookingGrid.SelectedItem;

                string data1 = (TglBookingGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                Id_Bookingdate.Text = data1;
                string data2 = (TglBookingGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
                Tglbooking.Text = data2;
                string data3 = (TglBookingGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
                Iduser.Text = data3;
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.InnerException);
            }
        }

        private void CustomerGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //try
            //{
            //    object item = CustomerGrid.SelectedItem;

            //    string data1 = (CustomerGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
            //    Id_Customer.Text = data1;
            //    string data2 = (CustomerGrid.SelectedCells[1].Column.GetCellContent(item) as TextBlock).Text;
            //    Cust_name.Text = data2;
            //    string data3 = (CustomerGrid.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text;
            //    Username.Text = data3;
            //    string data4 = (CustomerGrid.SelectedCells[3].Column.GetCellContent(item) as TextBlock).Text;
            //    Emailcust.Text = data4;
            //    string data5 = (CustomerGrid.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
            //    Locationcust.Text = data4;
            //    string data6 = (CustomerGrid.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text;
            //    Roles_id.Text = data6;
            //    string data7 = (CustomerGrid.SelectedCells[8].Column.GetCellContent(item) as TextBlock).Text;
            //}
            //catch (Exception ex)
            //{
            //    System.Console.Write(ex.InnerException);
            //}
        }
        #endregion

        #region Update
        private void update_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(HotelId.Text);

            H_Hotel datax = SearchByIdHotel(id);
            datax.Hotel_Name = Nama_Hotel.Text;
            datax.VillagesID = Kecamatanbox.Text;
            datax.Jalan = Road.Text;
            datax.Phone = Hp.Text;
            datax.Email = Emails.Text;
            datax.Manager = Managers.Text;
        }

        private void updatefkamar_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(Id_Tipehotel.Text);
            H_Roomtype_Facility datax = SearchByIdFkamar(id);
            datax.H_FacilityID =Convert.ToInt32(Fkamarbox.SelectedValue);
            datax.H_RoomtypeID = Convert.ToInt32(Nkamarbox.SelectedValue);            

            //try
            //{
            //    _context.Entry(datax).State = System.Data.Entity.EntityState.Modified;
            //    _context.SaveChanges();
            //    clearhotel();
            //    this.viewFkamarGrid(FkamarGrid);
            //    MessageBox.Show("Update Success !", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            //}
            //catch (DbEntityValidationException ex)
            //{
            //    foreach (var eve in ex.EntityValidationErrors)
            //    {
            //        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
            //            eve.Entry.Entity.GetType().Name, eve.Entry.State);
            //        foreach (var ve in eve.ValidationErrors)
            //        {
            //            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
            //                ve.PropertyName, ve.ErrorMessage);
            //        }
            //    }
            //    throw;
            //}
        }

        private void updatetipe_Click(object sender, RoutedEventArgs e)
        {
            int id = Convert.ToInt32(Id_Tipehotel.Text);

            H_Hotel_Roomtype datax = SearchByIdTipehotel(id);
            datax.Price = Convert.ToInt32(Hargatext.Text);
            datax.Available = Convert.ToInt16(stoktext.Text);
            datax.Image = Fototext.Text;
            datax.Description = Deskripsitext.Text;
            datax.H_HotelID = Convert.ToInt32(Id_Hotelbox.SelectedValue);
            datax.H_RoomtypeID = Convert.ToInt32(Id_Tipekamarbox.SelectedValue);
        }

        private void updatebooking_Click(object sender, RoutedEventArgs e)
        {

        }

        private void updatecust_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region Hapus
        private void HapusButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                object item = HotelGrid.SelectedItem;
                string temp_id = (HotelGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                int id = Convert.ToInt32(temp_id);
                H_Hotel datadel = SearchByIdHotel(id);
                _context.Entry(datadel).State = System.Data.Entity.EntityState.Deleted;
                _context.SaveChanges();
                clearhotel();
                this.viewHotelGrid(HotelGrid);
            }
            else
            {

            }
        }

        private void Hapusfkamar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                object item = FkamarGrid.SelectedItem;
                string temp_id = (FkamarGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                int id = Convert.ToInt32(temp_id);
                H_Roomtype_Facility datadel = SearchByIdFkamar(id);
                _context.Entry(datadel).State = System.Data.Entity.EntityState.Deleted;
                _context.SaveChanges();
                clearhotel();
                this.viewFkamarGrid(FkamarGrid);
            }
            else
            {

            }
        }

        private void hapustipe_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You Sure ?", "Information", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                object item = TypeHotelGrid.SelectedItem;
                string temp_id = (TypeHotelGrid.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                int id = Convert.ToInt32(temp_id);
                H_Hotel_Roomtype datadel = SearchByIdTipehotel(id);
                _context.Entry(datadel).State = System.Data.Entity.EntityState.Deleted;
                _context.SaveChanges();
                clearhotel();
                this.viewHotelTypeGrid(TypeHotelGrid);
            }
            else
            {

            }
        }

        private void Hapuscust_Click(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        #region combobox
        public void LoadIdComboBox()
        {
            Fkamarbox.DisplayMemberPath = "Facllity_Name";
            Fkamarbox.SelectedValuePath = "Id";
            Fkamarbox.ItemsSource = _context.H_Facility.ToList();

            Nkamarbox.DisplayMemberPath = "Roomtype_Name";
            Nkamarbox.SelectedValuePath = "Id";
            Nkamarbox.ItemsSource = _context.H_Roomtype.ToList();
        }

        public void LoadIdTRComboBox()
        {
            Id_Tipekamarbox.DisplayMemberPath = "Roomtype_Name";
            Id_Tipekamarbox.SelectedValuePath = "Id";
            Id_Tipekamarbox.ItemsSource = _context.H_Roomtype.ToList();

            Id_Hotelbox.DisplayMemberPath = "Hotel_Name";
            Id_Hotelbox.SelectedValuePath = "Id";
            Id_Hotelbox.ItemsSource = _context.H_Hotel.ToList();
        }

        public void LoadIduser()
        {
            Iduser.DisplayMemberPath = "Name";
            Iduser.SelectedValuePath = "Id";
            Iduser.ItemsSource = _context.HF_User.ToList();
        }

        public void LoadIdrole()
        {
            Roles_id.DisplayMemberPath = "Roles";
            Roles_id.SelectedValuePath = "Id";
            Roles_id.ItemsSource = _context.Roles.ToList();
        }
        #endregion
    }
}
