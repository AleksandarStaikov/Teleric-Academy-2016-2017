using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.IntDoubleString
{
    class Program
    {
        static void Main(string[] args)
        {
            string varType = Console.ReadLine();
            if (varType == "string")
            {
                string word = Console.ReadLine();
                Console.WriteLine("{0}*",word);
            }
        }
    }
}
