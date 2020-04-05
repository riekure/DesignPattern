using DesignPattern.Prototype.framework;
using System;
using System.Text;

namespace DesignPattern.Prototype
{
    public class MessageBox : IProduct
    {
        char decochar;

        public MessageBox(char decochar)
        {
            this.decochar = decochar;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public IProduct CreateClone()
        {
            return (IProduct)this.Clone();
        }

        public void Use(string s)
        {
            Encoding sjisEnc = Encoding.GetEncoding("UTF-8");
            int length = sjisEnc.GetByteCount(s);

            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }

            Console.WriteLine("");
            Console.WriteLine($"{decochar} {s} {decochar}");

            for (int i = 0; i < length + 4; i++)
            {
                Console.Write(decochar);
            }
            Console.WriteLine("");
        }
    }
}
