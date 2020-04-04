using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Singleton
{
    public class Singleton
    {
        static readonly Singleton singleton = new Singleton();
        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }

        public static Singleton GetInstance()
        {
            return singleton;
        }
    }
}
