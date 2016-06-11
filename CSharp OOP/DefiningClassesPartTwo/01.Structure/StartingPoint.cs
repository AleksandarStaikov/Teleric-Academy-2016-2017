using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Structure
{
    class StartingPoint
    {
        static void Main(string[] args)
        {
            var myPoint = new Point(2,4,7);

            Console.WriteLine(myPoint.ToString());
            Console.WriteLine(Point.O);
        }
    }
}
