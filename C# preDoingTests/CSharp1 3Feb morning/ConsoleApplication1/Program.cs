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
            BigInteger  product = 1;
            string input = string.Empty;
            input = Console.ReadLine();
            int i = 0;
            bool cheked = false;

            do
            {
                ulong temp = 1;

                //checking if it is end of the sequence
                if (input == "END")
                {
                    break;
                }

                //checking the numbers count
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
                
                //check if the number is at an odd position
                if (i % 2 != 0)
                {
                    //going through number`s digits
                    for (int j = 0; j < input.Length; j++)
                    {
                        //escape the zeros
                        if (((ulong)input[j] - '0') == 0)
                        {
                            continue;
                        };
                        temp *= (ulong)input[j] - '0';
                    }
                    //updating the product
                    product *= temp;
                }

                input = Console.ReadLine();
                i++;
            } while (input != "END");

            Console.WriteLine(product);

        }
    }
}
