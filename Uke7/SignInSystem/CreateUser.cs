using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SignInSystem.Encryptor;

namespace SignInSystem
{
    internal class CreateUser
    {
        public string _id { get; set; }
        public string _uName { get; set; }
        public string _pWord { get; set; }

        private void SetID(string id)
        {
            _id = Encrypt512(id);
        }

        public void SetUName(string uName)
        {
            _uName = uName;
        }

        public void SetPWord(string pWord)
        {
            _pWord = Encrypt512(pWord);
        }

        public CreateUser(string uName, string pWord)
        {
            SetID(uName + pWord + ManageUsers.UsersCount());
            SetUName(uName);
            SetPWord(pWord);
            ManageUsers.AddUser(this);
        }

        [JsonConstructor]
        public CreateUser(string id, string uName, string pWord)
        {
            _id += id;
            _uName = uName;
            _pWord = pWord;
        }

        public User ReturnUser()
        {
            return new User(_id, _uName);
        }

        //Only for testing:
        public void CheckCreatedUser()
        {
            Console.WriteLine(_id + "\n" + _uName + "\n" + _pWord);
        }
    }
}
