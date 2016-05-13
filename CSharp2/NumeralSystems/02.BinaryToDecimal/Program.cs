using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string binValue = Console.ReadLine();
            Console.WriteLine(ToDecimal(binValue, 2));
        }
        public static BigInteger ToDecimal(string input, int inputNumSystem)
        {
            BigInteger sum = 0;
            foreach (char item in input)
            {
                sum = (item - '0') + sum * inputNumSystem;
            }
            return sum;
        }
    }
}
