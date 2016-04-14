using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = int.Parse(Console.ReadLine());
            double perimeter = 2 * radius * Math.PI;
            double area = radius * radius * Math.PI;

            Console.WriteLine("{0:F2} {1:F2}",perimeter ,area);
        }
    }
}
