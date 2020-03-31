using System;

namespace DesignPattern.Adapter
{
    public class Banner
    {
        string str;
        public Banner(string str)
        {
            this.str = str;
        }

        public void ShowWithParen()
        {
            Console.WriteLine("(" + str + ")");
        }

        public void ShowWithAster()
        {
            Console.WriteLine("*" + str + "*");
        }
    }
}
