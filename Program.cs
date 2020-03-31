using DesignPattern.Main;
using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Strategy パターン
        //Strategy.StrategyPattern(args);

        // Observer パターン
        //Observer.ObserverPattern(args);

        // Flyweight パターン
        //Flyweight.FlyweightPattern(args);

        // Proxy パターン
        Proxy.ProxyPattern(args);

        Adapter.AdapterPattern(args);

        TemplateMethod.TemplateMethodPattern(args);
    }
}

