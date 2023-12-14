namespace ParProg
{
    internal class Items
    {
        public int ID;
        public string Name;
        public string Description;
        public int Amount;
        public int HealAmount;
        public Items(int id, string name, string description, int amount = 0, int healAmount = 0) { 
            ID = id;
            Name = name;
            Description = description;
            Amount = amount;
            HealAmount = healAmount;
        }
    }
}
