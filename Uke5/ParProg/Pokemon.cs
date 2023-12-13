namespace ParProg
{
    internal class Pokemon
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public Pokemon(string name) {
            Name = name;
            Level = 1;
        }

    }
}
