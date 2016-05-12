using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.FillTheMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int[,] matrix = new int[size, size];

            if (type == "a")
            {
                for (int col = 0; col < size; col++)
                {
                    for (int row = 0; row < size; row++)
                    {
                        matrix[row, col] = col * size + row + 1;
                    }
                }
                Print(matrix);
            }

            else if (type == "b")
            {
                for (int col = 0; col < size; col++)
                {
                    for (int row = 0; row < size; row++)
                    {
                        if (col % 2 == 0)
                        {
                            matrix[row, col] = col * size + row + 1;
                        }
                        else
                        {
                            matrix[row, col] = ((col + 1) * size) - row;
                        }

                    }
                }
                Print(matrix);
            }

            else if (type == "c")
            {
                int counter = 1;
                int row;
                int col = 0;
                int currentRow, currentCol;
                for (row = size - 1; row >= 0; row--)
                {
                    currentRow = row;
                    currentCol = col;
                    while (currentCol < size && currentRow < size )
                    {
                        matrix[currentRow, currentCol] = counter;
                        counter++;
                        currentRow++;
                        currentCol++;
                    }
                }
                row = 0;
                currentCol = 0;
                currentRow = 0;
                for (col = 1; col < size; col++)
                {
                    currentRow = row;
                    currentCol = col;
                    while (currentCol < size  && currentRow < size )
                    {
                        matrix[currentRow, currentCol] = counter;
                        counter++;
                        currentRow++;
                        currentCol++;
                    }
                }
                Print(matrix);
            }



        }

        static void Print(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (col > 0)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
