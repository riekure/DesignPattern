using System;

namespace DesignPattern.TemplateMethod
{
    public class CharDisplay : AbstractDisplay
    {
        char ch;

        public CharDisplay(char ch)
        {
            this.ch = ch;
        }

        public override void Open()
        {
            Console.Write("<<");
        }

        public override void Print()
        {
            Console.Write(ch);
        }

        public override void Close()
        {
            Console.WriteLine(">>");
        }
    }
}
