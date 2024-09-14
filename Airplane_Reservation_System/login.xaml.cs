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
using System.Data.SqlClient;

namespace Airplane_Reservation_System
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

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter sda;

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btn_minimize_click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_close_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_login_click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_acctype.SelectedIndex == -1)
                    MessageBox.Show("Please select Account type", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_username.Text.Length == 0)
                    MessageBox.Show("Input Username", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_password.Password.Length == 0)
                    MessageBox.Show("Input Password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                {
                    /* con = new SqlConnection("Data Source=-\\SQLEXPRESS;Initial Catalog=log_in;Integrated Security=True");
                     con.Open();
                     string query;
                     if (txt_acctype.SelectedIndex == 0)
                         query = "Select count(1) from Admin where username = '" + txt_username.Text + "' and password = '" + txt_password.Password + "'";
                     else if (txt_acctype.SelectedIndex == 1)
                         query = "Select count(1) from Employee where username = '" + txt_username.Text + "' and password = '" + txt_password.Password + "'";
                     else
                         query = "Select count(1) from Customer where username = '" + txt_username.Text + "' and password = '" + txt_password.Password + "'";

                     cmd = new SqlCommand(query, con);
                     int i = Convert.ToInt32(cmd.ExecuteScalar());
                     if (i == 1)
                     {
                         MessageBox.Show("welcome", "info", MessageBoxButton.OK, MessageBoxImage.Error);
                         Home obj = new Home();
                         obj.Show();
                     }
                     else
                         MessageBox.Show("Please check your username or password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);*/

                    if (txt_acctype.SelectedIndex == 0)
                    {
                        Employee obj = new Employee();
                        this.Close();
                        obj.Show();
                    }
                    else
                    {
                        Home obj = new Home();
                        this.Close();
                        obj.Show();
                    }
                       
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Database error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Please try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_register_click(object sender, RoutedEventArgs e)
        {
            register obj = new register();
            this.Close();
            obj.Show();       
        }

        private void LightTheam_Click(object sender, RoutedEventArgs e)
        {
            Appteams.changetheam(new Uri("theams/light.xaml", UriKind.Relative));
        }

        private void DarkTheam_Click_1(object sender, RoutedEventArgs e)
        {
            Appteams.changetheam(new Uri("theams/Dark.xaml", UriKind.Relative));
        }

        private void btn_reset_Click(object sender, RoutedEventArgs e)
        {
            OTP obj = new OTP();
            this.Close();
            obj.Show();
        }
    }
}
