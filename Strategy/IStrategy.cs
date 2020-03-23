using System;

namespace DesignPattern.Strategy
{
    public interface IStrategy
    {
        public abstract Hand NextHand();
        public abstract void Study(Boolean win);
    }
}
