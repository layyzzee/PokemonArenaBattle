using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class TeamBuilder
    {
        //Creating a pokemon getter so new pokemon are selected each time
        public static Pokemon GetNewPokemon(int choice) => choice switch
        {
            1 => new Bulbasaur(),
            2 => new Charmander(),
            3 => new Squirtle(),
            4 => new Pikachu(),
            5 => new Pidgey(),
            _ => new Bulbasaur()
        };

        public static List<Pokemon> BuildPlayerTeam()
        {
            List<Pokemon> myTeam = new List<Pokemon>();
            string[] validChoices = { "1", "2", "3", "4", "5" };

            Console.WriteLine("Welcome to the Pokemon Battle Game! Prepare to choose your team.");
            Thread.Sleep(1500);
            Console.Clear();

            // Loop 3 times to get 3 Pokemon
            for (int i = 1; i <= 3; i++)
            {
                bool validSelection = false;

                while (!validSelection)
                {
                    Console.WriteLine($"Please choose Pokemon #{i}:");
                    Console.WriteLine("\n 1. Bulbasaur \n 2. Charmander \n 3. Squirtle \n 4. Pikachu \n 5. Pidgey");

                    string input = Console.ReadLine();

                    if (validChoices.Contains(input))
                    {
                        int choice = int.Parse(input);
                        Pokemon p = GetNewPokemon(choice);
                        myTeam.Add(p);

                        Console.WriteLine($"Added {p.Name} to your team!");
                        validSelection = true;

                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid Input! Please pick a number between 1 and 5.");
                    }
                }
            }
            Console.WriteLine($"Your team is: {myTeam[0].Name}, {myTeam[1].Name}, and {myTeam[2].Name}!");
            Thread.Sleep(2000);

            return myTeam;
        }



        public static List<Pokemon> BuildEnemyTeam()
        {
            //Initialising
            List<Pokemon> enemyTeam = new List<Pokemon>();
            string[] validChoices = new string[] { "1", "2", "3", "4", "5" };
            Random rand = new Random();

            for (int i = 0; i < 3; i++)
            {
                // Picks a random index between 1 and 5
                int enemyIdx = rand.Next(1, 6);
                enemyTeam.Add(GetNewPokemon(enemyIdx));
            }
            Console.WriteLine($"Enemy's team is {enemyTeam[0].Name}, {enemyTeam[1].Name}, and {enemyTeam[2].Name}!");
            Thread.Sleep(5000);
            Console.Clear();
            return (enemyTeam);
        }

    }
}
