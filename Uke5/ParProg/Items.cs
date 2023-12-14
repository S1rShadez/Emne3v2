namespace ParProg
{
    internal class Items
    {
        public string Name;
        public string Description;
        public int Amount;
        public Items(string name, string description, int amount = 0) { 
            Name = name;
            Description = description;
            Amount = amount;
        }
    }
}
