using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Console.ReadLine().Length;
            Console.WriteLine(Factorial(n));
        }
        public static long Factorial(int n)
        {
            if (n == 0)//The condition that limites the method for calling itself
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
