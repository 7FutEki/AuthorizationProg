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

namespace Authorization.Windows
{
    /// <summary>
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        public Account()
        {
            InitializeComponent();
        }

        private void AccButton_Click(object sender, RoutedEventArgs e)
        {
            MainAccount mainAccount = new MainAccount();
            Close();
            mainAccount.ShowDialog();
        }

        private void btn_ntf_Click(object sender, RoutedEventArgs e)
        {
            Notifications notifications = new Notifications();
            Close();
            notifications.ShowDialog();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
