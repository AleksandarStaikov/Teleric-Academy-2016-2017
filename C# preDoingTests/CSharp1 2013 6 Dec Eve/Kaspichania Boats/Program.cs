using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaspichania_Boats
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{0}", new string('.', size));
            Console.WriteLine("{0}***{0}", new string('.', size - 1));

            for (int i = size - 2, d = 1; i > 0; d++, i--)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', d));

            }
            Console.WriteLine(new string('*', size * 2 + 1));
            for (int i = 1, d = size - 2; i <= size / 2; d--, i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', i), new string('.', d));
            }
            Console.WriteLine("{0}{1}{0}", new string('.', (size + 1) / 2), new string('*', size));
        }
    }
}
