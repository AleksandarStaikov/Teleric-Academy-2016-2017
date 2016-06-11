using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MultiuniverseComunication
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var separatedMessages = SplitByThree(input);
            Console.WriteLine(ToDecimal(input, 13));
        }

        public static BigInteger ToDecimal(string input, int inputNumSystem)
        {
            BigInteger sum = 0;
            var splitedMessages = SplitByThree(input);
            foreach (var item in splitedMessages)
            {
                sum = valueOfMassage[item] + sum * inputNumSystem;
            }
            return sum;
        }

        public static Dictionary<string, int> valueOfMassage = new Dictionary<string, int>
        {
        	{"CHU" ,    0  },
        	{"TEL" ,    1  },
        	{"OFT" ,    2  },
        	{"IVA" ,    3  },
        	{"EMY" ,    4  },
        	{"VNB" ,    5  },
        	{"POQ" ,    6  },
        	{"ERI" ,    7  },
        	{"CAD" ,    8  },
        	{"K-A" ,    9  },
        	{"IIA" ,    10 },
        	{"YLO" ,    11 },
        	{"PLA" ,    12 },
        };

        static string[] SplitByThree(string input)
        {
            List<string> splited = new List<string>();

            for (int i = 0; i < input.Length; i += 3)
            {
                splited.Add(input.Substring(i, 3));
            }
            return splited.ToArray();
        }

    }
}
