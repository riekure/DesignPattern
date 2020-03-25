using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    class IncrementalNumberGenerator : NumberGenerator
    {
        int number;
        int stopCount;
        int increment;

        public IncrementalNumberGenerator(int number, int stopCount, int increment)
        {
            this.number = number;
            this.stopCount = stopCount;
            this.increment = increment;
        }

        public override void Execute()
        {
            while(number < stopCount)
            {
                number += increment;
                NotifyObservers();
            }
        }

        public override int GetNumber()
        {
            return number;
        }
    }
}
