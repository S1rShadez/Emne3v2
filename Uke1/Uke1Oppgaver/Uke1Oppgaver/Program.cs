

namespace Uke1Oppgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;

            while (cont)
            {
                Console.WriteLine("Skriv tallet til oppgaven du vil se:\n" +
                                  "1. 8 variabler\n" +
                                  "2. Regnestykke\n" +
                                  "2.5.Desimal\n" +
                                  "3. En funksjon som ikke returnerer noe\n" +
                                  "4. Hobbygenerator\n" +
                                  "5. Gjett tallet\n" +
                                  "6. Sammenlign to tall\n" +
                                  "7. Krokodillespillet\n" +
                                  "8. Lag din egen pokemon!");
                              
                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        Variables8();
                        break;
                    case "2":
                        Console.WriteLine($"Summen av 5 + 8 er: {TallInnOgUt(5, 8)}");
                        break;
                    case "2.5":
                        Desimal();
                        break;
                    case "3":
                        DenneReturnererIngenting();
                        break;
                    case "4":
                        HobbyGenerator();
                        break;
                    case "5":
                        GjettIgjen();
                        break;
                    case "6":
                        SammenlignTall();
                        break;
                    case "7":
                        Krokodillespillet.krokodillespillet();
                        break;
                    case "8":
                        LagPokemon();
                        break;
                    default:
                        Console.WriteLine("Ingen oppgave valgt.");
                        break;
                } 

                Console.WriteLine("Se flere oppgaver? (Y/N)");
                string svar = Console.ReadLine();
                if (svar.Equals("N") || svar.Equals("n"))
                {
                    cont = false;
                }
            }
        }

        private static void SammenlignTall()
        {
            Console.WriteLine("Skriv et tall:");
            int tall1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv et tall til:");
            int tall2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Det første tallet og det andre tallet som ble skrevet er likt? {SjekkTall(tall1, tall2)}");
        }

        private static void LagPokemon()
        {
            Random rndm = new Random();
            int level = rndm.Next(0, 11);
            int health = rndm.Next(0, 21);
            Console.WriteLine("Lag din egen pokemon!\nSkriv inn hvilken type pokemon:");
            string pokemonType = Console.ReadLine();
            Console.WriteLine("Skriv nå inn navnet til pokemonen:");
            string name = Console.ReadLine();
            Console.WriteLine(
                $"Flott! Pokemonen din, {name}, har fått en tilfeldig level: {level} og en tilfeldig mengde HP: {health}");
            var pokemon = new Pokemon(level, name, health, pokemonType);
            Console.WriteLine(pokemon.showInfo());
        }

        static void Variables8()
        {
            // int, long, float, decimal, double, string, char og bool.
            int tall = 1;
            long lang = 9223372036854645L;
            float flyt = 2.345f;
            decimal desimal = 7.965465136515616513251651651321m;
            double dobbel = 2.402823e28;
            string tekst = "tekst";
            char tegn = 'A';
            bool boolean = false;

            Console.WriteLine($"Int = {tall}, long = {lang}, float = {flyt}, decimal = {desimal}, double = {dobbel}, string = {tekst}, char = {tegn}, bool = {boolean}");
        }

        static void Desimal()
        {
            int a = 5;
            double b = 3.0;
            double sum = a + b;

            Console.WriteLine("sum må være av typen double siden det kun er snakk om 1 desimal (det samme gjelder 'b')");
        }

        static int TallInnOgUt(int tall1, int tall2)
        {
            return tall1 + tall2;
        }

        static void DenneReturnererIngenting()
        {
            Console.WriteLine("Denne metoden returnerer ingenting");
        }

        static void HobbyGenerator()
        {
            bool fortsette = true;
            Random rndm = new Random();
            string[] hobbyListe = {"Magiker", "Danser", "Fekter", "Komiker", "Fotballspiller"};

            while (fortsette)
            {
                Console.WriteLine("Hei! Fortell meg navnet ditt så skal du få en ny hobby!");
                string name = Console.ReadLine();
                Console.WriteLine($"{name} du er nå en {hobbyListe[rndm.Next(0, 5)]}");
                Console.WriteLine("Fortsette med nye hobbyer? (Y/N)");
                string svar = Console.ReadLine();
                if (svar.Equals("N") || svar.Equals("n"))
                {
                    fortsette = false;
                }
            }
        }

        static void GjettTallet()
        {
            Random rndm = new Random();
            int newNumber = rndm.Next(1, 101);
            bool fortsette = true;
            int antallGjett = 0;

            Console.WriteLine("Gjett ett tall mellom 1 og 100");
            while (fortsette)
            {
                int gjett = Convert.ToInt32(Console.ReadLine());
                if (gjett > newNumber)
                {
                    Console.WriteLine("Du gjettet for høyt! prøv igjen!");
                    antallGjett++;
                }
                else if (gjett < newNumber)
                {
                    Console.WriteLine("Du gjettet for lavt! Prøv igjen!");
                    antallGjett++;
                }
                else if (gjett == newNumber)
                {
                    antallGjett++;
                    Console.WriteLine($"Du gjettet riktig tall! Tallet var: {gjett} \nDu brukte {antallGjett} forsøk");
                    fortsette = false;
                }
            }
        }

        static void GjettIgjen()
        {
            bool fortsette = true;
            while (fortsette)
            {
                GjettTallet();
                Console.WriteLine("Vil du prøve igjen? (Y/N)");
                string input = Console.ReadLine();
                if (input.Equals("N") || input.Equals("n"))
                {
                    fortsette = false;
                }
            }
        }

        static bool SjekkTall(int tall1, int tall2)
        {
            if (tall1 == tall2)
            {
                return true;
            }

            return false;
        }
    }
}