namespace DesignPattern.State
{
    public interface IContext
    {
        public abstract void SetClock(int hour);
        public abstract void ChangeState(IState state);
        public abstract void CallSecurityCenter(string msg);
        public abstract void RecordLog(string msg);
    }
}
