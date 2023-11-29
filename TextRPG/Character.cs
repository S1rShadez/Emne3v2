namespace TextRPG;

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    // Add other attributes like strength, agility, etc.

    private List<Item> Inventory { get; set; }

    public Character(string name)
    {
        Name = name;
        Health = 100;
        Mana = 50;
        Inventory = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Inventory.Add(item);
        Console.WriteLine("Item added to inventory!");
    }

    public void AddItem(List<Item> items)
    {
        foreach (var item in items)
        {
            Inventory.Add(item);
        }
        Console.WriteLine("Items added to inventory!");
    }

    public string listInventory()
    {
        string items = "";
        var i = 1;

        foreach (var item in Inventory)
        {
            string itemStats = $"{i++}. {item.Name}, {item.Description}, ";

            if (item.Attack > 0)
            {
                itemStats += $"Attack: {item.Attack}, ";
            }
            if (item.Defense > 0)
            {
                itemStats += $"Defense: {item.Defense}, ";
            }
            if (item.Durability > 0)
            {
                itemStats += $"Durability: {item.Durability}, ";
            }
            if (item.HealthRestore > 0)
            {
                itemStats += $"HealthRestore: {item.HealthRestore}, ";
            }
            if (item.ManaRestore > 0)
            {
                itemStats += $"ManaRestore: {item.ManaRestore}, ";
            }

            // Remove the last comma and space from the stats string
            if (itemStats.EndsWith(", "))
            {
                itemStats = itemStats.Substring(0, itemStats.Length - 2);
            }

            items += itemStats + "\n";
        }
        return items;
    }

    public void Introduction()
    {
        Console.WriteLine($"Hello! My name is {Name}, my HP is {Health} and my MP is {Mana}");
        Console.WriteLine($"My current inventory contains:\n{listInventory()}");
    }
}