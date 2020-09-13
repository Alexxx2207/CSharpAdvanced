using System;

namespace smake
{
    class Program
    {
        static void PrintMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }
        static void Main(string[] args)
        {
            char[][] grid = new char[int.Parse(Console.ReadLine())][];
            int[] snakeCoord = new int[2];
            int[] burrow1 = new int[2];
            int[] burrow2 = new int[2];
            int countB = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                char[] row = Console.ReadLine().ToCharArray();
                grid[i] = new char[grid.Length];

                for (int j = 0; j < grid.Length; j++)
                {
                    grid[i][j] = row[j];

                    if (grid[i][j] == 'S')
                    {
                        snakeCoord[0] = i;
                        snakeCoord[1] = j;
                    }
                    else if (grid[i][j] == 'B')
                    {
                        if (countB == 0)
                        {
                            burrow1[0] = i;
                            burrow1[1] = j;
                            countB++;
                        }
                        else
                        {
                            burrow2[0] = i;
                            burrow2[1] = j;
                        }
                    }
                }
            }


            int snakeFood = 0;

            while (true)
            {
                string comm = Console.ReadLine();

                if (comm == "up")
                {
                    grid[snakeCoord[0]][snakeCoord[1]] = '.';

                    snakeCoord[0]--;
                }
                else if (comm == "down")
                {
                    grid[snakeCoord[0]][snakeCoord[1]] = '.';

                    snakeCoord[0]++;
                }
                else if (comm == "left")
                {
                    grid[snakeCoord[0]][snakeCoord[1]] = '.';

                    snakeCoord[1]--;
                }
                else if (comm == "right")
                {
                    grid[snakeCoord[0]][snakeCoord[1]] = '.';

                    snakeCoord[1]++;
                }

                if (snakeCoord[0] < 0 || snakeCoord[0] >= grid.Length || snakeCoord[1] < 0 || snakeCoord[1] >= grid.Length)
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine($"Food eaten: {snakeFood}");
                    PrintMatrix(grid);

                    break;
                }
               
                

                if (grid[snakeCoord[0]][snakeCoord[1]] == '*')
                {
                    grid[snakeCoord[0]][snakeCoord[1]] = '.';
                    snakeFood++;
                }
                else if (grid[snakeCoord[0]][snakeCoord[1]] == 'B')
                {
                    grid[snakeCoord[0]][snakeCoord[1]] = '.';

                    if (snakeCoord[0] == burrow1[0] && snakeCoord[1] == burrow1[1])
                    {
                        snakeCoord[0] = burrow2[0];
                        snakeCoord[1] = burrow2[1];
                    }
                    else
                    {
                        snakeCoord[0] = burrow1[0];
                        snakeCoord[1] = burrow1[1];
                    }
                }

                if (snakeFood >= 10)
                {
                    grid[snakeCoord[0]][snakeCoord[1]] = 'S';
                    Console.WriteLine("You won! You fed the snake.");
                    Console.WriteLine($"Food eaten: {snakeFood}");
                    PrintMatrix(grid);
                    break;
                }

            }
        }
    }
}
