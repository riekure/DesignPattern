using DesignPattern.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Main
{
    public class Adapter
    {
        public static void AdapterMain()
        {
            IPrint p = new PrintBanner("Hello");
            p.PrintWeak();
            p.PrintStrong();
        }
    }
}
