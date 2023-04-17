using Authorization.DB;
using Authorization.Windows;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Authorization.Models
{
    public class Metods
    {
        public static bool Sign_Up(string login,string email, string password)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.Migrate();
                bool check = db.Users.Any(el => el.Login == login && el.Email==email && el.Password == password);
                if (!check)
                {
                    User newuser = new User
                    {
                        
                        Login = login,
                        Email = email,
                        Password = password
                    };
                    db.Users.Add(newuser);
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
        }


        public static bool Sign_In(string login, string password)
        {
            User auth = null;
            using (ApplicationContext db = new ApplicationContext())
            {
                auth = db.Users.Where(x=>x.Login==login && x.Password==password).FirstOrDefault();
                if (auth != null)
                {
                    return true;
                }
                else
                    MessageBox.Show("Неправильно введеныe данные");
                    return false;

            }
        }


    }
}
