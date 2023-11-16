namespace Uke1Oppgaver;

internal class Krokodillespillet
{
    public static void krokodillespillet()
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