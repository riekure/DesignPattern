using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Flyweight
{
    public class BigString
    {
        BigChar[] bigChars;

        public BigString(string str)
        {
            bigChars = new BigChar[str.Length];
            BigCharFactory factory = BigCharFactory.GetInstance();

            for (int i = 0; i < bigChars.Length; i++)
            {
                bigChars[i] = factory.GetBigChar(str[i]);
            }
        }

        public void Print()
        {
            for (int i = 0; i < bigChars.Length; i++)
            {
                bigChars[i].Print();
            }
        }
    }
}
