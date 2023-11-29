namespace Codealong;

public class Race
{
    private int speed;
    private int distance;
    private int maxDistance = 10000;
    private Random rndm = new Random();
    private string Name;

    public Race(string name)
    {
        Name = name;
    }

    public void DriveRace()
    {
        while (distance < maxDistance)
        {
            speed = rndm.Next(60, 201);
            distance += speed;
        }

        Console.WriteLine($"Bil {Name} er i mål");
    }
}