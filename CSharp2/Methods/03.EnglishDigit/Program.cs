using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            num = num % 10;
            Console.WriteLine(DigitName(num));

        }
        static string DigitName(int digit)
        {
            switch (digit)
            {
                case 0: return "zero"; break;
                case 1: return "one"; break;
                case 2: return "two"; break;
                case 3: return "three"; break;
                case 4: return "four"; break;
                case 5: return "five"; break;
                case 6: return "six"; break;
                case 7: return "seven"; break;
                case 8: return "eight"; break;
                case 9: return "nine"; break;
                default: return "You fucked up";
                    break;
            }
        }
    }
}
