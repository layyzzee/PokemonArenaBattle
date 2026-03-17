using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class TeamBuilder
    {
        public static void BuildTeam()
        {
            //Creating a reference list of available Pokemon
            List<Pokemon> availablePokemon = new List<Pokemon>()
            {
                new Bulbasaur(),
                new Charmander(),
                new Squirtle(),
                new Pikachu(),
                new Pidgey()
            }



            //Initialising
            List<Pokemon> team = new List<Pokemon>();
            Console.WriteLine("Welcome to the Pokemon Battle Game!");

            //Building the team
            Console.WriteLine("Please choose your first Pokemon:");

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n 1. Bulbasaur \n 2. Charmander \n 3. Squirtle \n 4. Pikachu \n 5. Pidgey");
            }
            string input1 = Console.ReadLine();
            int int1 = Int32.Parse(input1);
            team.Add(new Bulbasaur());
            Console.WriteLine("Please choose your second Pokemon:");
            team.Add(new Charmander());
            Console.WriteLine("Please choose your third Pokemon:");
            team.Add(new Squirtle());
            Console.WriteLine($"Congratulations! You built your team with {Pokemon.Name}, {Pokemon.Name}, and {Pokemon.Name}!");
                
        }
    }
}
