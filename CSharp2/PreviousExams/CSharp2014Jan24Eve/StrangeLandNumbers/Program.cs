using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StrangeLandNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ToDecimal(input, 7));
        }

        public static BigInteger ToDecimal(string input, int inputNumSystem)
        {
            var words = SplitSentance(input);
            BigInteger sum = 0;
            foreach (var word in words)
            {
                sum = GetIntValue[word] + sum * inputNumSystem;
            }
            return sum;
        }

        public static string[] SplitSentance(string input)
        {
            var words = new List<string>();
            int i = -1;

            foreach (var letter in input)
            {
                if (char.IsLower(letter))
                {
                    words.Add(letter.ToString());
                    i++;
                    continue;
                }
                else
                {
                    words[i] += letter;
                }
            }
            return words.ToArray();
        }

        public static Dictionary<string, int> GetIntValue = new Dictionary<string, int>()
         {
            {"f" ,     0 },
            {"bIN" ,   1 },
            {"oBJEC" , 2 },
            {"mNTRAVL",3 },
            {"lPVKNQ", 4 },
            {"pNWE",   5 },
            {"hT",     6 },

         };
    }
}
