namespace Uke1Oppgaver;

public class Pokemon
{
    public int Level { get; set; }
    public string PokemonName { get; set;}
    public int Health { get; set; }
    public string PokemonType { get; set; }

    public Pokemon()
    {
    }

    public Pokemon(string pokemonName)
    {
        PokemonName = pokemonName;
    }
    public Pokemon(int level, string pokemonName, int health, string pokemonType)
    {
        Level = level;
        PokemonName = pokemonName;
        Health = health;
        PokemonType = pokemonType;
    }

    public string showInfo()
    {
        return $"{PokemonName} er en {PokemonType}, dens level er {Level} og den har {Health}hp";
    }
}