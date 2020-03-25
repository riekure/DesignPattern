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
            //NumberGenerator generator = new RandomNumberGenerator();
            //var observer1 = new DigitObserver(generator);
            //var observer2 = new GraphObserver(generator);
            //generator.AddObserver(observer1);
            //generator.AddObserver(observer2);
            //generator.Execute();

            NumberGenerator incrementalNumberGenerator = new IncrementalNumberGenerator(10, 50, 5);
            var observer3 = new DigitObserver(incrementalNumberGenerator);
            var observer4 = new GraphObserver(incrementalNumberGenerator);
            incrementalNumberGenerator.AddObserver(observer3);
            incrementalNumberGenerator.AddObserver(observer4);
            incrementalNumberGenerator.Execute();
        }
    }
}
