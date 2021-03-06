﻿using DesignPattern.Main;
using DesignPattern.Prototype;
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
        Proxy.ProxyMain();

        Adapter.AdapterMain();

        TemplateMethod.TemplateMethodMain();

        FactoryMethod.FactoryMethodMain();

        Prototype.PrototypeMain();
    }
}

