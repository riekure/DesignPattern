using System;

namespace DesignPattern.Prototype.framework
{
    public interface IProduct : ICloneable
    {
        public abstract void Use(string s);
        public abstract IProduct CreateClone();
    }
}
