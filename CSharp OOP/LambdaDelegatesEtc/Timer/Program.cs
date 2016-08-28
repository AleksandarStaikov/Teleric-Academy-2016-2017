using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            Action command = new Action(Print);
            var repeater = new MyTimer(100);

            repeater.InvokeDelegate(command);
        }

        public static void Print()
        {
            Console.WriteLine(DateTime.Now.Second + " " + DateTime.Now.Millisecond);
        }
    }
}
