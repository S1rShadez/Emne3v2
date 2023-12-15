namespace ParProg
{
    internal class Game
    {
        public static void run(Trainer trainer)
        {
            bool cont = true;

            List<Items> shopStock = new List<Items>(){new(1, "Pokeball", "A ball used to catch pokemon", 50, price: 10), new(2, "Potion", "Restores 20 HP for a pokemon", 50, healAmount: 20, price: 20)};

            Shop PokeShop = new Shop(shopStock);

            while (cont)
            {
                Console.Clear();
                Console.WriteLine($"Welcome, {trainer.Name}!");
                Console.WriteLine("What would you like to do?\n1. Adventure(WIP)\n2. Shop\n3. Inventory\n4. Pokemon inventory\n10. Quit Game");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine(""); ;
                        break;
                    case "2":
                        VisitShop(trainer, PokeShop);
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

        private static void VisitShop(Trainer trainer, Shop PokeShop)
        {
            Console.Clear();
            Console.WriteLine(PokeShop.ShowStock(trainer));
            Console.WriteLine("Would you like to buy anything? (y/n)");
            if (Console.ReadLine().ToLower() == "y")
            {
                PokeShop.BuyItem(PokeShop, trainer);
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
