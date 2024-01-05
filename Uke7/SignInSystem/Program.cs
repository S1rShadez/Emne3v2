using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SignInSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User currentUser = StartSystem();
            //Console.WriteLine(currentUser.ToString());
        }

        private static User StartSystem()
        {
            User user = null;
            while (true)
            {
                switch (AskUser("Welcome!\n1. Sign in\n2. Create user\n10. Exit"))
                {
                    case "1":
                        //user == SignedInUser
                        break;
                    case "2":
                        user = NewUser();
                        break;
                    case "10":
                        Console.WriteLine("Exiting...");
                        Environment.Exit(0);
                        break;
                    default:
                        PressContinue("Invalid input, please try again...");
                        continue;
                }
                break;
            }
            return user;
        }

        private static User NewUser()
        {
            Console.Clear();
            Console.WriteLine("Create User:");

            string uName = AskUser("Enter username");
            
            string pWord = AskUser("Enter password");
            var newUser = new CreateUser(uName, pWord);
            newUser.CheckCreatedUser();
            Console.Clear();
            Console.WriteLine($"User created successfully with username: {uName}");
            PressContinue("Press any key to continue...");
            return newUser.ReturnUser(uName);
        }

        private static void PressContinue(string msg)
        {
            Console.WriteLine(msg);
            Console.ReadKey();
            Console.Clear();
        }

        private static string AskUser(string ask)
        {
            Console.WriteLine(ask);
            return Console.ReadLine();
        }
    }
}
