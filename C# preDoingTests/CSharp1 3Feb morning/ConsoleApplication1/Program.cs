using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger product = 1;
            string input = string.Empty;
            input = Console.ReadLine();
            int i = 0;
            bool cheked = false;
            do
            {
                //cheks if the program ends
                if (input == "END")
                {
                    break;
                }
                //checks the ten number
                if (!cheked)
                {
                    if (i > 9)
                    {
                        Console.WriteLine(product);
                        product = 1;
                        i = 0;
                        cheked = true;
                    }
                }

                BigInteger temp = 1;
                //checks it the number is at even position
                if (i % 2 != 0)
                {
                    //calculates the product of the digits
                    for (int j = 0; j < input.Length; j++)
                    {
                        //skips the zero
                        if (((ulong)input[j] - '0') == 0)
                        {
                            continue;
                        };
                        temp *= (ulong)input[j] - '0';
                    }
                    //adds the digit product to the result
                    product *= temp;
                }
                i++;
                input = Console.ReadLine();
            } while (input != "END");

            Console.WriteLine(product);
        }
    }
}
