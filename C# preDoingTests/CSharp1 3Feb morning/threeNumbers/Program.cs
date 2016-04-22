using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal A = decimal.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            decimal biggest = A;
            decimal smallest = B;

            if (B > A)
            {
                biggest = B;
            }
            if (C > A && C > B)
            {
                biggest = C;
            }


            if (A < B)
            {
                smallest = A;
            }
            if (C < B && C < A)
            {
                smallest = C;
            }

            decimal mid = (A + B + C) / 3;

            Console.WriteLine(biggest);
            Console.WriteLine(smallest);
            Console.WriteLine("{0:f2}", mid);
        }
    }
}
