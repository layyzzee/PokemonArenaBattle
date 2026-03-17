using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBattle
{
    public class BattleManager
    {
        //Initialise
        private List<Pokemon> PlayerTeam;
        private List<Pokemon> EnemyTeam;
        private Pokemon PlayerActivePokemon;
        private Pokemon EnemyActivePokemon;

        public BattleManager(List<Pokemon> myTeam, List<Pokemon> enemyTeam)
        {
            PlayerTeam = myTeam;
            EnemyTeam = enemyTeam;
            PlayerActivePokemon = PlayerTeam[0];
            EnemyActivePokemon = EnemyTeam[0];
        }

        public void StartBattle()
        {
            Console.WriteLine("The battle has begun!");
            while (IsBattleActive())
            {
                Console.WriteLine($"Your active Pokemon is {PlayerActivePokemon.Name} and the enemy's active Pokemon is {EnemyActivePokemon.Name}.");
                Thread.Sleep(2000);
                if (PlayerActivePokemon.Speed >= EnemyActivePokemon.Speed)
                {
                    Console.WriteLine("You go first!");  
                    //Add player logic - First do CombatEngine.cs
                }
                else
                {
                    Console.WriteLine("The enemy goes first!");
                    //Add enemy logic - First do CombatEngine.cs
                }

                //break;
            }
            
        }
        public bool IsBattleActive()
        {
            if (PlayerTeam.All(p => p.IsFainted))
            {
                Console.WriteLine("You have no more Pokemon left! You lose!");
                return false;
            }
            else if (EnemyTeam.All(p => p.IsFainted))
            {
                Console.WriteLine("The enemy has no more Pokemon left! You win!");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
