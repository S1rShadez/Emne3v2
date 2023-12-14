namespace ParProg
{
    internal class Game
    {
        public static void run(Trainer trainer)
        {
            bool cont = true;

            while (cont)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n1. Adventure\n2. Shop\n3. Inventory\n4. Pokemon inventory\n10. Quit Game");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(""); ;
                        break;
                    case "2":
                        Console.WriteLine(""); ;
                        break;
                    case "3":
                        ShowInventory(trainer);
                        break;
                    case "4":
                        ShowPokemons(trainer);
                        break;
                    case "10":
                        cont = false;
                        break;
                    default:
                        Console.WriteLine("No valid option selected, please try again.");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void ShowPokemons(Trainer trainer)
        {
            Console.Clear();
            Console.WriteLine(trainer.getPokemons());
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        private static void ShowInventory(Trainer trainer)
        {
            Console.Clear();
            Console.WriteLine(trainer.getItems());
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
