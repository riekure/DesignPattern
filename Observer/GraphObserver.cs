using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    public class GraphObserver : IObserver<NumberGenerator>
    {
        NumberGenerator generator;
        public GraphObserver(NumberGenerator numberGenerator)
        {
            this.generator = numberGenerator;
        }

        public void OnCompleted()
        {
            var count = generator.GetNumber();
            Console.Write("GraphObserver:");

            for (int i = 0; i < count; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("");
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(NumberGenerator value)
        {
            throw new NotImplementedException();
        }
    }
}
