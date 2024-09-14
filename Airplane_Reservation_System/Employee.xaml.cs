using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace Airplane_Reservation_System
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Window
    {
        public Employee()
        {
            InitializeComponent();
        }
        
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        private void btn_close_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn_minimize_click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btn_insert_click(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (txt_name.Text.Length == 0 || txt_name.Text.Any(char.IsDigit))
                    MessageBox.Show("Name cannot contain any numbers or Name cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_idno.Text.Length == 0)
                    MessageBox.Show("ID no cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_tp.Text.Length == 0 || txt_tp.Text.Any(char.IsLetter))
                    MessageBox.Show("Phone number cannot contain any letters or Phone number cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_username.Text.Length == 0)
                    MessageBox.Show("Username cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_email.Text.Length == 0)
                    MessageBox.Show("Email cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_password.Password.Length == 0)
                    MessageBox.Show("Password cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_password.Password != txt_cpassword.Password)
                {
                    MessageBox.Show("Password does not match with Confirm Password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    txt_password.Clear();
                    txt_cpassword.Clear();
                }
                else if (!(rbn_male.IsChecked == false|| rbn_female.IsChecked == false))
                    MessageBox.Show("Select your gender", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                {
                    string gender;
                    SQL sql = new SQL();
                    if (rbn_male.IsChecked == true)
                        gender = "Male";
                    else
                        gender = "Female";

                    string query = "insert into Employee values('"+txt_empno.Text+"','"+txt_name.Text+"','"+txt_username.Text+"','"+txt_email.Text+"','"+txt_password.Password+"','"+txt_idno.Text+"','"+txt_tp.Text+"','"+gender+"')";
                    double i = sql.insert_update_delete(query);
                    if(i==1)
                        MessageBox.Show("Data saved successfully","Info",MessageBoxButton.OK, MessageBoxImage.Information);
                    else
                        MessageBox.Show("Database Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_update_click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_uempno.Text.Length == 0)
                    MessageBox.Show("Employee no cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_uname.Text.Length == 0 || txt_uname.Text.Any(char.IsDigit))
                    MessageBox.Show("Name cannot contain any numbers or Name cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_uidno.Text.Length == 0)
                    MessageBox.Show("ID no cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_utp.Text.Length == 0 || txt_utp.Text.Any(char.IsLetter))
                    MessageBox.Show("Phone number cannot contain any letters or Phone number cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_uusername.Text.Length == 0)
                    MessageBox.Show("Username cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_uemail.Text.Length == 0)
                    MessageBox.Show("Email cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_upassword.Password.Length == 0)
                    MessageBox.Show("Password cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if (txt_upassword.Password != txt_ucpassword.Password)
                {
                    MessageBox.Show("Password does not match with Confirm Password", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    txt_upassword.Clear();
                    txt_ucpassword.Clear();
                }
                else if (!(rbn_umale.IsChecked == false|| rbn_ufemale.IsChecked == false))
                    MessageBox.Show("Select your gender", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                {
                    string gender;
                    SQL sql = new SQL();
                    if (rbn_umale.IsChecked == true)
                        gender = "Male";
                    else
                        gender = "Female";

                    string query = "Update Employee set(name = '"+txt_name.Text+"',username = '"+txt_username.Text+"',email = '"+txt_email.Text+"',password = '"+txt_upassword.Password+"',idno = '"+txt_idno.Text+"',tp = '"+txt_utp.Text+"','"+gender+"' where empno = '"+txt_uempno+"'";
                    double i = sql.insert_update_delete(query);
                    if (i==1)
                        MessageBox.Show("Data updated successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    else
                        MessageBox.Show("Database Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void btn_delete_click(object sender, RoutedEventArgs e)
        {
           /* try
            {
                if (txt_dempno.Text.Length == 0)
                    MessageBox.Show("Employee no cannot be blank", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                {
                    SQL sql = new SQL();

                    string query = "delete from Employee empno = '"+txt_dempno+"'";
                    double i = sql.insert_update_delete(query);
                    if (i==1)
                        MessageBox.Show("Data deleted successfully", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    else
                        MessageBox.Show("Database Error", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }*/
        }

        private void btn_emphome_Click(object sender, RoutedEventArgs e)
        {
            Home obj = new Home();
            this.Close();
            obj.Show();
        }
        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            this.Close();
            obj.Show();
        }
    }
}
