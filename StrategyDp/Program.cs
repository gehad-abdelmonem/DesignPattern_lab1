using StrategyDP;

namespace StrategyDp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team(); 
            team.SetStrategy(new AttackStrategy());
            team.PlayGame();
        }
    }
}