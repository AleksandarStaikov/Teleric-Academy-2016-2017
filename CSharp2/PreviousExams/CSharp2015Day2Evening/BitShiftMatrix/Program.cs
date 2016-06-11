using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BitShiftMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string bf = Console.ReadLine();
            int[] moves = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var matrix = new bool[r, c];
            int currentRow = r - 1;
            int currentCol = 0;
            BigInteger sum = 1;
            matrix[currentRow, currentCol] = true;
            BigInteger fieldValue = 1;


            foreach (var move in moves)
            {
                int nextRow = move / Math.Max(r, c);
                int nextCol = move % Math.Max(r, c);

                //Move Coulm-wise
                int colVector = (currentCol > nextCol) ? -1 : 1;
                while (currentCol != nextCol)
                {
                    //move
                    currentCol += colVector;

                    //Update Field Value
                    if (colVector == 1)
                    {
                        fieldValue *= 2;
                    }
                    else
                    {
                        fieldValue /= 2;
                    }

                    //Collect Field VAlue
                    if (!matrix[currentRow, currentCol])
                    {
                        sum += fieldValue;
                    }

                    //Mark As Visited;
                    matrix[currentRow, currentCol] = true;
                }

                //Move Row-wise
                int rowVector = (currentRow > nextRow) ? -1 : 1;
                while (currentRow != nextRow)
                {
                    //Move
                    currentRow += rowVector;

                    //Update Field Value
                    if (rowVector == 1)
                    {
                        fieldValue /= 2;
                    }
                    else
                    {
                        fieldValue *= 2;
                    }

                    //Collect the Field Value
                    if (!matrix[currentRow, currentCol])
                    {
                        sum += fieldValue;
                    }

                    //Mark Field As Visited
                    matrix[currentRow, currentCol] = true;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
