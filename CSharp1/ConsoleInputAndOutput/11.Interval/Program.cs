using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Interval
{
    class Program
    {
        static void Main(string[] args)
        {
            //te
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = a + 1; i < b; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
