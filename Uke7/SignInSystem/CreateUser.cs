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
        private string _id;
        private string _uName;
        private string _pWord;

        private void SetID(string id)
        {
            _id = Encrypt512(id);
        }

        public void SetUName(string uName)
        {
            _uName = Encrypt512(uName);
        }

        public void SetPWord(string pWord)
        {
            _pWord = Encrypt512(pWord);
        }

        public CreateUser(string uName, string pWord)
        {
            SetID(uName+pWord);
            SetUName(uName);
            SetPWord(pWord);
        }

        public User ReturnUser(string userName)
        {
            return new User(_id, userName);
        }

        //Only for testing:
        public void CheckCreatedUser()
        {
            Console.WriteLine(_id + "\n" + _uName + "\n" + _pWord);
        }
    }
}
