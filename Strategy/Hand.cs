using System;

namespace DesignPattern.Strategy
{
    public class Hand
    {
        public const int HANDVALUE_GUU = 0;
        public const int HANDVALUE_CHO = 1;
        public const int HANDVALUE_PAA = 2;

        public static Hand[] hand =
        {
            new Hand(HANDVALUE_GUU),
            new Hand(HANDVALUE_CHO),
            new Hand(HANDVALUE_PAA)
        };

        private static readonly String[] name =
        {
            "グー",
            "チョキ",
            "パー"
        };

        private int handValue;
        private Hand(int handValue)
        {
            this.handValue = handValue;
        }

        public static Hand GetHand(int handValue)
        {
            return hand[handValue];
        }

        public Boolean IsStrongerThan(Hand h)
        {
            return Fight(h) == 1;
        }

        public Boolean IsWeakerThan(Hand h)
        {
            return Fight(h) == -1;
        }

        // 引き分けは0, thisの勝ちなら1, hの勝ちなら-1
        int Fight(Hand h)
        {
            if (this == h)
            {
                return 0;
            }
            else if ((this.handValue + 1) % 3 == h.handValue)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override String ToString()
        {
            return name[handValue];
        }
    }
}
