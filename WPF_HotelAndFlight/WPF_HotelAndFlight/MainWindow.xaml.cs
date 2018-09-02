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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_HotelAndFlight.Controller;

namespace WPF_HotelAndFlight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        UserController users = new UserController();
        private void login_Click(object sender, RoutedEventArgs e)
        {

            if (users.login(usernamebox.Text, passwordBox.Password) == true)
            {
                MessageBox.Show("Login Success", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Hide();
                HotelWindow admin = new HotelWindow();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username and Password not match", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                passwordBox.Clear();
                usernamebox.Clear();
                usernamebox.Focus();
            }
        }

        /*private void register_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddEmployees addemployee = new AddEmployees();
            addemployee.ShowDialog();
        }*/
    }
}
