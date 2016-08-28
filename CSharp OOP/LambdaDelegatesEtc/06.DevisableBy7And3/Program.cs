using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.DevisableBy7And3
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            for (int i = 0; i < 1000; i++)
            {
                numbers.Add(i);
            }

            numbers = numbers.Where(x => (x % 5 == 0) && (x % 7 == 0)).ToList();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
