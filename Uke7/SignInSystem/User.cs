using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSystem
{
    internal class User
    {
        private string id;
        private string name;

        public User(string id, string username)
        {
            this.id = id;
            this.name = username;
        }
    }
}
