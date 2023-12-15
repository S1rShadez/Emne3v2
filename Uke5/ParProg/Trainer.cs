namespace ParProg
{
    public class Trainer
    {
        public string Name;
        public List<Pokemon> Pokemons;
        public List<Items> Items;
        public int Money;

        public Trainer(string name, Pokemon starter, Items item)
        {
            Name = name;
            Pokemons = new List<Pokemon>(){starter};
            Items = new List<Items>(){item};
            Money = 100;
        }

        //Constructor overload for adding multiple starter items with a list
        public Trainer(string name, Pokemon starter, List<Items> items)
        {
            Name = name;
            Pokemons = new List<Pokemon>(){starter};
            Items = items;
            Money = 100;
        }


        public string getPokemons()
        {
            string pokemons = "";

            for (int i = 0; i < Pokemons.Count; i++) {
                pokemons += $"{i+1}. {Pokemons[i].name.english}:\n" +
                            $"      lvl: {Pokemons[i].@base.Level}\n" +
                            $"      HP: {Pokemons[i].@base.CurrentHP}/{Pokemons[i].@base.HP}\n" +
                            $"      Attack: {Pokemons[i].@base.Attack}\n" +
                            $"      Defense: {Pokemons[i].@base.Defense}\n" +
                            $"      SP Attack: {Pokemons[i].@base.SpAttack}\n" +
                            $"      SP Defense: {Pokemons[i].@base.SpDefense}\n" +
                            $"      Speed: {Pokemons[i].@base.Speed}\n";    
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
