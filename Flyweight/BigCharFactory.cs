using System.Collections;

namespace DesignPattern.Flyweight
{
    public class BigCharFactory
    {
        Hashtable pool = new Hashtable();
        static readonly BigCharFactory singleton = new BigCharFactory();

        BigCharFactory()
        {

        }

        public static BigCharFactory GetInstance()
        {
            return singleton;
        }

        public BigChar GetBigChar(char charName)
        {
            BigChar bc = (BigChar)pool["" + charName];
            if (bc == null)
            {
                bc = new BigChar(charName);
                pool.Add("" + charName, bc);
            }
            return bc;
        }
    }
}
