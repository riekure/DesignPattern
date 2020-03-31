using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    public class StringDisplay : AbstractDisplay
    {
        string str;
        int width;

        public StringDisplay(string str)
        {
            this.str = str;
            Encoding sjisEnc = Encoding.GetEncoding("UTF-8");
            this.width = sjisEnc.GetByteCount(str);
        }

        public override void Open()
        {
            PrintLine();
        }

        public override void Print()
        {
            Console.WriteLine("|" + str + "|");
        }

        public override void Close()
        {
            PrintLine();
        }

        void PrintLine()
        {
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }
    }
}
