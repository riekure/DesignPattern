using DesignPattern.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Main
{
    public class TemplateMethod
    {
        public static void TemplateMethodPattern(string[] args)
        {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello, world.");
            AbstractDisplay d3 = new StringDisplay("こんにちは。");
            d1.Display();
            d2.Display();
            d3.Display();
        }
    }
}
