﻿using System;

namespace DesignPattern.Strategy
{
    public class WinningStrategy : IStrategy
    {
        readonly Random random;
        Boolean won = false;
        Hand prevHand;

        public WinningStrategy(int seed)
        {
            random = new Random(seed);
        }

        public Hand NextHand()
        {
            if (!won)
            {
                prevHand = Hand.GetHand(random.Next(3));
            }
            return prevHand;
        }

        public void Study(bool win)
        {
            won = win;
        }
    }
}
