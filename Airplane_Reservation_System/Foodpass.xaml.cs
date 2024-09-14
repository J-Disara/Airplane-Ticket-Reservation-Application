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

namespace Airplane_Reservation_System
{
    /// <summary>
    /// Interaction logic for Foodpass.xaml
    /// </summary>
    public partial class Foodpass : Window
    {
        public Foodpass()
        {
            InitializeComponent();
        }
        private void Border_Mousedown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private bool IsMaximized = false;
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                if (!IsMaximized)
                {
                    this.WindowState = WindowState.Normal;
                    this.Width = 1080;
                    this.Height = 720;
                    this.IsMaximized = false;
                }
                else
                {
                    this.WindowState = WindowState.Maximized;

                    this.IsMaximized = false;
                }
            }
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
        

        private void btn_ticket_Click(object sender, RoutedEventArgs e)
        {
            tickets obj = new tickets();
            Close();
            obj.Show();
        }

        private void btn_dashboard_Click(object sender, RoutedEventArgs e)
        {
            Home obj = new Home();
            Close();
            obj.Show();
        }

        private void btn_wallet_Click(object sender, RoutedEventArgs e)
        {
            Wallet obj = new Wallet();
            Close();
            obj.Show();
        }

        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow obj = new MainWindow();
            Close();
            obj.Show();
        }
    }
}
