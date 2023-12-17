using ParProg;

namespace ParProg
{
    public class PokemonCSV
    {
        public string ID { get; set; }
        public string PokedexNumber { get; set; }
        public string Name { get; set; }
        public string GermanName { get; set; }
        public string JapaneseName { get; set; }
        public string Generation { get; set; }
        public string Status { get; set; }
        public string Species { get; set; }
        public string TypeNumber { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string HeightM { get; set; }
        public string WeightKg { get; set; }
        public string AbilitiesNumber { get; set; }
        public string Ability1 { get; set; }
        public string Ability2 { get; set; }
        public string AbilityHidden { get; set; }
        public string TotalPoints { get; set; }
        public string HP { get; set; }
        public string Attack { get; set; }
        public string Defense { get; set; }
        public string SpecialAttack { get; set; }
        public string SpecialDefense { get; set; }
        public string Speed { get; set; }
        public string CatchRate { get; set; }
        public string BaseFriendship { get; set; }
        public string BaseExperience { get; set; }
        public string GrowthRate { get; set; }
        public string EggTypeNumber { get; set; }
        public string EggType1 { get; set; }
        public string EggType2 { get; set; }
        public string PercentageMale { get; set; }
        public string EggCycles { get; set; }
        // Add properties for "against" values
        public string AgainstNormal { get; set; }
        public string AgainstFire { get; set; }
        public string AgainstWater { get; set; }
        public string AgainstElectric { get; set; }
        public string AgainstGrass { get; set; }
        public string AgainstIce { get; set; }
        public string AgainstFight { get; set; }
        public string AgainstPoison { get; set; }
        public string AgainstGround { get; set; }
        public string AgainstFlying { get; set; }
        public string AgainstPsychic { get; set; }
        public string AgainstBug { get; set; }
        public string AgainstRock { get; set; }
        public string AgainstGhost { get; set; }
        public string AgainstDragon { get; set; }
        public string AgainstDark { get; set; }
        public string AgainstSteel { get; set; }
        public string AgainstFairy { get; set; }
    }

}

public class readPokemonCSV
{
    public static void readCSV()
    {
        // Read CSV data from a file (adjust the path accordingly)
        var csvLines = File.ReadAllLines("../../../pokedex_.csv");

        // Create a list of Pokemon objects
        var pokemons = csvLines
            .Skip(1) // Skip the header line
            .Select(line => line.Split(','))
            .Select(values => new PokemonCSV
            {
                ID = values[0],
                PokedexNumber = values[1],
                Name = values[2],
                GermanName = values[3],
                JapaneseName = values[4],
                Generation = values[5],
                Status = values[6],
                Species = values[7],
                TypeNumber = values[8],
                Type1 = values[9],
                Type2 = values[10],
                HeightM = values[11],
                WeightKg = values[12],
                AbilitiesNumber = values[13],
                Ability1 = values[14],
                Ability2 = values[15],
                AbilityHidden = values[16],
                TotalPoints = values[17],
                HP = values[18],
                Attack = values[19],
                Defense = values[20],
                SpecialAttack = values[21],
                SpecialDefense = values[22],
                Speed = values[23],
                CatchRate = values[24],
                BaseFriendship = values[25],
                BaseExperience = values[26],
                GrowthRate = values[27],
                EggTypeNumber = values[28],
                EggType1 = values[29],
                EggType2 = values[30],
                PercentageMale = values[31],
                EggCycles = values[32],
                AgainstNormal = values[33],
                AgainstFire = values[34],
                AgainstWater = values[35],
                AgainstElectric = values[36],
                AgainstGrass = values[37],
                AgainstIce = values[38],
                AgainstFight = values[39],
                AgainstPoison = values[40],
                AgainstGround = values[41],
                AgainstFlying = values[42],
                AgainstPsychic = values[43],
                AgainstBug = values[44],
                AgainstRock = values[45],
                AgainstGhost = values[46],
                AgainstDragon = values[47],
                AgainstDark = values[48],
                AgainstSteel = values[49],
                AgainstFairy = values[50],
                // Add other "against" properties
            })
            .ToList(); // Convert to a list of Pokemon objects

        /*foreach (var pokemon in pokemons)
        {

            Console.WriteLine($"ID: {pokemon.ID}");
            Console.WriteLine($"Name: {pokemon.Name}");
            Console.WriteLine($"Type: {pokemon.Type1} / {pokemon.Type2}");
            Console.WriteLine($"Height: {pokemon.HeightM} meters");
            Console.WriteLine($"Weight: {pokemon.WeightKg} kilograms");
            // ... (print other properties)

            // Print resistances
            Console.WriteLine($"Against Normal: {pokemon.AgainstNormal}");
            Console.WriteLine($"Against Fire: {pokemon.AgainstFire}");
            // ... (print other "against" properties)
        }*/


    }

}
