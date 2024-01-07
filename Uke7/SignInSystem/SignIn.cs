using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SignInSystem.Encryptor;
using static SignInSystem.ManageUsers;

namespace SignInSystem
{
    internal static class SignIn
    {
        public static User SignInUser(string uName, string pWord)
        {
            User user = default;

            if (VerifyUser(uName, pWord))
            {
                user = new User("1234", uName);
            }

            return user;
        }
    }
}
