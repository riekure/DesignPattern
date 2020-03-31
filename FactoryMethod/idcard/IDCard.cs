using DesignPattern.FactoryMethod.framework;
using System;

namespace DesignPattern.FactoryMethod.idcard
{
    public class IDCard : Product
    {
        public string owner { get; private set; }

        public IDCard(string owner)
        {
            Console.WriteLine($"{owner}のカードを作ります。");
            this.owner = owner;
        }

        public override void Use()
        {
            Console.WriteLine($"{owner}のカードを使います。");
        }
    }
}
