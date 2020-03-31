using DesignPattern.FactoryMethod.framework;
using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.FactoryMethod.idcard
{
    public class IDCardFactory : Factory
    {
        IList owners { get; } = new List<string>();

        public override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        public override void RegistProduct(Product product)
        {
            var idCard = (IDCard)product;
            owners.Add(idCard.owner);
        }
    }
}
