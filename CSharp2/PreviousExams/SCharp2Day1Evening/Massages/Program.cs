using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Massages
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstMassage = Console.ReadLine();
            string operation = Console.ReadLine();
            string secondMassage = Console.ReadLine();

            if (operation == "-")
            {
                Console.WriteLine(DecToAnything(ToDecimal(firstMassage, 10) - ToDecimal(secondMassage, 10), 10));
            }
            else
            {
                Console.WriteLine(DecToAnything(ToDecimal(firstMassage, 10) + ToDecimal(secondMassage, 10), 10));
            }
        }

        public static BigInteger ToDecimal(string input, int inputNumSystem)
        {
            var symbols = SplitByThree(input);

            BigInteger sum = 0;
            foreach (var item in symbols)
            {
                sum = valueOfMassage[item] + sum * inputNumSystem;
            }
            return sum;
        }

        static string[] SplitByThree(string input)
        {
            List<string> splited = new List<string>();

            for (int i = 0; i < input.Length; i += 3)
            {
                splited.Add(input.Substring(i, 3));
            }
            return splited.ToArray();
        }


        public static Dictionary<string, int> valueOfMassage = new Dictionary<string, int>
        {
        	{"cad" ,    0  },
        	{"xoz" ,    1  },
        	{"nop" ,    2  },
        	{"cyk" ,    3  },
        	{"min" ,    4  },
        	{"mar" ,    5  },
        	{"kon" ,    6  },
        	{"iva" ,    7  },
        	{"ogi" ,    8  },
        	{"yan" ,    9  },
        };

        static string DecToAnything(BigInteger decValue, int outputBase)
        {
            string result = "";
            do
            {
                BigInteger reminder = decValue % outputBase;
                result = intToDec[reminder] + result;
                decValue /= outputBase;
            } while (decValue > 0);

            return result;
        }

        public static Dictionary<BigInteger, string> intToDec = new Dictionary<BigInteger, string>
        {
        	{0 , "cad"},
        	{1 , "xoz"},
        	{2 , "nop"},
        	{3 , "cyk"},
        	{4 , "min"},
        	{5 , "mar"},
        	{6 , "kon"},
        	{7 , "iva"},
        	{8 , "ogi"},
        	{9 , "yan"},
        };
    }
}