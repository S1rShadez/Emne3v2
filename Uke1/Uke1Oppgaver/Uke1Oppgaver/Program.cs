

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
                                  "3. En funksjon som ikke returnerer noe\n" +
                                  "4. Hobbygenerator\n" +
                                  "5. Gjett tallet\n" +
                                  "6. Sammenlign to tall\n" +
                                  "7. Krokodillespillet");
                              
                string valg = Console.ReadLine();

                switch (valg)
                {
                    case "1":
                        variables8();
                        break;
                    case "2":
                        Console.WriteLine($"Summen av 5 + 8 er: {tallInnOgUt(5, 8)}");
                        break;
                    case "3":
                        denneReturnererIngenting();
                        break;
                    case "4":
                        hobbyGenerator();
                        break;
                    case "5":
                        gjettIgjen();
                        break;
                    case "6":
                        Console.WriteLine("Skriv et tall:");
                        int tall1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Skriv et tall til:");
                        int tall2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"Det første tallet og det andre tallet som ble skrevet er likt? {sjekkTall(tall1, tall2)}");
                        break;
                    case "7":
                        krokodillespillet();
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

        static void variables8()
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

        static void regnestykke()
        {
            int a = 5;
            double b = 3.0;
            double sum = a + b;

            Console.WriteLine("sum må være av typen double siden det kun er snakk om 1 desimal (det samme gjelder 'b')");
        }

        static int tallInnOgUt(int tall1, int tall2)
        {
            return tall1 + tall2;
        }

        static void denneReturnererIngenting()
        {
            Console.WriteLine("Denne metoden returnerer ingenting");
        }

        static void hobbyGenerator()
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

        static void gjettTallet()
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

        static void gjettIgjen()
        {
            bool fortsette = true;
            while (fortsette)
            {
                gjettTallet();
                Console.WriteLine("Vil du prøve igjen? (Y/N)");
                string input = Console.ReadLine();
                if (input.Equals("N") || input.Equals("n"))
                {
                    fortsette = false;
                }
            }
        }

        static bool sjekkTall(int tall1, int tall2)
        {
            if (tall1 == tall2)
            {
                return true;
            }

            return false;
        }

        static void krokodillespillet()
        {
            int score = 0;
            Random rndm = new Random();
            bool fortsette = true;

            while (fortsette)
            {
                int tall1 = rndm.Next(1, 11);
                int tall2 = rndm.Next(1, 11);

                Console.WriteLine($"Hvilket tall er størst, eller er de like? Svar ved å bruke '<' '>' eller '='\n" +
                                  $"{tall1} _ {tall2}");

                string valg = Console.ReadLine();
                switch (valg)
                {
                    case "<":
                        if (tall1 < tall2)
                        {
                            score++;
                            Console.WriteLine($"Korrekt! +1 poeng! Din score er nå {score}");
                        }
                        else
                        {
                            score--;
                            Console.WriteLine($"Du svarte feil.-1 poeng. Din score er nå {score}");
                        }

                        break;
                    case ">":
                        if (tall1 > tall2)
                        {
                            score++;
                            Console.WriteLine($"Korrekt! +1 poeng! Din score er nå {score}");
                        }
                        else
                        {
                            score--;
                            Console.WriteLine($"Du svarte feil. -1 poeng. Din score er nå {score}");
                        }

                        break;
                    case "=":
                        if (tall1 == tall2)
                        {
                            score++;
                            Console.WriteLine($"Korrekt! +1 poeng! Din score er nå {score}");
                        }
                        else
                        {
                            score--;
                            Console.WriteLine($"Du svarte feil.-1 poeng. Din score er nå {score}");
                        }

                        break;
                    default:
                        Console.WriteLine("Du skrev ikke inn noen gyldige svaralternativer. Spillet avsluttes og score nullstilles\n" +
                                          $"Din score ble {score}");
                        score = 0;
                        break;
                }
                Console.WriteLine("Vil du prøve igjen? (Y/N)");
                string input = Console.ReadLine();
                if (input.Equals("N") || input.Equals("n"))
                {
                    fortsette = false;
                }
            }
        }
    }
}