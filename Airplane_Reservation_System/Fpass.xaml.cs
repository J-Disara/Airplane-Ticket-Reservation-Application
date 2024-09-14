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
using static System.Net.Mime.MediaTypeNames;

namespace Airplane_Reservation_System
{
    /// <summary>
    /// Interaction logic for Fpass.xaml
    /// </summary>
    public partial class Fpass : Window
    {
        public Fpass()
        {
            InitializeComponent();
        }
        
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void btn_Set_click(object sender, RoutedEventArgs e)
        {
            OTP ot = new OTP();
            txt_password.Text = ot.setdata();
            try
            {
                if (txt_password.Text.Length < 8 || txt_password.Text.Length > 15)
                    MessageBox.Show("Password must contain 8 - 15 characters", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if(txt_password.Text == txt_cpassword.Password)
                    MessageBox.Show("Password must contain 8 - 15 characters", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                {
                    string query;
                   
                    query = "update Customer set Password = '" + txt_password.Text + "' where Username = '" + ot.txt_username.Text + "'";
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_close_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
