namespace ParProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pokemon game!");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please choose your starter pokemon!\n1. Treecko\n2. Torchic\n3. Mudkip");
            Pokemon starter;

            switch (Console.ReadLine())
            {
                case "1":
                    starter = new Pokemon("Treecko");
                    break;
                case "2":
                    starter = new Pokemon("Torchic");
                    break;
                case "3":
                    starter = new Pokemon("Mudkip");
                    break;
                default:
                    starter = new Pokemon("Pikachu");
                    break;
            }
            
            Trainer trainer = new Trainer(name, starter, new Items("Pokeballs", "A ball used to catch pokemon", 5));

            Game.run(trainer);
        }
    }
}