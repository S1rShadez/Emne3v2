using System.Runtime.CompilerServices;

namespace Uke1Oppgaver;

public class Pikachu
{
    public string Name { get; set; }
    public int Health { get; set; }

    public void showInfo()
    {
        Console.WriteLine($"Pikachus name is {Name} and it has {Health}hp");
    }
}