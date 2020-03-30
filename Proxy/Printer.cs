using System;
using System.Threading;

namespace DesignPattern.Proxy
{
    public class Printer : IPrintable
    {
        string name;

        public Printer()
        {
            heavyJob("Printer のインスタンス生成中");
        }

        public Printer(string name)
        {
            this.name = name;
            heavyJob("Printer のインスタンス(" + name + ")を生成中");
        }

        private void heavyJob(string msg)
        {
            Console.WriteLine(msg);
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    Thread.Sleep(1000);
                }
                catch (ThreadInterruptedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.Write(".");
            }
            Console.WriteLine("完了。");
        }

        public void SetprintName(string name)
        {
            this.name = name;
        }

        public string GetPrinterName()
        {
            return name;
        }

        public void Print(string str)
        {
            Console.WriteLine("=== " + str + " ===");
        }
    }
}
