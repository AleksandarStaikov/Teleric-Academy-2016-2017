using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decoding
{
    class Program
    {
        static void Main(string[] args)
        {
             int salt = int.Parse(Console.ReadLine());
        string code = Console.ReadLine();
        double currentchar;
        double printval = 0;
        for (int i = 0; i < code.Length-1; i++)
        {
            currentchar = (int)code[i];
            printval = currentchar;

            if (currentchar == 64)
            {
                break;
            }
            if (currentchar >= 65 && currentchar <= 90 || currentchar >= 97 && currentchar <= 122)
            {
                printval = currentchar * salt + 1000;
            }
            else if (currentchar >= 48 && currentchar <= 57)
            {
                printval = currentchar + salt + 500;
            }
            else
            {
                printval = currentchar - salt;
            }

            if (i % 2 == 0)
            {
                printval = printval / 100;
                Console.WriteLine("{0:f2}", printval);
            }
            else
            {
                printval = printval * 100;
                Console.WriteLine(printval);
            }
        }
    }
}
