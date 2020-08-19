using System;
using System.Linq;

namespace Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.MinValue;
            int startRow = 0, startCol = 0;
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] arr = new int[size[0], size[1]];

            for (int i = 0; i < size[0]; i++)
            {
                int[] row = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < size[1]; col++)
                {
                    arr[i, col] = row[col];
                }
            }

            for (int row = 0; row < arr.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < arr.GetLength(1) - 2; col++)
                {
                    int current = 0;
                    for (int onRow = row; onRow < row + 3; onRow++)
                    {
                        for (int onColumn = col; onColumn < col + 3; onColumn++)
                        {
                            current += arr[onRow, onColumn];
                        }
                    }
                    if (current > sum)
                    {
                        sum = current;
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {sum}");
            for (int row = startRow; row < startRow+3; row++)
            {
                for (int col = startCol; col < startCol+3; col++)
                {
                    Console.Write(arr[row,col]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
