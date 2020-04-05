using System.Collections.Generic;

namespace DesignPattern.Prototype.framework
{
    public class Manager
    {
        readonly IDictionary<string, IProduct> showcase = new Dictionary<string, IProduct>();

        public void Register(string name, IProduct proto)
        {
            showcase.Add(name, proto);
        }

        public IProduct Create(string name)
        {
            IProduct p = showcase[name];
            return p.CreateClone();
        }
    }
}
