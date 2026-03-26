using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBattle.Enums;

namespace PokemonBattle
{
    public class Pokemon
    {
        //Initialising Properties
        public string Name { get; init; }
        public PokemonType Type { get; init; }
        public int MaxHP { get; set; }        
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }
        public List<string> MoveSet { get; set; }
        public StatusCondition Condition { get; set; } = StatusCondition.None;

        //Properties that change mid battle
        public int CurrentHP { get; set; }

 
        //Constructor
        public Pokemon(PokemonSpecies species)
        {
            Name = species.Name;
            Type = species.Type;
            MaxHP = species.MaxHP;
            CurrentHP = species.MaxHP;
            Attack = species.Attack;
            Defence = species.Defence;
            Speed = species.Speed;
            MoveSet = species.MoveSet;
        }
    }
}
