using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    public class DayState : IState
    {
        static readonly DayState singleton = new DayState();

        public static IState GetInstance()
        {
            return singleton;
        }

        public void DoAlearm(IContext context)
        {
            context.CallSecurityCenter("非常ベル（昼間）");
        }

        public void DoClock(IContext context, int hour)
        {
            if (hour < 9 || 17 <= hour)
            {
                context.ChangeState(NightState.GetInstance());
            }
        }

        public void DoPhone(IContext context)
        {
            context.CallSecurityCenter("通常の通話（昼間）");
        }

        public void DoUse(IContext context)
        {
            context.RecordLog("金庫使用（昼間）");
        }

        public override string ToString()
        {
            return "[昼間]";
        }
    }
}
