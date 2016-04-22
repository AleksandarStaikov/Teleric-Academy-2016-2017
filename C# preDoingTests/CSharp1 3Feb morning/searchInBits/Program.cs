using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace searchInBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            string sAsBits = Convert.ToString(s, 2).PadLeft(4, '0');
            string searchedBits = sAsBits.Substring(sAsBits.Length - 4, 4);

            int n, nCount = int.Parse(Console.ReadLine());
            string asBits;
            int occurrenceCounter = 0;
            for (int i = 0; i < nCount; i++)
            {
                n = int.Parse(Console.ReadLine());
                asBits = Convert.ToString(n, 2);
                asBits = asBits.PadLeft(30, '0');
                asBits = asBits.Substring(asBits.Length - 30, 30);

                char first = searchedBits[0];
                char second = searchedBits[1];
                char third = searchedBits[2];
                char fourth = searchedBits[3];

                for (int k = 0; k < asBits.Length - 3; k++)
                {
                    if (asBits[k] == first &&
                        asBits[k + 1] == second &&
                        asBits[k + 2] == third &&
                        asBits[k + 3] == fourth)
                    {
                        occurrenceCounter++;
                    }
                }

            }

            Console.WriteLine(occurrenceCounter);
        }
    }
}
