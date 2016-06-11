using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GSM
{
    class Startup
    {
        static void Main()
        {

            var bat = new Battery(100, 30, "de da znam", BatteryType.LiIon);
            var disp = new Display(4, 16000000);
            var myPhone = new Gsm(disp, bat, "samsung", "S4 mini", "Az", 650);

            for (int i = 0; i < 10; i++)
            {
                myPhone.AddCall(new Call(DateTime.Now.ToString(), "087830" + i, i));
            }
            myPhone.RemoveLastCall();
            Console.WriteLine(myPhone.CallsCost(1));
            myPhone.ClearCallHistoy();
            Console.WriteLine(myPhone.CallsCost(1));


            Console.WriteLine(Gsm.Phone4.Model + " " + Gsm.Phone4.Manufacturer);
        }
    }

}
