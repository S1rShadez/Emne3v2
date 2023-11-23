namespace MiniOverloads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintWelcomeMessage();
        }

        static void PrintWelcomeMessage(string name = "Terje")
        {
            Console.WriteLine($"Hei og velkommen {name}!");
        }
    }
}
