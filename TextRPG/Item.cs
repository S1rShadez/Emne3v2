namespace TextRPG;

public class Item
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int Durability { get; set; }
    public int HealthRestore { get; set; }
    public int ManaRestore { get; set; }
    public int ItemCap { get; set; }

    public Item(string name, string description, int attack = 0, int defense = 0, int durability = 0, int healthRestore = 0, int manaRestore = 0, int itemCap = 0)
    {
        Name = name;
        Description = description;
        Attack = attack;
        Defense = defense;
        Durability = durability;
        HealthRestore = healthRestore;
        ManaRestore = manaRestore;
        ItemCap = itemCap;
    }
}