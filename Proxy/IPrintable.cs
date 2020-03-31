namespace DesignPattern.Proxy
{
    public interface IPrintable
    {
        public abstract void SetPrintName(string name);
        public abstract string GetPrinterName();
        public abstract void Print(string str);
    }
}
