namespace ParProg
{
    internal class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int MaxHealth;
        public int CurrentHP;

        public Pokemon(string name, int level = 1, int maxHealth = 12)
        {
            Name = name;
            Level = level;
            MaxHealth = maxHealth;
            CurrentHP = maxHealth;
        }

    }
}
