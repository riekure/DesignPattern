using System;
using System.IO;
using System.Text;

namespace DesignPattern.Flyweight
{
    public class BigChar
    {
        char charName;
        string fontData;

        public BigChar(char charName)
        {
            this.charName = charName;
            try
            {
                string pass = String.Format("C:\\Users\\ryo\\Documents\\DesignPattern\\DesignPattern\\Flyweight\\big{0}.txt", this.charName);
                StreamReader reader = new StreamReader(pass, Encoding.Default);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    fontData += line + "\n";
                }
            }
            catch (IOException)
            {
                this.fontData = charName + "?";
            }
        }

        public void Print()
        {
            Console.WriteLine(fontData);
        }
    }
}
