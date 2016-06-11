using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            int bracketsDepth = 0;

            foreach (var symbol in expression)
            {
                if (symbol == '(')
                {
                    bracketsDepth++;
                }
                if (symbol == ')')
                {
                    if (bracketsDepth <= 0)
                    {
                        Console.WriteLine("Incorrect");
                        return;
                    }
                    bracketsDepth--;
                }
            }

            if (bracketsDepth == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
