namespace CountChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            int amount = 0; //added counter of total letters

            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine().ToLower(); //added ToLower() so that the code handles all letters equally
                foreach (var character in text)
                {
                    counts[character]++;
                    amount++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        Console.WriteLine(character + " - " + counts[i] + " - " + counts[i]*100/amount + "%"); //calculates the percentage amount for each letter
                    }
                }
            }
        }
    }
}
