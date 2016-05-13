using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.HexadecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexValue = Console.ReadLine();
            Console.WriteLine(DecimaToAnything(ToDecimal(hexValue, 16), 2));
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
        public static BigInteger ToDecimal(string input, int inputNumSystem)
        {
            BigInteger sum = 0;
            foreach (char item in input)
            {
                sum = hexValues[item] + sum * inputNumSystem;
            }
            return sum;
        }

        public static Dictionary<char, BigInteger> hexValues = new Dictionary<char, BigInteger>()
        {
            {'0', 0  },
            {'1', 1  },
            {'2', 2  },
            {'3', 3  },
            {'4', 4  },
            {'5', 5  },
            {'6', 6  },
            {'7', 7  },
            {'8', 8  },
            {'9', 9  },
            {'A', 10 },
            {'B', 11 },
            {'C', 12 },
            {'D', 13 },
            {'E', 14 },
            {'F', 15 },
        };
    }
}
