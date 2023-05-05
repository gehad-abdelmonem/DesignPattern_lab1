using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP
{
    public class Team
    {
        public TeamStrategy Strategy;
        public void SetStrategy(TeamStrategy strategy)
        {
            this.Strategy = strategy;
        }
        public void PlayGame()
        {
            Strategy.Play();
        }
    }
}
