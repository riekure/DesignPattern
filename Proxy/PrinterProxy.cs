using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Proxy
{
    class PrinterProxy : IPrintable
    {
        string name;
        Printer real;

        public PrinterProxy()
        {

        }

        public PrinterProxy(string name)
        {
            this.name = name;
        }

        public void SetprintName(string name)
        {
            if (real != null)
            {
                real.SetprintName(name);
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
                real = new Printer(name);
            }
        }
    }
}
