using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SubStringInText
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();

            int occurances = 0;
            int indexOfNextText = text.IndexOf(pattern);

            while (indexOfNextText != -1)
            {
                occurances++;   
                indexOfNextText = text.IndexOf(pattern, indexOfNextText + 1);
            }
            Console.WriteLine(occurances);
        }
    }
}
