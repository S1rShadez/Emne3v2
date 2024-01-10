using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WFPSignIn.Encrypt;

namespace WFPSignIn
{
    internal class ManageUsers
    {
        public static List<User> Users = new List<User>();
    }

    internal class User
    {
        int Id;
        string UserName;
        string Password;

        public User(string userName, string password)
        {
            //Id = SetId();
            UserName = userName;
            Password = SetPassword(password);
            ManageUsers.Users.Add(this);
            Console.WriteLine(UserName);
        }

        private static string SetPassword(string pWord)
        {
            return Encrypt512(pWord);
        }

        //private static int SetId()
        //{
        //    int id = ManageUsers.Users.Count();
        //    if (id <= 0)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return id;
        //    }
        //}
    }
}
