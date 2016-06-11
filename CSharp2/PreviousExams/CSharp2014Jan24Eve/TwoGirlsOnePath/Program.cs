using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace TwoGirlsOnePath
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] flowersField = Console.ReadLine().Split(' ').Select(long.Parse).Reverse().ToArray();
            int n = flowersField.Length;


            bool dollyWins = false;
            bool mollyWins = false;

            int mollyVector = -1, dollyVector = 1;
            int dollyPossition = 0, mollyPossition = n - 1;
            //Collect the flowers
            BigInteger mollyFlowers = flowersField[mollyPossition],
                       dollyFlowers = flowersField[dollyPossition];
            if (flowersField[mollyPossition] == 0)
            {
                dollyWins = true;
            }
            if (flowersField[dollyPossition] == 0)
            {
                mollyWins = true;
            }



            if (mollyWins && dollyWins)
            {
                Console.WriteLine("Draw");
                Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
                return;
            }
            if (dollyWins)
            {
                Console.WriteLine("Dolly");
                Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
                return;
            }
            else if (mollyWins)
            {
                Console.WriteLine("Molly");
                Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
                return;
            }

            //Calculate the step
            int mollyStep = (int)(flowersField[mollyPossition] % n),
                dollyStep = (int)(flowersField[dollyPossition] % n);
            //Mark field as visited
            flowersField[mollyPossition] = 0;
            flowersField[dollyPossition] = 0;

            while (true)
            {
                //Move
                for (int i = 0; i < mollyStep; i++)
                {
                    if (mollyPossition == 0)
                    {
                        mollyPossition = n - 1;
                    }
                    else
                    {
                        mollyPossition += mollyVector;
                    }
                }
                for (int i = 0; i < dollyStep; i++)
                {
                    if (dollyPossition == n - 1)
                    {
                        dollyPossition = 0;
                    }
                    else
                    {
                        dollyPossition += dollyVector;
                    }
                }

                if (mollyPossition == dollyPossition)
                {
                    if (flowersField[mollyPossition] == 0)
                    {
                        Console.WriteLine("Draw");
                        Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
                        return;
                    }
                    else
                    {
                        mollyStep = dollyStep = (int)(flowersField[mollyPossition] % n);
                        mollyFlowers += flowersField[mollyPossition] / 2;
                        dollyFlowers += flowersField[dollyPossition] / 2;
                        int cell = (int)flowersField[dollyPossition];
                        flowersField[dollyPossition] = (cell % 2 == 0) ? 0 : 1;
                        continue;
                    }
                }

                //Update Molly First
                if (flowersField[mollyPossition] == 0)
                {
                    dollyWins = true;
                }
                else
                {
                    mollyStep = (int)(flowersField[mollyPossition] % n);
                    mollyFlowers += flowersField[mollyPossition];
                    flowersField[mollyPossition] = 0;
                }
                //Update Dolly Second
                if (flowersField[dollyPossition] == 0)
                {
                    mollyWins = true;
                }
                else
                {
                    dollyStep = (int)(flowersField[dollyPossition] % n);
                    dollyFlowers += flowersField[dollyPossition];
                    flowersField[dollyPossition] = 0;
                }


                if (mollyWins && dollyWins)
                {
                    Console.WriteLine("Draw");
                    Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
                    return;
                }
                if (dollyWins)
                {
                    Console.WriteLine("Dolly");
                    Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
                    return;
                }
                else if (mollyWins)
                {
                    Console.WriteLine("Molly");
                    Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
                    return;
                }
            }

        }
    }
}
