using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.NFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fact(BigInteger.Parse(Console.ReadLine())));
        }

        static BigInteger Fact(BigInteger n)
        {
            if (n <= 1)
                return 1;
            return n * Fact(n - 1);
        }
    }
}
