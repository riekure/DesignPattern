using DesignPattern.Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Main
{
    public class Proxy
    {
        public static void ProxyPattern(string[] args)
        {
            IPrintable p = new PrinterProxy("Alice");
            Console.WriteLine("名前は現在" + p.GetPrinterName() + "です。");
            p.SetprintName("Bob");
            Console.WriteLine("名前は現在" + p.GetPrinterName() + "です。");
            p.Print("Hello, world. ");
        }
    }
}
