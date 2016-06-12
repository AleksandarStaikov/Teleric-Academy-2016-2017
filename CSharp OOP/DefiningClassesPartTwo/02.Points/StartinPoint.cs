using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Points
{
    class StartinPoint
    {
        static void Main(string[] args)
        {
            var myPoint = new Point(4, 9, 2);

            Console.WriteLine(Distance.Calculate(myPoint, Point.O));
        }
    }
}
