using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.State
{
    public class NightState : IState
    {
        static readonly NightState singleton = new NightState();

        public static IState GetInstance()
        {
            return singleton;
        }

        public void DoAlearm(IContext context)
        {
            context.CallSecurityCenter("非常ベル（夜間）");
        }

        public void DoClock(IContext context, int hour)
        {
            if (9 <= hour && hour <= 17)
            {
                context.ChangeState(DayState.GetInstance());
            }
        }

        public void DoPhone(IContext context)
        {
            context.CallSecurityCenter("夜間の通話録音");
        }

        public void DoUse(IContext context)
        {
            context.RecordLog("非常：夜間の金庫使用！");
        }

        public override string ToString()
        {
            return "[夜間]";
        }
    }
}
