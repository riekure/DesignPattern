using DesignPattern.Flyweight;
using System;

namespace DesignPattern.Main
{
    public class Flyweight
    {
        public static void FlyweightPattern(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("please enter a number !");
                Console.ReadLine();
                System.Environment.Exit(0);

            }
            BigString bigString = new BigString(args[0]);

            bigString.Print();
            Console.ReadLine();
        }
    }
}
