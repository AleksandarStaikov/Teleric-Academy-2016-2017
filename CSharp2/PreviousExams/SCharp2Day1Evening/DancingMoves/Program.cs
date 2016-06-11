using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DancingMoves
{
    class Program
    {
        static int[] array;
        static void Main(string[] args)
        {
            array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var sums = new List<int>();

            string command = Console.ReadLine();
            int currentPossition = 0;
            while (command != "stop")
            {
                string[] splitedCommand = command.Split(' ').ToArray();
                int times = int.Parse(splitedCommand[0]);
                string direction = splitedCommand[1]; // == "left" ? -1 : 1;
                int step = int.Parse(splitedCommand[2]);
                int sum = 0;

                //move
                // collect

                for (int i = 0; i < times; i++)
                {
                    step = step % array.Length;
                    if (direction == "left")
                    {
                        //MOVE LEFT
                        if (currentPossition - step < 0)
                        {
                            currentPossition = array.Length - Math.Abs(currentPossition - step);
                        }
                        else
                        {
                            currentPossition -= step;
                        }
                    }
                    else
                    {
                        //MOVE RIGHT
                        if (currentPossition + step > array.Length - 1)
                        {
                            currentPossition = (step + currentPossition) % array.Length;
                        }
                        else
                        {
                            currentPossition += step;
                        }
                    }
                    sum += array[currentPossition];
                }
                sums.Add(sum);
                command = Console.ReadLine();
            }
            Console.WriteLine("{0:F1}", sums.Average());
        }
    }
}
