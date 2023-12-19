using PokeApiNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PokemonAPI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instantiate client
            PokeApiClient pokeClient = new PokeApiClient();

            async Task<Pokemon> GetPokemonAsync(string name)
            {
                var poke = await pokeClient.GetResourceAsync<Pokemon>(name);
                //Console.WriteLine("BOOM");
                return poke;
            }

            //var pokemon = GetPokemonAsync("pikachu");



            async Task<Generation> GetGenerationAsync()
            {
                var gens = await pokeClient.GetResourceAsync<Generation>("1");
                return gens;
            }

            async Task<Move> GetMovesAsync(string name)
            {
                var moves = await pokeClient.GetResourceAsync<Move>(name);
                return moves;
            }

            var gen1 = GetGenerationAsync();

            //Task.WaitAll(pokemon, gen1);
            //Console.WriteLine(pokemon.Result.Name);


            foreach (var item in gen1.Result.PokemonSpecies)
            {
                var pokemon = GetPokemonAsync(item.Name);
                Console.WriteLine("\nPokemon:\n");
                Console.WriteLine(pokemon.Result.Name);

                pokemon.Result.Stats.ForEach(x => Console.WriteLine(x.Stat.Name + ": " + x.BaseStat));
                pokemon.Result.Types.ForEach(x => Console.WriteLine(x.Type.Name));

                //Console.ReadKey();

                //pokemon.Result.Forms.ForEach(x => Console.WriteLine(x.Name));

                //Console.WriteLine("\nMoves:");
                //pokemon.Result.Moves.ForEach(x => Console.WriteLine(x.Move.Name));


                Console.WriteLine("\nMoves:\n");
                foreach (var item1 in pokemon.Result.Moves)
                {

                    //item1.VersionGroupDetails.ForEach(x => Console.WriteLine(x.VersionGroup.Name));

                    foreach (var item2 in item1.VersionGroupDetails)
                    {
                        if (item2.VersionGroup.Name.Equals("ruby-sapphire"))
                        {
                            Console.WriteLine(item1.Move.Name);
                            Console.WriteLine(item2.VersionGroup.Name);
                            Console.WriteLine($"Learned at lvl: {item2.LevelLearnedAt}");
                            Console.WriteLine("Learned by: " + item2.MoveLearnMethod.Name);

                            Console.WriteLine("Move stats:");
                            var move = GetMovesAsync(item1.Move.Name);

                            Console.WriteLine("-Damage type: " + move.Result.DamageClass.Name);
                            if (move.Result.Accuracy.HasValue) Console.WriteLine($"- Accuracy: {move.Result.Accuracy.Value}");
                            if (move.Result.Power.HasValue) Console.WriteLine("- Power: " + move.Result.Power.Value);
                            Console.WriteLine("-Crit rate: " + move.Result.Meta.CritRate);
                            if (move.Result.Pp.HasValue) Console.WriteLine("- PP: " + move.Result.Pp.Value);
                            Console.WriteLine("-Target type: " + move.Result.Target.Name);
                            Console.WriteLine("-Ailment chance: " + move.Result.Meta.AilmentChance + "%");
                            Console.WriteLine("-Stat change chance: " + move.Result.Meta.StatChance + "%");
                            Console.WriteLine("-Flinch chance: " + move.Result.Meta.FlinchChance);
                            if (move.Result.EffectChance.HasValue) Console.WriteLine("-Effect chance: " + move.Result.EffectChance + "%");
                            if (move.Result.Meta.MinTurns.HasValue) Console.WriteLine("-Min turns: " + move.Result.Meta.MinTurns.Value);
                            if (!move.Result.Meta.MinTurns.HasValue) Console.WriteLine("-Effect lasts 1 turn");
                            Console.WriteLine("-Heal amount: " + move.Result.Meta.Healing);
                            move.Result.EffectEntries.ForEach(x => Console.WriteLine("-Effect: " + x.Effect));
                            Console.WriteLine();
                        }
                    }
                }



                Console.ReadKey();
            }
        }
    }
}
