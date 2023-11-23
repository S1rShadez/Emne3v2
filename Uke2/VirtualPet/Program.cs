namespace VirtualPet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hund = new GeneratePet("Frank");
            //hund.GetAge();
            //Console.WriteLine("Dyret er en: " + hund.GetAnimalType());
        }

        public class GeneratePet()
        {
            //klasse som lager et virtualpet
            //pet variabler - navn etc
            //kan ikke endre data utenfra
            //constructor(input variabler når den lages - navn)(standard verdier)(random verdier - age)
            //List "pikachu" "hund" "katt"
            //metode mate dyret
            //Metode kose med dyret
            //Metode sjekk do
            private string Name { get; } = "NoName";
            private int Age { get; }
            private bool Hungry { get; set; }
            private int HungerLevel { get; set; }
            private bool Happy { get; set; }
            private int HappyLevel { get; }
            private string AnimalType { get; }
            private readonly string[] _animals = { "Katt", "Hund", "Pikachu", "Kanin" };

            public GeneratePet(string name) : this()
            {
                Name = name;
                Age = new Random().Next(0, 11);
                Hungry = false;
                HungerLevel = 75;
                Happy = true;
                HappyLevel = 75;
                AnimalType = _animals[new Random().Next(0, 4)];
            }

            public void FeedPet()
            {
                HungerLevel += 20;
                CheckHungry();
            }

            private void CheckHungry()
            {

                if (HungerLevel >= 50)
                {
                    Console.WriteLine($"{Name} is not Hungry");
                    Hungry = false;
                }
                else if (HungerLevel <= 50)
                {
                    Console.WriteLine($"{Name} is Hungry");
                    Hungry = true;
                }
            }

            public string GetName()
            {
                return Name;
            }

            public int GetAge()
            {
                return Age;
            }

            public bool GetHungry()
            {
                return Hungry;
            }

            public bool GetHappy()
            {
                return Happy;
            }

            public string GetAnimalType()
            {
                return AnimalType;
            }
        }
    }
}
