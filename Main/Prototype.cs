using DesignPattern.Prototype.framework;

namespace DesignPattern.Prototype
{
    public class Prototype
    {
        public static void PrototypeMain()
        {
            // 準備
            Manager manager = new Manager();
            UnderlinePen underlinePen = new UnderlinePen('-');
            MessageBox mbox = new MessageBox('*');
            MessageBox sbox = new MessageBox('/');
            manager.Register("strong message", underlinePen);
            manager.Register("warning box", mbox);
            manager.Register("slash box", sbox);

            // 生成
            IProduct p1 = manager.Create("strong message");
            p1.Use("Hello, world.");
            IProduct p2 = manager.Create("warning box");
            p2.Use("Hello, world.");
            IProduct p3 = manager.Create("slash box");
            p3.Use("Hello, world.");
        }
    }
}
