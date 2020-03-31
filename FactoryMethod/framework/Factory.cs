namespace DesignPattern.FactoryMethod.framework
{
    public abstract class Factory
    {
        public Product Create(string owner)
        {
            Product p = CreateProduct(owner);
            RegistProduct(p);
            return p;
        }

        public abstract Product CreateProduct(string owner);

        public abstract void RegistProduct(Product owner);
    }
}
