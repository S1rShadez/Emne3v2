using Parprogrammering_Arthur;

namespace ParProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start();
        }

        private static List<Filmer> filmer = new List<Filmer>()
        {
            new Filmer("The Terminator", 1984, "In this science fiction classic, a cyborg is sent from the future to assassinate the mother of the future leader of a human resistance movement. A soldier is also sent back in time to protect her.", "James Cameron", "Arnold Schwarzenegger, Linda Hamilton, Michael Biehn, Paul Winfield, Lance Henriksen"),
            new Filmer("Inception", 2010, "A mind-bending science fiction thriller where a skilled thief enters the dreams of others to steal their deepest secrets.", "Christopher Nolan", "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page, Tom Hardy, Ken Watanabe"),
            new Filmer("The Shawshank Redemption", 1994, "A poignant drama about a man who befriends fellow inmates while serving a life sentence in Shawshank State Penitentiary, using his intelligence and hope to navigate the challenges.", "Frank Darabont", "Tim Robbins, Morgan Freeman, Bob Gunton, William Sadler, Clancy Brown"),
            new Filmer("Pulp Fiction", 1994, "Quentin Tarantino's iconic film weaves together multiple interconnected stories, featuring hitmen, a boxer, a gangster's wife, and a pair of armed robbers.", "Quentin Tarantino", "John Travolta, Uma Thurman, Samuel L. Jackson, Bruce Willis, Ving Rhames"),
        };

        protected static void start()
        {
            while (true)
            {
                switch (AskInt("Vil du:\n1. legge til film\n2. søke etter film\n3. for å avslutte"))
                {
                    case 1:
                        Console.Clear();
                        AddMovie();
                        break;
                    case 2:
                        Console.Clear();
                        ShowMadeMovie();
                        break;
                    default:
                        Console.Clear();
                        Environment.Exit(1);
                        break;
                }
            }
        }

        private static void AddMovie()
        {
            filmer.Add(new Filmer(Ask("Hva heter filmen?"), AskInt("Når kom den ut?"), Ask("Hva handler filmen om?"), Ask("Hva heter regissør?"), Ask("Skuespillere med komma(,)")));
            Console.Clear();
        }

        private static void ShowMadeMovie()
        {
            Console.WriteLine("What Movie you want to see?");
            var i = 0;
            foreach (var film in filmer)
            {
                i++;
                Console.WriteLine(i + ". " + film.PrintTitle());
            }

            var input = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            filmer[input - 1].PrintInfoOnMovie();
        }

        private static string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        private static int AskInt(string question)
        {
                return Convert.ToInt32(Ask(question));
        }
    }
}

//Start();
//private static List<Parson> Parsoner = new List<Parson>();

//private static void Start()
//{
//    bool noe = true;
//    while (noe)
//    {
//        Parsoner.Add(new Parson(Ask("Hva heter du?"), AskInt("Hvor gammel er du?"), Ask("Hvilken hår farge har du?"),
//            Ask("Hva vil du fortelle om deg selv?"), Ask("Hvilke hobbier har du?")));
//        if ("n" == Ask("Vil du legge til ny parson? y/n"))
//        {
//            noe = false;
//            foreach (var person in Parsoner)
//            {
//                person.SkrivOmMeg();
//                if ("y" == Ask("Vil du starte på nytt? y/n"))
//                {
//                    Parsoner = new List<Parson>();
//                    Start();
//                }
//                else Environment.Exit(1);
//            }
//        }
//    }

//}
    

