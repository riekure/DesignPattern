using DesignPattern.Prototype.framework;
using System;
using System.Text;

namespace DesignPattern.Prototype
{
    public class UnderlinePen : IProduct
    {
        private char ulchar;
        public UnderlinePen(char ulchar)
        {
            this.ulchar = ulchar;
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

            Console.WriteLine($"\"{s}\"");
            Console.Write(" ");
            
            for (int i = 0; i < length; i++)
            {
                Console.Write(ulchar);
            }
            
            Console.WriteLine("");
        }
    }
}
