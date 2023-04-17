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
    /// Логика взаимодействия для MyAccount.xaml
    /// </summary>
    public partial class MyAccount : Window
    {
        public MyAccount()
        {
            InitializeComponent();
            ApplicationContext db = new ApplicationContext();
            List<User> user = db.Users.ToList();
            lv.ItemsSource = user;

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
            MainWindow main = new MainWindow();
            Close();
            main.ShowDialog();
        }
    }
}
