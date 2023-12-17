using Console = System.Console;

namespace ParProg;

public class Adventure
{
    static bool cont = true;

    public static void StartAdventure()
    {
        while (cont)
        {
            Console.WriteLine("Where would you like to adventure?");
            Console.WriteLine("1. Forests(WIP)\n2. Deserts(WIP)\n3. Caves(WIP)\n4. Grasslands(WIP)\n5. The seas(WIP)\n10. Back to main menu");

            switch (Console.ReadLine())
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "10":
                    cont = false;
                    break;
                default:
                    Game.NotValid();
                    break;
            }
        }
    }

    public void AdventureForest(){}

    public void AdventureDesert(){}

    public void AdventureCave(){}

    public void AdventureGrass(){}

    public void AdventureWater(){}

    private void Combat(){}
}