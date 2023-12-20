using PokeApiNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;

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

            int progress = gen1.Result.PokemonSpecies.Count();
            int progression = progress/100;
            int currentProgression = progression;

            //Task.WaitAll(pokemon, gen1);
            //Console.WriteLine(pokemon.Result.Name);

            List<SavePokemon> gen1List = new List<SavePokemon>();


            foreach (var item in gen1.Result.PokemonSpecies)
            {
                var pokemon = GetPokemonAsync(item.Name);
                //Console.WriteLine("\nPokemon:\n");
                //Console.WriteLine(pokemon.Result.Name);
                string pName = pokemon.Result.Name; //NAME

                List<(string statName, int baseStat)> pStats = new List<(string statName, int baseStat)> { }; //STATS LIST
                //pokemon.Result.Stats.ForEach(x => Console.WriteLine(x.Stat.Name + ": " + x.BaseStat));
                pokemon.Result.Stats.ForEach(x => pStats.Add((x.Stat.Name, x.BaseStat)));

                List<string> pType = new List<string> { }; //TYPES LIST
                //pokemon.Result.Types.ForEach(x => Console.WriteLine(x.Type.Name));
                pokemon.Result.Types.ForEach(x => pType.Add(x.Type.Name));

                //Console.ReadKey();

                //pokemon.Result.Forms.ForEach(x => Console.WriteLine(x.Name));

                //Console.WriteLine("\nMoves:");
                //pokemon.Result.Moves.ForEach(x => Console.WriteLine(x.Move.Name));

                List<SavePokemon.Moves> saveMoves = new List<SavePokemon.Moves>();

                //Console.WriteLine("\nMoves:\n");
                foreach (var pMove in pokemon.Result.Moves)
                {

                    //item1.VersionGroupDetails.ForEach(x => Console.WriteLine(x.VersionGroup.Name));

                    foreach (var genMove in pMove.VersionGroupDetails)
                    {
                        if (genMove.VersionGroup.Name.Equals("ruby-sapphire"))
                        {
                            string mName = pMove.Move.Name; //MOVE NAME
                            //Console.WriteLine(pMove.Move.Name);
                            //Console.WriteLine(item2.VersionGroup.Name);

                            int learnedLvl = genMove.LevelLearnedAt; //LVL LEARNED AT
                            //Console.WriteLine($"Learned at lvl: {genMove.LevelLearnedAt}");

                            string learnMethod = genMove.MoveLearnMethod.Name; //LEARN METHOD
                            //Console.WriteLine("Learned by: " + genMove.MoveLearnMethod.Name);

                            //Console.WriteLine("Move stats:");
                            var move = GetMovesAsync(pMove.Move.Name);

                            string dmgType = move.Result.DamageClass.Name; //DMG TYPE
                            //Console.WriteLine("-Damage type: " + move.Result.DamageClass.Name);

                            string elementType = move.Result.Type.Name; //ELEMENT TYPE
                            //Console.WriteLine("-Elemental type: " + move.Result.Type.Name);

                            int accuracy; //ACCURACY
                            if (move.Result.Accuracy.HasValue) accuracy = move.Result.Accuracy.Value;
                            else accuracy = 0;
                            /*if (move.Result.Accuracy.HasValue) Console.WriteLine($"-Accuracy: {move.Result.Accuracy.Value}");
                            else Console.WriteLine("-Accuracy: 0");*/

                            int power; //POWER
                            if (move.Result.Power.HasValue) power = move.Result.Power.Value;
                            else power = 0;
                            /*if (move.Result.Power.HasValue) Console.WriteLine("-Power: " + move.Result.Power.Value);
                            else Console.WriteLine("-Power: 0");*/

                            int critRate = move.Result.Meta.CritRate; //CRIT RATE
                            //Console.WriteLine("-Crit rate: " + move.Result.Meta.CritRate);

                            int pp; //PP!!!!!!
                            if (move.Result.Pp.HasValue) pp = move.Result.Pp.Value;
                            else pp = 0;
                            /*if (move.Result.Pp.HasValue) Console.WriteLine("-PP: " + move.Result.Pp.Value);
                            else Console.WriteLine("-PP: 0");*/

                            string targetType = move.Result.Target.Name; //TARGET TYPE
                            //Console.WriteLine("-Target type: " + move.Result.Target.Name);

                            int ailmentChance = move.Result.Meta.AilmentChance; //AILMENT CHANCE
                            //Console.WriteLine("-Ailment chance: " + move.Result.Meta.AilmentChance + "%");

                            int statChance = move.Result.Meta.StatChance; //STAT CHANGE CHANCE
                            //Console.WriteLine("-Stat change chance: " + move.Result.Meta.StatChance + "%");

                            int flinchChance = move.Result.Meta.FlinchChance; //FLINCH CHANCE
                            //Console.WriteLine("-Flinch chance: " + move.Result.Meta.FlinchChance + "%");

                            int? effectChance; //EFFECT CHANCE
                            if (move.Result.EffectChance.HasValue) effectChance = move.Result.EffectChance;
                            else effectChance = 0;
                            /*if (move.Result.EffectChance.HasValue) Console.WriteLine("-Effect chance: " + move.Result.EffectChance + "%");
                            else Console.WriteLine("-Effect chance: 0%");*/

                            int minTurns;
                            if (move.Result.Meta.MinTurns.HasValue) minTurns = move.Result.Meta.MinTurns.Value;
                            else minTurns = 1;
                            /*if (move.Result.Meta.MinTurns.HasValue) Console.WriteLine("-Min turns: " + move.Result.Meta.MinTurns.Value);
                            else Console.WriteLine("-Effect lasts 1 turn");*/

                            int maxTurns; //MAX TURNS
                            if (move.Result.Meta.MaxTurns.HasValue) maxTurns = move.Result.Meta.MaxTurns.Value;
                            else maxTurns = 1;
                            /*if (move.Result.Meta.MaxTurns.HasValue) Console.WriteLine("-Max turns: " + move.Result.Meta.MaxTurns.Value);
                            else Console.WriteLine("-Effect lasts 1 turn");*/

                            int minHits; //MIN HITS
                            if (move.Result.Meta.MinHits.HasValue) minHits = move.Result.Meta.MinHits.Value;
                            else minHits = 1;
                            /*if (move.Result.Meta.MinHits.HasValue) Console.WriteLine("-Min hits: " + move.Result.Meta.MinHits.Value);
                            else Console.WriteLine("-Hits 1 time");*/

                            int maxHits; //MAX HITS
                            if (move.Result.Meta.MaxHits.HasValue) maxHits = move.Result.Meta.MaxHits.Value;
                            else maxHits = 1;
                            /*if (move.Result.Meta.MaxHits.HasValue) Console.WriteLine("-Max hits: " + move.Result.Meta.MaxHits.Value);
                            else Console.WriteLine("-Hits 1 time");*/

                            int healAmount = move.Result.Meta.Healing; //HEAL AMOUNT
                            //Console.WriteLine("-Heal amount: " + move.Result.Meta.Healing);

                            int drain = 0; //HP DRAIN
                            int recoil = 0; //HP RECOIL
                            if (move.Result.Meta.Drain > 0) drain = move.Result.Meta.Drain;
                            else if (move.Result.Meta.Drain < 0) recoil = move.Result.Meta.Drain;
                            
                            /*if (move.Result.Meta.Drain > 0) Console.WriteLine("-HP drain: " + move.Result.Meta.Drain + "%");
                            else Console.WriteLine("-HP drain: 0%");*/
                            /*if (move.Result.Meta.Drain < 0) Console.WriteLine("-Recoil dmg: " + move.Result.Meta.Drain + "%");
                            else Console.WriteLine("-Recoil dmg: 0%");*/

                            List<string> effectText = new List<string>();
                            move.Result.EffectEntries.ForEach(x => effectText.Add(x.Effect));
                            //move.Result.EffectEntries.ForEach(x => Console.WriteLine("-Effect: " + x.Effect));

                            //Console.WriteLine();
                            saveMoves.Add(new SavePokemon.Moves(mName, dmgType, elementType, accuracy, power, critRate, pp, targetType, ailmentChance, statChance, flinchChance, effectChance, minTurns, maxTurns, minHits, maxHits, healAmount, drain, recoil, effectText));
                        }
                    }
                }
                var pokemonSaved = new SavePokemon(pName, pStats, pType, saveMoves);
                gen1List.Add(pokemonSaved);
                currentProgression += progression;

                Console.Clear();
                Console.WriteLine("Currently saved pokemon: " + currentProgression);

                //Console.ReadKey();
            }
            
            string json = JsonConvert.SerializeObject(gen1List);
            //Console.WriteLine(json);
            File.WriteAllText("C:\\Users\\S1rShadez\\Documents\\GitHub\\Emne3v2\\Uke5\\PokemonAPI\\pokeData.json", json);
            Console.WriteLine("JSON file saved!");
        }

        public class SavePokemon
        {
            public string Name;
            public List<(string statName, int baseStat)> BaseStats;
            public List<string> Type;
            public List<Moves> MovesList;

            public SavePokemon(string name, List<(string statName, int baseStat)> baseStats, List<string> types, List<Moves> movesList)
            {
                Name = name;
                BaseStats = baseStats;
                Type = types;
                MovesList = movesList;
            }


            public class Moves
            {
                public string MoveName;
                public string DamageClass;
                public string ElementalType;
                public int Accuracy;
                public int Power;
                public int CritRate;
                public int Pp;
                public string TargetType;
                public int AilmentCh;
                public int StatCh;
                public int FlinchCh;
                public int? EffectCh;
                public int MinTurns;
                public int MaxTurns;
                public int MinHits;
                public int MaxHits;
                public int Healing;
                public int Drain;
                public int Recoil;
                public List<string> Effects;

                public Moves(string moveName, string damageClass, string elementalType, int accuracy, int power, int critRate, int pp, string targetType, int ailmentCh, int statCh, int flinchCh, int? effectCh, int minTurns, int maxTurns, int minHits, int maxHits, int healing, int drain, int recoil, List<string> effects)
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
                    Recoil = recoil;
                    Effects = effects;
                }
            }

        }
    }
}
