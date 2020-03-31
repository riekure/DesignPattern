using System;

namespace DesignPattern.Adapter
{
    public class PrintBanner : Banner, IPrint
    {
        public PrintBanner(string str) : base(str)
        {
        }

        public void PrintStrong()
        {
            ShowWithParen();
        }

        public void PrintWeak()
        {
            ShowWithAster();
        }
    }
}
