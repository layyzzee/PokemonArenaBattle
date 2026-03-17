namespace PokemonBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pokemon> playerTeam = TeamBuilder.BuildPlayerTeam();
            List<Pokemon> enemyTeam = TeamBuilder.BuildEnemyTeam();
            BattleManager currentBattle = new BattleManager(playerTeam, enemyTeam);
        }
    }
}
