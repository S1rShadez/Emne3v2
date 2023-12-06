using System.Runtime.CompilerServices;

namespace ParProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            ToDo toDoList = new ToDo();
            toDoList.AddTask(new ToDoItems("Jog", "Jog 1 lap every day", false));

            while (cont)
            {
                Console.Clear();
                Console.WriteLine("Welcome to your ToDo list");
                Console.WriteLine("Would you like to:\n1. See tasks\n2. Add a task\n3. Remove a task\n4. Complete task");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowAllTasks(toDoList);
                        break;
                    case "2":
                        AddNewTask(toDoList);
                        break;
                    case "3":
                        RemoveOldTask(toDoList);
                        break;
                    case "4":
                        CompleteTask(toDoList);
                        break;
                }
            }
        }

        private static void CompleteTask(ToDo toDoList)
        {
            Console.Clear();
            Console.WriteLine("Which task would you like to complete?");
            Console.WriteLine(toDoList.SeeAllTasks());
            int select = Convert.ToInt16(Console.ReadLine()) - 1;
            toDoList.CompleteTask(select);
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
        }

        private static void ShowAllTasks(ToDo toDoList)
        {
            Console.Clear();
            Console.WriteLine(toDoList.SeeAllTasks());
            Console.WriteLine("Would you like to see details of a task? y/n");
            string input = Console.ReadLine();
            if (input.ToLower() == "y")
            {
                Console.WriteLine("Enter the number of the task you want details on:");
                int select = Convert.ToInt16(Console.ReadLine())-1;
                Console.WriteLine(toDoList.TaskDetails(select));
            }

            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
        }

        private static void RemoveOldTask(ToDo toDoList)
        {
            Console.Clear();
            Console.WriteLine(toDoList.SeeAllTasks());
            Console.WriteLine("Enter the number of the task you want to delete:");
            int selection = Convert.ToInt16(Console.ReadLine());
            toDoList.DeleteTask(selection);
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
        }

        private static void AddNewTask(ToDo toDoList)
        {
            Console.Clear();
            Console.WriteLine("Whats the title of your task?");
            string title = Console.ReadLine();
            Console.WriteLine("Please enter a description of the task:");
            string desc = Console.ReadLine();
            toDoList.AddTask(new ToDoItems(title, desc, false));
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
        }
    }
}
