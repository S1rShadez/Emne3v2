namespace TextRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var starterSword = new Item("Sword", "A standard iron sword every new adventurer has", attack: 10, durability: 20);
            var starterShield = new Item("Shield", "A basic wooden shield for protection", defense: 5, durability: 25);
            var starterArmor = new Item("Armor", "A simple leather armor for beginners", defense: 8, durability: 30);
            var starterPotion = new Item("Health Potion", "A small health potion to aid in healing", healthRestore: 20);
            var starterBoots = new Item("Boots", "Sturdy leather boots for traversing various terrains",defense: 3, durability: 15);
            var starterRing = new Item("Ring", "A plain ring said to bring luck to the wearer");
            var starterScroll = new Item("Scroll", "A mysterious scroll with ancient writing");
            var starterDagger = new Item("Dagger", "A small, sharp dagger for close combat", attack: 8, durability: 15);
            var starterBow = new Item("Bow", "A basic wooden bow for ranged attacks", attack: 8, durability: 20);
            var starterArrows = new Item("Arrows", "A quiver of arrows for the bow", attack: 2);
            var starterCloak = new Item("Cloak", "A weathered cloak to keep the adventurer warm", defense: 3, durability: 10);
            var starterTorch = new Item("Torch", "A lit torch to illuminate dark areas");
            var starterRations = new Item("Rations", "A pack of basic provisions for sustenance", healthRestore: 5);
            var starterLockpick = new Item("Lockpick", "A simple tool for picking locks", durability: 10);
            var starterMap = new Item("Map", "A rough map of the surrounding areas");
            var starterGloves = new Item("Gloves", "Leather gloves for protection and grip", defense: 2, durability: 8);
            var starterWhetstone = new Item("Whetstone", "For sharpening blades and keeping them in good condition");
            var starterBackpack = new Item("Backpack", "A sturdy backpack for carrying items", itemCap: 25, durability: 12);
            var starterCompass = new Item("Compass", "To find direction when navigating");

// These additional items aim to diversify the adventurer's starting inventory for various situations in your text-based RPG
            

            var Player1 = new Character("S1rShadez");
            Player1.AddItem(new List<Item>{starterSword, starterShield, starterArmor, starterPotion, starterBoots, starterRing, starterScroll, starterDagger, starterBow, starterArrows, starterCloak, starterTorch, starterRations, starterLockpick, starterMap, starterGloves, starterWhetstone, starterBackpack, starterCompass
            });

            Player1.Introduction();
        }
    }
}
