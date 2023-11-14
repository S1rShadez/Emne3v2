

namespace Uke1Oppgaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            variables8();
            regnestykke();
            Console.WriteLine($"Summen av 5 + 8 er: {tallInnOgUt(5, 8)}");
            denneReturnererIngenting();
            hobbyGenerator();
            gjettIgjen();
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
    }
}