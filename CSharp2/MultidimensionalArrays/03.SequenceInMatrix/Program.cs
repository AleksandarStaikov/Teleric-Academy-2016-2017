using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SequenceInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string size = Console.ReadLine();
            int n = int.Parse(size.Split(' ')[0]);
            int m = int.Parse(size.Split(' ')[1]);
            string[,] matrix = new string[n, m];

            for (int row = 0; row < n; row++)
            {
                string[] currentRow = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int longestSequence = 1;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m ; col++)
                {
                    string currentElement = matrix[row, col];

                    string top, topRight, right, rightBot, bot, botLeft, left, leftTop;
                    top = topRight = right = rightBot = bot = botLeft = left = leftTop = String.Empty;

                    if (row == 0 && col == 0)
                    {
                        right = matrix[row, col + 1];
                        rightBot = matrix[row + 1, col + 1];
                        bot = matrix[row + 1, col];
                    }
                    else if (row == 0 && col == m - 1)
                    {
                        left = matrix[row, col - 1];
                        botLeft = matrix[row + 1, col - 1];
                        bot = matrix[row + 1, col];
                    }
                    else if (row == n - 1 && col == 0)
                    {
                        top = matrix[row - 1, col];
                        topRight = matrix[row - 1, col + 1];
                        right = matrix[row, col + 1];
                    }
                    else if (row == n - 1 && col == m - 1)
                    {
                        left = matrix[row, col - 1];
                        leftTop = matrix[row - 1, col - 1];
                        top = matrix[row - 1, col];
                    }
                    else if (row == 0)
                    {
                        right = matrix[row, col + 1];             
                        rightBot = matrix[row + 1, col + 1];      
                        bot = matrix[row + 1, col];               
                        botLeft = matrix[row + 1, col - 1];       
                        left = matrix[row, col - 1];
                    }
                    else if (row == n - 1)
                    {
                        top = matrix[row - 1, col];              
                        topRight = matrix[row - 1, col + 1];     
                        right = matrix[row, col + 1];            
                        left = matrix[row, col - 1];             
                        leftTop = matrix[row - 1, col - 1];

                    }
                    else if (col == 0)
                    {
                        top = matrix[row - 1, col];               
                        topRight = matrix[row - 1, col + 1];      
                        right = matrix[row, col + 1];             
                        rightBot = matrix[row + 1, col + 1];      
                        bot = matrix[row + 1, col];
                    }
                    else if (col == m - 1)
                    {
                        top = matrix[row - 1, col];
                        bot = matrix[row + 1, col];               
                        botLeft = matrix[row + 1, col - 1];       
                        left = matrix[row, col - 1];              
                        leftTop = matrix[row - 1, col - 1];
                    }
                    else
                    {
                        top = matrix[row - 1, col];                //top
                        topRight = matrix[row - 1, col + 1];       //top-right
                        right = matrix[row, col + 1];              //right
                        rightBot = matrix[row + 1, col + 1];       //right-bot
                        bot = matrix[row + 1, col];                //bot
                        botLeft = matrix[row + 1, col - 1];        //bot-left
                        left = matrix[row, col - 1];               //left
                        leftTop = matrix[row - 1, col - 1];        //left-top
                    }

                    int currentLongest = 1;
                    int currentRow, currentCol;
                    //TOP
                    if (currentElement == top)
                    {
                        currentRow = row - 2;
                        currentCol = col;
                        currentLongest++;
                        bool flag = false;
                        while (currentRow >= 0 && currentRow < n
                            && currentCol >= 0 && currentCol < m
                            && !flag)
                        {
                            if (currentElement == matrix[currentRow, currentCol])
                            {
                                currentRow--;
                                currentLongest++;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                        if (longestSequence < currentLongest)
                        {
                            longestSequence = currentLongest;
                        }
                        currentLongest = 1;
                    }

                    //TOP-RIGHT
                    if (currentElement == topRight)
                    {
                        currentRow = row - 2;
                        currentCol = col + 2;
                        currentLongest++;
                        bool flag = false;
                        while (currentRow >= 0 && currentRow < n
                            && currentCol >= 0 && currentCol < m
                            && !flag)
                        {
                            if (currentElement == matrix[currentRow, currentCol])
                            {
                                currentRow--;
                                currentCol++;
                                currentLongest++;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                        if (longestSequence < currentLongest)
                        {
                            longestSequence = currentLongest;
                        }
                        currentLongest = 1;
                    }

                    //RIGHT
                    if (currentElement == right)
                    {
                        currentRow = row;
                        currentCol = col + 2;
                        currentLongest++;
                        bool flag = false;
                        while (currentRow >= 0 && currentRow < n
                            && currentCol >= 0 && currentCol < m
                            && !flag)
                        {
                            if (currentElement == matrix[currentRow, currentCol])
                            {
                                currentCol++;
                                currentLongest++;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                        if (longestSequence < currentLongest)
                        {
                            longestSequence = currentLongest;
                        }
                        currentLongest = 1;
                    }

                    //RiGHT-BOT
                    if (currentElement == rightBot)
                    {
                        currentRow = row + 2;
                        currentCol = col + 2;
                        currentLongest++;
                        bool flag = false;
                        while (currentRow >= 0 && currentRow < n
                            && currentCol >= 0 && currentCol < m
                            && !flag)
                        {
                            if (currentElement == matrix[currentRow, currentCol])
                            {
                                currentRow++;
                                currentCol++;
                                currentLongest++;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                        if (longestSequence < currentLongest)
                        {
                            longestSequence = currentLongest;
                        }
                        currentLongest = 1;
                    }

                    //BOT
                    if (currentElement == bot)
                    {
                        currentRow = row + 2;
                        currentCol = col;
                        currentLongest++;
                        bool flag = false;
                        while (currentRow >= 0 && currentRow < n
                            && currentCol >= 0 && currentCol < m
                            && !flag)
                        {
                            if (currentElement == matrix[currentRow, currentCol])
                            {
                                currentRow++;
                                currentLongest++;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                        if (longestSequence < currentLongest)
                        {
                            longestSequence = currentLongest;
                        }
                        currentLongest = 1;
                    }

                    //BOT-LEFT
                    if (currentElement == botLeft)
                    {
                        currentRow = row + 2;
                        currentCol = col - 2;
                        currentLongest++;
                        bool flag = false;
                        while (currentRow >= 0 && currentRow < n
                            && currentCol >= 0 && currentCol < m
                            && !flag)
                        {
                            if (currentElement == matrix[currentRow, currentCol])
                            {
                                currentRow++;
                                currentCol--;
                                currentLongest++;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                        if (longestSequence < currentLongest)
                        {
                            longestSequence = currentLongest;
                        }
                        currentLongest = 1;
                    }

                    //LEFT
                    if (currentElement == left)
                    {
                        currentRow = row;
                        currentCol = col - 2;
                        currentLongest++;
                        bool flag = false;
                        while (currentRow >= 0 && currentRow < n
                            && currentCol >= 0 && currentCol < m
                            && !flag)
                        {
                            if (currentElement == matrix[currentRow, currentCol])
                            {
                                currentCol--;
                                currentLongest++;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                        if (longestSequence < currentLongest)
                        {
                            longestSequence = currentLongest;
                        }
                        currentLongest = 1;
                    }
                    //LEFT-TOP
                    if (currentElement == leftTop)
                    {
                        currentRow = row - 2;
                        currentCol = col - 2;
                        currentLongest++;
                        bool flag = false;
                        while (currentRow >= 0 && currentRow < n
                            && currentCol >= 0 && currentCol < m
                            && !flag)
                        {
                            if (currentElement == matrix[currentRow, currentCol])
                            {
                                currentRow--;
                                currentCol--;
                                currentLongest++;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                        if (longestSequence < currentLongest)
                        {
                            longestSequence = currentLongest;
                        }
                        currentLongest = 1;
                    }
                }
            }
            Console.WriteLine(longestSequence);
        }
    }
}
