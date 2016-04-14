using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1, temp;
            //if n = 1 
            if (n == 1)
            {
                Console.Write(a);
                return;
            }
            else
            {
                Console.Write(a);
            }
            //if n =2
            if (n == 2 )
            {
                Console.Write(", {0}", b);
                return;
            }
            else
            {
                Console.Write(", {0}", b);
            }

            for (int i = 3; i <= n; i++)
            {
                temp = a + b;
                Console.Write(", {0}", temp);
                a = b;
                b = temp;
            }

        }
    }
}
