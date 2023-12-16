using System.Runtime.CompilerServices;

namespace ParProg;

public class Shop
{
    string Name { get; set; }
    public string Description { get; set; }
    public List<Items> ShopStock { get; set; }

    public Shop(string name = "PokeShop", string description = "A shop you can buy pokeItems at")
    {
        Name = name;
        Description = description;
    }

    public Shop(List<Items> shopStock, string name = "PokeShop", string description = "A shop you can buy pokeItems at")
    {
        Name = name;
        Description = description;
        ShopStock = shopStock;
    }

    public string ShowStock(Trainer trainer)
    {
        string stock = $"Welcome to {Name}, {trainer.Name}!\n" +
            $"Wallet: {trainer.Money}\n\n";

        for (int i = 0; i < ShopStock.Count; i++)
        {
            stock += $"{i + 1}. {ShopStock[i].Name}\n" +
                $"      In stock: {ShopStock[i].Amount}\n" +
                $"      Description: {ShopStock[i].Description}\n" +
                $"      Price: {ShopStock[i].Price}\n";
        }

        return stock;
    }

    public void BuyItem(Shop shop, Trainer trainer)
    {
        Console.Clear();
        Console.WriteLine(shop.ShowStock(trainer));
        Console.WriteLine("Please enter the ID of the product you'd like to purchase:");
        int purchaseID = Convert.ToInt16(Console.ReadLine());
        var shopItem = shop.ShopStock.Find(x => x.ID == purchaseID);
        Console.Clear();
        Console.WriteLine($"Please enter how many you would like of {shopItem.Name}\nPrice: {shopItem.Price}");
        int amount = Convert.ToInt16(Console.ReadLine());

        if (trainer.Money >= (shopItem.Price * amount) && shopItem.Amount >= amount)
        {
            trainer.Items.Find(x => x.ID == shopItem.ID).Amount += amount;
            trainer.Money -= shopItem.Price * amount;
            shopItem.Amount -= amount;
            Console.WriteLine($"{amount} x {shopItem.Name} successfully purchased");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        else if (shopItem.Amount < amount)
        {
            Console.WriteLine($"The amount ({amount}) you tried to purchase is more than the current stock ({shopItem.Amount}). Please try a lower amount");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            shop.BuyItem(shop, trainer);
        }
        else if (trainer.Money < (shopItem.Price * amount))
        {
            Console.WriteLine($"Not enough money to purchase {amount} x {shopItem.Name}, please try a lower amount or buy something else");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            shop.BuyItem(shop, trainer);
        }
    }
}