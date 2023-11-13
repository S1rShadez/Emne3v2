namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hei! Hva heter du?");
            string name = Console.ReadLine();
            Console.WriteLine($"Velkommen {name}!");
            Console.ReadKey();
        }
    }
}