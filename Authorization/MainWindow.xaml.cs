
using Authorization.DB;
using Microsoft.EntityFrameworkCore;
using ModernWpf;
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
using Authorization.Windows;
using Authorization.Models;
using System.Net.Mail;
using System.Net;

namespace Authorization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public User user { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            user = new User();
            DataContext = user;
            ApplicationContext db = new ApplicationContext();
            db.Database.Migrate();
        }
        private void btn_up_Click(object sender, RoutedEventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            Close();
            sign_Up.ShowDialog();
        }

        private void btn_in_Click(object sender, RoutedEventArgs e)
        {
            bool r =Metods.Sign_In(user.Login, user.Password);
            if (r == true)
            {
                if (user.Login == "FutEki" && user.Password == "senchaaa55")
                {
                    MyAccount myAccount = new MyAccount();
                    Close();
                    myAccount.ShowDialog();
                }
                
                else
                {
                    Account account = new Account();
                    Close();
                    account.ShowDialog();
                }
            }

        }
        private void btn_rstpas_Click(object sender, RoutedEventArgs e)
        {
            //SmtpClient Smtp = new SmtpClient();
            //Smtp.Host = "smtp.yandex.ru";
            //Smtp.Port = 587;
            //Smtp.EnableSsl = false;
            //Smtp.Credentials = new NetworkCredential("FutEki55@yandex.ru", "asdzxce13579");
            //MailMessage Message = new MailMessage();
            //Message.From = new MailAddress("FutEki55@yandex.ru");
            //Message.To.Add(new MailAddress("senchaaa3@gmail.com"));
            //Message.Subject = "Тема письма ";
            //Message.Body = "Содержание";
            //Smtp.Send(Message);
                
            
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
            Close();
        }
    }
}
