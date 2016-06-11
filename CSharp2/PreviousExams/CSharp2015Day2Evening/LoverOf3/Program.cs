using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoverOf3
{
    class Program
    {
        static bool[,] matrix;
        static void Main(string[] args)
        {
            var matrixSize = Console.ReadLine().Split(' ');
            int rowCount = int.Parse(matrixSize[0]);
            int colCount = int.Parse(matrixSize[1]);

            matrix = new bool[rowCount, colCount];
            int movesCount = int.Parse(Console.ReadLine());
            string[] moves = new string[movesCount];

            for (int i = 0; i < movesCount; i++)
            {
                moves[i] = Console.ReadLine();
            }

            long sum = 0;
            long currentCellValue = 0;
            int row = rowCount - 1;
            int col = 0;
            matrix[row, col] = true;

            foreach (var move in moves)
            {
                var moveDetails = move.Split(' ').ToArray();
                int repeat = int.Parse(moveDetails[1]);
                string moveDirection = moveDetails[0];

                int deltaRow = moveDirection.Contains("U") ? -1 : 1;
                int deltaCol = moveDirection.Contains("L") ? -1 : 1;

                for (int i = 0; i < repeat - 1; i++)
                {
                    //check if the new possition is in the matrix
                        //if in then move
                            //Update the sum 
                            //check if collected
                                //if not, collect and mark as collected 
                        //if not - break;

                    if (IsInside(row + deltaRow, col + deltaCol))
                    {
                        row += deltaRow;
                        col += deltaCol;

                        if (deltaRow == -1 && deltaCol == 1)
                        {
                            currentCellValue += 6;
                        }
                        if (deltaRow == 1 && deltaCol == -1)
                        {
                            currentCellValue -= 6;
                        }

                        if (!matrix[row, col])
                        {
                            sum += currentCellValue;
                            matrix[row, col] = true;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(sum);
        }
        static bool IsInside(int row, int col)
        {
            bool rowIsInField = row >= 0 && row < matrix.GetLength(0);
            bool colIsInField = col >= 0 && col < matrix.GetLength(1);

            return rowIsInField && colIsInField;
        }
    }
}
