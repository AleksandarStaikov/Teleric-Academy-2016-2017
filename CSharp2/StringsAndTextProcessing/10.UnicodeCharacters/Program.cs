using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            var unicodeText = new StringBuilder();
            foreach (char symbol in inputText)
            {
                Console.Write("\\u{0}", Convert.ToInt32(symbol).ToString("X").PadLeft(4, '0'));
            }
            Console.WriteLine();
        }
    }
}
