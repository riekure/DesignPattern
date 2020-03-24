using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.Observer
{
    public abstract class NumberGenerator
    {
        IList observers = new List<IObserver<NumberGenerator>>();

        public void AddObserver(IObserver<NumberGenerator> observer)
        {
            observers.Add(observer);
        }

        public void DeleteObserver(IObserver<NumberGenerator> observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (IObserver<NumberGenerator> _observer in observers)
            {
                _observer.OnCompleted();
            }
        }

        public abstract int GetNumber();
        public abstract void Execute();
    }
}