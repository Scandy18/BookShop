using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookShop.Models
{
    public class LoginAuth
    {
        public static User Auth(string email, string pwd)
        {
            DataMaintain db = new DataMaintain();
            return db.User.FirstOrDefault(m => m.Email == email && m.Password == pwd);
        }
    }
}