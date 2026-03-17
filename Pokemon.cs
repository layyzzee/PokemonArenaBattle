using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public abstract class Pokemon
    {
        //Initialising Properties
        public string Name { get; init; }
        public PokemonType MyType { get; init; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Speed { get; set; }

        //Constructor
        public Pokemon(string name, PokemonType myType, int maxHP, int attack, int defence, int speed)
        {
            Name = name;
            MyType = myType;
            MaxHP = maxHP;
            CurrentHP = maxHP;
            Attack = attack;
            Defence = defence;
            Speed = speed;
        }


        //Status Properties
        public bool IsFainted;
        public bool IsBurning;
        public bool IsPoisoned;
        public bool IsFrozen;
        public bool IsDizzy;
        public bool IsFlying;



    }
}
