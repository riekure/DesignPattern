using DesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Main
{
    public class Observer
    {
        public static void ObserverPattern(string[] args)
        {
            NumberGenerator generator = new RandomNumberGenerator();
            var observer1 = new DigitObserver(generator);
            var observer2 = new GraphObserver(generator);
            generator.AddObserver(observer1);
            generator.AddObserver(observer2);
            generator.Execute();
        }
    }
}
