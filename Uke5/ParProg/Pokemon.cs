namespace ParProg
{
    public class Pokemon
    {

        public int id { get; set; }
        public Name name { get; set; }
        public List<string> type { get; set; }
        public Base @base { get; set; }


        public class Name
        {
            public string english { get; set; }
            public string japanese { get; set; }
            public string chinese { get; set; }
            public string french { get; set; }
        }

        public class Base
        {

            public int Level { get; set; } = 1;
            public int HP { get; set; }
            public int CurrentHP { get; set; } 
            public int Attack { get; set; }
            public int Defense { get; set; }
            public int SpAttack { get; set; }
            public int SpDefense { get; set; }
            public int Speed { get; set; }
        }
    }
}
