namespace ParProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer("Ash", new Pokemon("Pikachu"), new Items("Pokeballs", "A ball used to catch pokemon"));

            Action.run(trainer);
        }
    }
}