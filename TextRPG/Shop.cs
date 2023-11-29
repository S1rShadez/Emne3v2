namespace TextRPG;

public class Shop
{
    private string Name { get; set; }
    private List<Item> ShopItems { get; set; }
    public Shop(string name, List<Item> shopItems)
    {
        Name = name;
        ShopItems = shopItems;
    }
}