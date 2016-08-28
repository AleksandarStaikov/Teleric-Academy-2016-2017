using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class MyTimer
    {
        private int interval;

        public MyTimer(int miliseconds)
        {
            this.interval = miliseconds;
        }

        public void InvokeDelegate(Action method)
        {
            var time = new System.Timers.Timer();

            while (true)
            {
                method.Invoke();
                Thread.Sleep(interval);
            }
        }
    }
}
