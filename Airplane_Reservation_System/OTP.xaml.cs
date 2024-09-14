using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
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
using System.Net;
using System.Net.Mail;

namespace Airplane_Reservation_System
{
    /// <summary>
    /// Interaction logic for OTP.xaml
    /// </summary>
    public partial class OTP : Window
    {
        public OTP()
        {
            InitializeComponent();
        }
        string randomcode;
        public static string to;
        public string setdata()
        {
            string name = txt_username.Text;
            return name;
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
        private void btn_sendotp_click(object sender, RoutedEventArgs e)
        {
        
                if (txt_username.Text.Length == 0)
                    MessageBox.Show("input username", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                else if(txt_email.Text.Length == 0)
                    MessageBox.Show("input email", "error", MessageBoxButton.OK, MessageBoxImage.Error);
                else
                {
                    string from, pass, messagebody;
                    Random rand = new Random();
                    randomcode = (rand.Next(999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (txt_email.Text).ToString();
                    from = "codse223f098@gmail.com";
                    pass = "ymfgdrtitxzaimgl";
                    messagebody = $"Your Reset Code is {randomcode}";
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messagebody;
                    message.Subject = "Password Reset Code";
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, pass);

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code Send Succesfully");

                }
                catch(Exception)
                {
                    MessageBox.Show("Worng Code","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                }
                }
         
        }
        private void btn_reotp_click(object sender, RoutedEventArgs e)
        {
            if (randomcode == (txt_otp.Text).ToString())
            {
                to = txt_email.Text;
                Fpass rp = new Fpass();
                this.Hide();
                rp.Show();
            }
            else
            {
                MessageBox.Show("Wrong Code", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            this.Close();
            obj.Show();
        }
    }
}
