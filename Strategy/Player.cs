using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Strategy
{
    public class Player
    {
        readonly string name;
        readonly IStrategy strategy;
        int winCount;
        int loseCount;
        int gameCount;

        public Player(string name, IStrategy strategy)
        {
            this.name = name;
            this.strategy = strategy;
        }

        public Hand NextHand()
        {
            return strategy.NextHand();
        }

        public void Win()
        {
            strategy.Study(true);
            winCount++;
            gameCount++;
        }

        public void Lose()
        {
            strategy.Study(true);
            loseCount++;
            gameCount++;
        }

        public void Even()
        {
            strategy.Study(true);
            gameCount++;
        }

        public override String ToString()
        {
            return "[" + name + ":" + gameCount + "games, " + winCount + "win, " + loseCount + "  lose" + "]";
        }
    }
}
