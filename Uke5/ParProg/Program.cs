using Newtonsoft.Json;

namespace ParProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the contents of the JSON file into a string variable
            string json = File.ReadAllText("C:\\Users\\S1rShadez\\Documents\\GitHub\\Emne3v2\\Uke5\\ParProg\\pokemonData\\pokedex.json");

            // Deserialize the JSON string into an object
            List<Pokemon> pokemon = JsonConvert.DeserializeObject<List<Pokemon>>(json);

            Console.WriteLine("Welcome to the Pokemon game!\n");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please choose your starter pokemon!\n1. Treecko\n2. Torchic\n3. Mudkip");
            Pokemon starter;

            switch (Console.ReadLine())
            {
                case "1":
                    starter = pokemon.Find(p => p.name.english == "Treecko");
                    break;
                case "2":
                    starter = pokemon.Find(p => p.name.english == "Torchic");
                    break;
                case "3":
                    starter = pokemon.Find(p => p.name.english == "Mudkip");
                    break;
                default:
                    starter = pokemon.Find(p => p.name.english == "Pikachu");
                    break;
            }

            List<Items> starterItems = new List<Items>() { new(1, "Pokeball", "A ball used to catch pokemon", 5), new(2, "Potion", "Restores 20 HP for a pokemon", 5, healAmount: 20) };

            Trainer trainer = new Trainer(name, starter, starterItems);

            Game.run(trainer);
        }
    }
}