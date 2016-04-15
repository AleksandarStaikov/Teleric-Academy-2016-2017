using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PlayCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = 0;
            if (int.TryParse(input, out number))
            {
                if (number > 1 && number < 11)
                {
                    Console.WriteLine("yes {0}", number);
                } 
            }
        }
    }
}
