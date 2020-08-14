using System;
using System.Linq;

namespace multidimentional_arrays
{
    class Program
    {
        static void FillMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] column = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = column[j];
                }
            }
        }
        static void FillMatrix(int[][] jagged)
        {
            for (int i = 0; i < jagged.GetLength(0); i++)
            {
                jagged[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
        }
        static void PrintMatrixColumnSum(int[,] matrix)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                int sum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, column];
                }
                Console.WriteLine(sum);
            }
        }
        static void PrimaryDiagonalSum(int[,] matrix)
        {
            int sum = 0;
            for (int row = 0, column = matrix.GetLength(1)-1; row < matrix.GetLength(0) && column > -1; row++, column--)
            {
                sum += matrix[row, column];
            }
            Console.WriteLine(sum);
        }
        static void Max2x2SquareSum(int[,] matrix)
        {
            int currentBiggest = int.MinValue;
            int rowStart = 0, columnStart = 0;
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > currentBiggest)
                    {
                        currentBiggest = currentSum;
                        rowStart = row;
                        columnStart = col;
                    }
                }
            }

            for (int i = rowStart; i < rowStart + 2; i++)
            {
                Console.Write($"{matrix[i,columnStart]} {matrix[i, columnStart+1]}\n");
                
            }
            Console.WriteLine(currentBiggest);
        }
        static void ExecuteCommands(int[][] jagged, string command)
        {
            string[] tokens = command.Split();
            int row = int.Parse(tokens[1]);  
            int col = int.Parse(tokens[2]);  
            int value = int.Parse(tokens[3]);  
            if (tokens[0] == "Add" && row > -1 && row < jagged.GetLength(0) && col > -1 && col < jagged[row].GetLength(0))
            {
                jagged[row][col] += value; 
            }
            else if (tokens[0] == "Subtract" && row > -1 && row < jagged.GetLength(0) && col > -1 && col < jagged[row].GetLength(0))
            {
                jagged[row][col] -= value;
            }
            else
            {
                Console.WriteLine($"Invalid coordinates");
            }
        }
        static void PrintMatrix(int[][] jagged)
        {
            foreach (int[] row in jagged)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
        static void PrintPascalTriangle(int height)
        {
            if (height > -1)
            {
                long[][] jagged = new long[height][];
                for (int i = 0; i < height; i++)
                {
                    jagged[i] = new long[i + 1];
                    jagged[i][0] = 1;
                    jagged[i][^1] = 1;
                    for (int col = 1; col < jagged[i].Length - 1; col++)
                    {
                        jagged[i][col] = jagged[i - 1][col] + jagged[i - 1][col - 1];
                    }
                    Console.WriteLine(string.Join(" ", jagged[i]));
                } 
            }
        }
        static void Main(string[] args)
        {
            // white your own code and use methods above the main method
        }
    }
}
