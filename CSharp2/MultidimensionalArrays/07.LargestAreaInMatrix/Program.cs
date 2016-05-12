using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LargestAreaInMatrix
{
    class Program
    {
        private static bool[,] visited;
        private static int largestArea = 1;
        private static int currentArea = 1;
        private static Queue<Point> neighbours = new Queue<Point>();

        static void Main(string[] args)
        {
            //NOW NOW NOW
            string size = Console.ReadLine();
            int n = int.Parse(size.Split(' ')[0]);
            int m = int.Parse(size.Split(' ')[1]);
            int[,] matrix = new int[n, m];
            visited = new bool[n, m];
            for (int row = 0; row < n; row++)
            {
                int[] currentRow = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }
            // && row <= n - largestArea
            // && col <= m - largestArea
            for (int row = 0; row < n && row <= n - largestArea; row++)
            {
                for (int col = 0; col < m && col <= m - largestArea; col++)
                {
                    //TOP
                    //if (row - 1 >= 0)
                    //{
                    //    if (matrix[row, col] == matrix[row - 1, col] && !visited[row - 1, col])
                    //    {
                    //        currentArea++;
                    //        neighbours.Enqueue(new Point(row - 1, col));
                    //    }
                    //
                    //}
                    //TOP-RIGHT
                    if (row - 1 >= 0 && col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row, col] == matrix[row - 1, col + 1]
                            && !visited[row - 1, col + 1])
                        {
                            currentArea++;
                            neighbours.Enqueue(new Point(row - 1, col + 1));
                            visited[row - 1, col + 1] = true;

                        }
                    }
                    //RIGHT
                    if (col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row, col] == matrix[row, col + 1] && !visited[row, col + 1])
                        {
                            currentArea++;
                            neighbours.Enqueue(new Point(row, col + 1));

                        }
                    }
                    //RIGHT-BOT
                    if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1))
                    {
                        if (matrix[row, col] == matrix[row + 1, col + 1]
                            && !visited[row + 1, col + 1])
                        {
                            currentArea++;
                            neighbours.Enqueue(new Point(row + 1, col + 1));
                            visited[row + 1, col + 1] = true;
                        }
                    }
                    //BOT
                    if (row + 1 < matrix.GetLength(0))
                    {
                        if (matrix[row, col] == matrix[row + 1, col] && !visited[row + 1, col])
                        {
                            currentArea++;
                            neighbours.Enqueue(new Point(row + 1, col));

                        }
                    }
                    //BOT-LEFT
                    if (row + 1 < matrix.GetLength(0) && col - 1 >= 0)
                    {
                        if (matrix[row, col] == matrix[row + 1, col - 1]
                            && !visited[row + 1, col - 1])
                        {
                            currentArea++;
                            neighbours.Enqueue(new Point(row + 1, col - 1));
                            visited[row + 1, col - 1] = true;
                        }
                    }
                    //LEFT
                    //if (col - 1 >= 0)
                    //{
                    //    if (matrix[row, col] == matrix[row, col - 1] && !visited[row, col - 1])
                    //    {
                    //        currentArea++;
                    //        neighbours.Enqueue(new Point(row, col - 1));
                    //
                    //    }
                    //}
                    if (largestArea < currentArea)
                    {
                        largestArea = currentArea;
                    }
                    visited[row, col] = true;
                    if (neighbours.Count > 0)
                    {
                        Point temp = neighbours.Dequeue();
                        BFS(matrix, temp.x, temp.y);
                    }
                    currentArea = 1;
                }
            }
            Console.WriteLine(largestArea);
        }

        static void BFS(int[,] matrix, int row, int col)
        {
            //TOP
            if (row - 1 >= 0)
            {
                if (matrix[row, col] == matrix[row - 1, col]
                    && !visited[row - 1, col])
                {
                    currentArea++;
                    neighbours.Enqueue(new Point(row - 1, col));
                    visited[row - 1, col] = true;
                }

            }

            //TOP-RIGHT
            if (row - 1 >= 0 && col + 1 < matrix.GetLength(1))
            {
                if (matrix[row, col] == matrix[row - 1, col + 1]
                    && !visited[row - 1, col + 1])
                {
                    currentArea++;
                    neighbours.Enqueue(new Point(row - 1, col + 1));
                    visited[row - 1, col + 1] = true;

                }
            }

            //RIGHT
            if (col + 1 < matrix.GetLength(1))
            {
                if (matrix[row, col] == matrix[row, col + 1]
                    && !visited[row, col + 1])
                {
                    currentArea++;
                    neighbours.Enqueue(new Point(row, col + 1));
                    visited[row, col + 1] = true;
                }
            }

            //RIGHT-BOT
            if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1))
            {
                if (matrix[row, col] == matrix[row + 1, col + 1]
                    && !visited[row + 1, col + 1])
                {
                    currentArea++;
                    neighbours.Enqueue(new Point(row + 1, col + 1));
                    visited[row + 1, col + 1] = true;
                }
            }

            //BOT
            if (row + 1 < matrix.GetLength(0))
            {
                if (matrix[row, col] == matrix[row + 1, col]
                    && !visited[row + 1, col])
                {
                    currentArea++;
                    neighbours.Enqueue(new Point(row + 1, col));
                    visited[row + 1, col] = true;
                }
            }

            //BOT-LEFT
            if (row + 1 < matrix.GetLength(0) && col - 1 >= 0)
            {
                if (matrix[row, col] == matrix[row + 1, col - 1]
                    && !visited[row + 1, col - 1])
                {
                    currentArea++;
                    neighbours.Enqueue(new Point(row + 1, col - 1));
                    visited[row + 1, col - 1] = true;
                }
            }

            //LEFT
            if (col - 1 >= 0)
            {
                if (matrix[row, col] == matrix[row, col - 1]
                    && !visited[row, col - 1])
                {
                    currentArea++;
                    neighbours.Enqueue(new Point(row, col - 1));
                    visited[row, col - 1] = true;
                }
            }

            //LEFT-TOP
            if (row - 1 >= 0 && col - 1 >= 0)
            {
                if (matrix[row, col] == matrix[row - 1, col - 1]
                    && !visited[row - 1, col - 1])
                {
                    currentArea++;
                    neighbours.Enqueue(new Point(row - 1, col - 1));
                    visited[row - 1, col - 1] = true;
                }
            }

            if (largestArea < currentArea)
            {
                largestArea = currentArea;
            }

            visited[row, col] = true;
            while (neighbours.Count > 0)
            {
                Point temp = neighbours.Dequeue();
                BFS(matrix, temp.x, temp.y);
            }
        }
    }
    public class Point
    {
        public Point(int X, int Y)
        {
            this.x = X;
            this.y = Y;
        }
        public int x { get; set; }
        public int y { get; set; }
    }
}
