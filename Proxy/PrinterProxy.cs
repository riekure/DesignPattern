using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy
{
    class PrinterProxy : IPrintable
    {
        string name;
        IPrintable real;
        string className;

        public PrinterProxy(string name, string className)
        {
            this.name = name;
            this.className = className;
        }

        public void SetPrintName(string name)
        {
            if (real != null)
            {
                real.SetPrintName(name);
            }
            this.name = name;
        }

        public string GetPrinterName()
        {
            return name;
        }

        public void Print(string str)
        {
            Realize();
            real.Print(str);
        }

        private void Realize()
        {
            if (real == null)
            {
                try
                {
                    var classType = Type.GetType("DesignPattern.Proxy." + className);
                    real = (IPrintable)Activator.CreateInstance(classType);
                    real.SetPrintName(name);
                }
                catch (Exception)
                {
                    Console.WriteLine("クラス " + className + "が見つかりません。");
                }
            }
        }
    }
}
