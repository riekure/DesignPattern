using DesignPattern.Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Main
{
    public class Proxy
    {
        public static void ProxyMain()
        {
            IPrintable p = new PrinterProxy("Alice", "Printer");
            Console.WriteLine("名前は現在" + p.GetPrinterName() + "です。");
            p.SetPrintName("Bob");
            Console.WriteLine("名前は現在" + p.GetPrinterName() + "です。");
            p.Print("Hello, world. ");
        }
    }
}
