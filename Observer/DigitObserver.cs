using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    public class DigitObserver : IObserver<NumberGenerator>
    {
        NumberGenerator generator;

        public DigitObserver(NumberGenerator numberGenerator)
        {
            this.generator = numberGenerator;
        }

        public void OnCompleted()
        {
            Console.WriteLine("DigitObserver:" + generator.GetNumber().ToString());
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
