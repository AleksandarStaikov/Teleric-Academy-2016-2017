using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            //calculate D
            double d = (b * b) - (4 * a * c);

            // If there are two roots
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / (a * 2));
                double x2 = ((-b + Math.Sqrt(d)) / (a * 2));

                double biggerX, smallerX;
                if (x1 > x2)
                {
                    biggerX = x1;
                    smallerX = x2;
                }
                else
                {
                    biggerX = x2;
                    smallerX = x1;
                }
                Console.WriteLine("{0:F2}", smallerX);
                Console.WriteLine("{0:F2}", biggerX);
            }

            //If the root is only one 
            if (d == 0)
            {
                Console.WriteLine("{0:F2}", -b / (a * 2));
            }
            //If there are no roots
            if (d < 0)
            {
                Console.WriteLine("no real roots");
            }
        }
    }
}