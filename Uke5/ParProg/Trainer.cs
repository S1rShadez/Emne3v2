namespace ParProg
{
    internal class Trainer
    {
        public string Name {get;set;}
        public List<Pokemon> Pokemons {get;set;}
        public List<Items> Items {get;set;}

        public Trainer(string name, Pokemon starter, Items item)
        {
            Name = name;
            Pokemons = new List<Pokemon>(){starter};
            Items = new List<Items>(){item};
        }


        public string getPokemons()
        {
            string pokemons = "";

            for (int i = 0; i < Pokemons.Count; i++) {
                pokemons += $"{i+1}. {Pokemons[i].Name}, HP: {Pokemons[i].CurrentHP}/{Pokemons[i].MaxHealth}, lvl: {Pokemons[i].Level}\n";    
            }

            return pokemons;
        }

        public string getItems()
        {
            string items = "";

            for(int i = 0; i < Items.Count; i++ )
            {
                items+= $"{i+1}. {Items[i].Name}, amount: {Items[i].Amount}, description: {Items[i].Description}\n";
            }

            return items;
        }
    }
}
