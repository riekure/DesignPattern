using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Memento
{
    public class Memento
    {
        public int Money { get; set; }
        public IList<string> Fruits
        {
            get { return new List<string>(); }
        }

        public Memento(int money)
        {
            this.Money = money;
        }

        public void AddFruit(string fruit)
        {
            Fruits.Add(fruit);
        }
    }
}
