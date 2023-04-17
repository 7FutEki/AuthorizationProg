using Authorization.DB;
using Authorization.Models;
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
    /// Логика взаимодействия для MainAccount.xaml
    /// </summary>
    public partial class MainAccount : Window
    {
        public User user { get; set; }
        public MainAccount()
        {
            user = new User();
            InitializeComponent();
            DataContext = user;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void btn_close_Click(object sender, RoutedEventArgs e)
        {
            Account account = new Account();
            Close();
            account.ShowDialog();
        }

        private void btn_check_Click(object sender, RoutedEventArgs e)
        {
            //Переделать, ато кринж какой то, можно тырить данные чужие
            User check = null;
            using(ApplicationContext db = new ApplicationContext())
            {
                check = db.Users.Where(x=>x.Email == tb_email.Text).FirstOrDefault();
                if (check != null)
                {
                    tb_login.Text = ("Логин: "+Convert.ToString(check.Login));
                    tb_pass.Text = ( "Пароль: " + Convert.ToString(check.Password));
                }
            }
        }

        private void btn_exit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = MessageBox.Show("Вы уверены?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                MainWindow mainWindow = new MainWindow();
                Close();
                mainWindow.ShowDialog();
            }
        }
    }
}
