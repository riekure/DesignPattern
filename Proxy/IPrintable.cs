namespace DesignPattern.Proxy
{
    public interface IPrintable
    {
        public abstract void SetprintName(string name);
        public abstract string GetPrinterName();
        public abstract void Print(string str);
    }
}
