namespace ParProg
{
    internal class Trainer
    {
        public string Name {get;set;}
        public List<Pokemon> Pokemons {get;set;}
        public List<Items> Items {get;set;}

        public Trainer(string name, Pokemon starter, Items pokeballs)
        {
            Name = name;
            Pokemons = new List<Pokemon>(){starter};
            Items = new List<Items>(){pokeballs};
        }


        public string getPokemons()
        {
            string pokemons = "";

            for (int i = 0; i < Pokemons.Count; i++) {
                pokemons += $"{i+1}. {Pokemons[i].Name}\n";    
            }

            return pokemons;
        }

        public string getItems()
        {
            string items = "";

            for(int i = 0; i < Items.Count; i++ )
            {
                items+= $"{i+1}. {Items[i].Name}\n";
            }

            return items;
        }
    }
}
