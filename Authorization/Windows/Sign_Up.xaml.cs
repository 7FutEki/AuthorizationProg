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
using Authorization.Models;

namespace Authorization.Windows
{
    /// <summary>
    /// Логика взаимодействия для Sign_Up.xaml
    /// </summary>
    public partial class Sign_Up : Window
    {
        public User user { get; set; }
        public Sign_Up()
        {
            user = new User();
            InitializeComponent();
            DataContext = user;

        }


        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Close();
            mainWindow.ShowDialog();
        }

        private void btn_up_Click(object sender, RoutedEventArgs e)
        {
            Metods.Sign_Up(user.Login, user.Email, user.Password);
            Account account = new Account();
            Close();
            account.ShowDialog();
        }   
    }
}
