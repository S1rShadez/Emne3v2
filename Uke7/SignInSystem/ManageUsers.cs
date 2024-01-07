using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SignInSystem.Encryptor;

namespace SignInSystem
{
    internal static class ManageUsers
    {
        private static List<CreateUser> users = new List<CreateUser>();

        public static string UsersCount()
        {
            if (users == null)
            {
                return "0";
            }
            return $"{users.Count}";
        }

        public static bool VerifyUser(string uName, string pWord)
        {

            string tempPWord = Encrypt512(pWord);

            for (int i = 0; i < users.Count; i++)
            {
                if (Equals(users[i]._uName, uName) && Equals(users[i]._pWord, tempPWord))
                {
                    var tempId = Encrypt512(uName + pWord + $"{i}");
                    if (Equals(tempId, users[i]._id))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool UNameExists(string uName)
        {
            foreach (CreateUser user in users)
            {
                if (Equals(user._uName, uName))
                {
                    return true;
                }
            }
            return false;
        }

        public static void AddUser(CreateUser user)
        {
            users.Add(user);
            Console.WriteLine("User added to list");
        }

        public static void ReadUsers()
        {
            string text = File.ReadAllText("C:\\Users\\S1rShadez\\Documents\\GitHub\\Emne3v2\\Uke7\\SignInSystem\\users.json");

            users = JsonConvert.DeserializeObject<List<CreateUser>>(text);
        }

        public static void WriteUsers()
        {
            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
            };

            string json = JsonConvert.SerializeObject(users, settings);
            //Console.WriteLine(json);
            File.WriteAllText("C:\\Users\\S1rShadez\\Documents\\GitHub\\Emne3v2\\Uke7\\SignInSystem\\users.json", json);
            Console.WriteLine("JSON file saved!");
        }
    }
}
