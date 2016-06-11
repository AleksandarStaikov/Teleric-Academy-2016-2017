using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeCatCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            var words = input.Split(' ');
            string decodedTest = "";
            foreach (var word in words)
            {
                decodedTest += DecToAnything(ToDecimal(word, 21), 26) + " ";
            }
            Console.WriteLine(decodedTest.Trim());
        }

        public static BigInteger ToDecimal(string input, int inputNumSystem)
        {
            BigInteger sum = 0;
            foreach (char item in input)
            {
                sum = (item - 'a') + sum * inputNumSystem;
            }
            return sum;
        }

        static string DecToAnything(BigInteger decValue, int outputBase)
        {
            string result = "";
            do
            {
                BigInteger reminder = decValue % outputBase;
                result = (char)('a' + reminder) + result;
                decValue /= outputBase;
            } while (decValue > 0);
            return result;
        }
    }
}
