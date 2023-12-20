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

            //List<SavePokemon> gen1List = new List<SavePokemon>();


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
                foreach (var pMove in pokemon.Result.Moves)
                {

                    //item1.VersionGroupDetails.ForEach(x => Console.WriteLine(x.VersionGroup.Name));

                    foreach (var genMove in pMove.VersionGroupDetails)
                    {
                        if (genMove.VersionGroup.Name.Equals("ruby-sapphire"))
                        {
                            Console.WriteLine(pMove.Move.Name);
                            //Console.WriteLine(item2.VersionGroup.Name);
                            Console.WriteLine($"Learned at lvl: {genMove.LevelLearnedAt}");
                            Console.WriteLine("Learned by: " + genMove.MoveLearnMethod.Name);

                            Console.WriteLine("Move stats:");
                            var move = GetMovesAsync(pMove.Move.Name);

                            Console.WriteLine("-Damage type: " + move.Result.DamageClass.Name);
                            Console.WriteLine("-Elemental type: " + move.Result.Type.Name);
                            if (move.Result.Accuracy.HasValue) Console.WriteLine($"-Accuracy: {move.Result.Accuracy.Value}");
                            else Console.WriteLine("-Accuracy: 0");
                            if (move.Result.Power.HasValue) Console.WriteLine("-Power: " + move.Result.Power.Value);
                            else Console.WriteLine("-Power: 0");
                            Console.WriteLine("-Crit rate: " + move.Result.Meta.CritRate);
                            if (move.Result.Pp.HasValue) Console.WriteLine("-PP: " + move.Result.Pp.Value);
                            else Console.WriteLine("-PP: 0");
                            Console.WriteLine("-Target type: " + move.Result.Target.Name);
                            Console.WriteLine("-Ailment chance: " + move.Result.Meta.AilmentChance + "%");
                            Console.WriteLine("-Stat change chance: " + move.Result.Meta.StatChance + "%");
                            Console.WriteLine("-Flinch chance: " + move.Result.Meta.FlinchChance + "%");
                            if (move.Result.EffectChance.HasValue) Console.WriteLine("-Effect chance: " + move.Result.EffectChance + "%");
                            else Console.WriteLine("-Effect chance: 0%");
                            if (move.Result.Meta.MinTurns.HasValue) Console.WriteLine("-Min turns: " + move.Result.Meta.MinTurns.Value);
                            else Console.WriteLine("-Effect lasts 1 turn");
                            if (move.Result.Meta.MaxTurns.HasValue) Console.WriteLine("-Max turns: " + move.Result.Meta.MaxTurns.Value);
                            else Console.WriteLine("-Effect lasts 1 turn");
                            if (move.Result.Meta.MinHits.HasValue) Console.WriteLine("-Min hits: " + move.Result.Meta.MinHits.Value);
                            else Console.WriteLine("-Hits 1 time");
                            if (move.Result.Meta.MaxHits.HasValue) Console.WriteLine("-Max hits: " + move.Result.Meta.MaxHits.Value);
                            else Console.WriteLine("-Hits 1 time");
                            Console.WriteLine("-Heal amount: " + move.Result.Meta.Healing);
                            if (move.Result.Meta.Drain > 0) Console.WriteLine("-HP drain: " + move.Result.Meta.Drain + "%");
                            else Console.WriteLine("-HP drain: 0%");
                            if (move.Result.Meta.Drain < 0) Console.WriteLine("-Recoil dmg: " + move.Result.Meta.Drain + "%");
                            else Console.WriteLine("-Recoil dmg: 0%");
                            move.Result.EffectEntries.ForEach(x => Console.WriteLine("-Effect: " + x.Effect));

                            Console.WriteLine();
                        }
                    }
                }



                //Console.ReadKey();
            }
        }

        public class SavePokemon
        {
            string Name;
            List<string> BaseStats;
            List<string> Type;
            List<Moves> MovesList;

            public SavePokemon(string name, List<string> baseStats, List<string> types, List<Moves> movesList)
            {
                Name = name;
                BaseStats = baseStats;
                Type = types;
                MovesList = movesList;
            }


            public class Moves
            {
                string MoveName;
                string DamageClass;
                string ElementalType;
                int Accuracy;
                int Power;
                int CritRate;
                int Pp;
                string TargetType;
                int AilmentCh;
                int StatCh;
                int FlinchCh;
                int EffectCh;
                int MinTurns;
                int MaxTurns;
                int MinHits;
                int MaxHits;
                int Healing;
                int Drain;
                List<string> Effects;

                public Moves(string moveName, string damageClass, string elementalType, int accuracy, int power, int critRate, int pp, string targetType, int ailmentCh, int statCh, int flinchCh, int effectCh, int minTurns, int maxTurns, int minHits, int maxHits, int healing, int drain, List<string> effects)
                {
                    MoveName = moveName;
                    DamageClass = damageClass;
                    ElementalType = elementalType;
                    Accuracy = accuracy;
                    Power = power;
                    CritRate = critRate;
                    Pp = pp;
                    TargetType = targetType;
                    AilmentCh = ailmentCh;
                    StatCh = statCh;
                    FlinchCh = flinchCh;
                    EffectCh = effectCh;
                    MinTurns = minTurns;
                    MaxTurns = maxTurns;
                    MinHits = minHits;
                    MaxHits = maxHits;
                    Healing = healing;
                    Drain = drain;
                    Effects = effects;
                }
            }

        }
    }
}
