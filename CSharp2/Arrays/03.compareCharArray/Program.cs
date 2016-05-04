using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.compareCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            int result =  String.Compare(first, second);
            if (result < 0 )
            {
                Console.WriteLine("<");
            }
            else if (result == 0)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine(">");
            }
        }
    }
}
