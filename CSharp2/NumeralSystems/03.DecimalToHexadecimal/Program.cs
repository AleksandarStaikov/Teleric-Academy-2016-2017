using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03.DecimalToHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger decValue = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine(ToHexadecimal(decValue, 16));
        }

        static string ToHexadecimal(BigInteger decValue, int inputBase)
        {
            string result = "";

            do
            {
                BigInteger reminder = decValue % inputBase;
                result = hexValues[reminder] + result;
                decValue /= inputBase;
            } while (decValue > 0);

            return result;
        }

        public static Dictionary<BigInteger, char> hexValues = new Dictionary<BigInteger, char>()
        {
            {0 , '0'},
            {1 , '1'},
            {2 , '2'},
            {3 , '3'},
            {4 , '4'},
            {5 , '5'},
            {6 , '6'},
            {7 , '7'},
            {8 , '8'},
            {9 , '9'},
            {10 , 'A'},
            {11 , 'B'},
            {12 , 'C'},
            {13 , 'D'},
            {14 , 'E'},
            {15 , 'F'},
        };
    }
}
