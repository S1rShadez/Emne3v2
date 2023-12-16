using Newtonsoft.Json;
using System.Reflection;
using System.Text;

namespace ParProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Finds the relative path of the JSON document
            //var path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "..\\..\\..\\pokemonData\\pokedex.json");
            //var path = Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\pokedex.json");

            //readPokemonCSV.readCSV();

            // Read the contents of the JSON file into a string variable
            string json = File.ReadAllText("..\\..\\..\\pokedex.json", Encoding.Default);

            // Deserialize the JSON string into an object
            List<Pokemon> pokemon = JsonConvert.DeserializeObject<List<Pokemon>>(json);

            Console.WriteLine("Welcome to the Pokemon game!");
            Console.WriteLine("Please enter your name:");
            string tName = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Please choose your starter pokemon!\n1. Treecko\n2. Torchic\n3. Mudkip");
            Pokemon starter;

            switch (Console.ReadLine())
            {
                case "1":
                    starter = starterSelector(pokemon, "Treecko");
                    break;
                case "2":
                    starter = starterSelector(pokemon, "Torchic");
                    break;
                case "3":
                    starter = starterSelector(pokemon, "Mudkip");
                    break;
                default:
                    starter = starterSelector(pokemon, "Pikachu");
                    break;
            }

            List<Items> starterItems = new() { new(1, "Pokeball", "A ball used to catch pokemon", amount: 5), new(2, "Potion", "Restores 20 HP for a pokemon", amount: 5, healAmount: 20) };

            Trainer trainer = new(tName, starter, starterItems);

            Game.run(trainer);
        }

        private static Pokemon starterSelector(List<Pokemon> pokemon, string name)
        {
            Pokemon starter = pokemon.Find(p => p.name.english == name);
            starter.@base.CurrentHP = starter.@base.HP;
            return starter;
        }
    }

}