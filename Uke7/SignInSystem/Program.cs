using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static SignInSystem.SignIn;

namespace SignInSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Login";
            Console.ForegroundColor = ConsoleColor.Cyan;


            try
            {
                ManageUsers.ReadUsers();
            }
            catch (FileNotFoundException e)
            {
                File.Create("C:\\Users\\S1rShadez\\Documents\\GitHub\\Emne3v2\\Uke7\\SignInSystem\\users.json").Close();
            }

            User currentUser = StartSystem();
            Console.WriteLine(currentUser.ToString());
            Console.ReadKey();
        }

        private static User StartSystem()
        {
            User user = default;
            while (true)
            {
                switch (AskUser("Welcome!\n1. Sign in\n2. Create user\n10. Exit"))
                {
                    case "1":
                        user = UserSignIn();
                        break;
                    case "2":
                        user = NewUser();
                        ManageUsers.WriteUsers();
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

        private static User UserSignIn()
        {
            User user;
            string username = AskUser("Enter your username:");
            string password = AskUser("Enter your password:");
            user = SignInUser(username, password);
            return user;
        }

        private static User NewUser()
        {
            string uName;
            string pWord;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Create User:");
                uName = AskUser("Enter username:");
                if (!ManageUsers.UNameExists(uName))
                {
                    pWord = AskUser("Enter password:");
                    string verify = AskUser("Verify password:");
                    if (pWord == verify && !string.IsNullOrEmpty(pWord))
                    {
                        break;
                    }
                    else
                    {
                        PressContinue("Passwords does not match (empty password not allowed), try again...");
                    }
                }
                else
                {
                    PressContinue("Username already exists, please try again...");
                }
            }

            var newUser = new CreateUser(uName, pWord);
            newUser.CheckCreatedUser();
            Console.Clear();
            Console.WriteLine($"User created successfully with username: {uName}");
            PressContinue("Press any key to continue...");
            return newUser.ReturnUser();

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
