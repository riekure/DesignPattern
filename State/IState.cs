namespace DesignPattern.State
{
    public interface IState
    {
        public abstract void DoClock(IContext context, int hour);
        public abstract void DoUse(IContext context);
        public abstract void DoAlearm(IContext context);
        public abstract void DoPhone(IContext context);

    }
}
