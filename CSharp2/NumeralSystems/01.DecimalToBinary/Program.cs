using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger decValue = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(DecimaToAnything(decValue, 2));

        }

        static string DecimaToAnything(BigInteger decValue, int baseValue)
        {
            string result = "";

            do
            {
                BigInteger reminder = decValue % baseValue;
                result = reminder + result;
                decValue /= baseValue;
            } while (decValue > 0);
            return result;
        }
    }
}
