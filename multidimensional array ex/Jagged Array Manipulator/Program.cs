using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] arr = new double[rows][];
            for (int i = 0; i < rows; i++)
            {
                double[] row = Console.ReadLine().Split().Select(double.Parse).ToArray();
                arr[i] = row;
            }

            for (int row = 0; row < arr.GetLength(0)-1; row++)
            {
                if (arr[row].Length == arr[row+1].Length)
                {
                    for (int col = 0; col < arr[row].Length; col++)
                    {
                        arr[row][col] *= 2;
                        arr[row+1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < arr[row].Length; col++)
                    {
                        arr[row][col] /= 2;
                    }
                    for (int col = 0; col < arr[row+1].Length; col++)
                    {
                        arr[row+1][col] /= 2;
                    }
                }
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();
                if (int.Parse(tokens[1]) >= 0 && int.Parse(tokens[1]) < rows && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < arr[int.Parse(tokens[1])].Length)
                {
                    if (tokens[0] == "Add")
                    {
                        arr[int.Parse(tokens[1])][int.Parse(tokens[2])] += int.Parse(tokens[3]);
                    }
                    else if (tokens[0] == "Subtract")
                    {
                        arr[int.Parse(tokens[1])][int.Parse(tokens[2])] -= int.Parse(tokens[3]);
                    } 
                }
            }

            foreach (double[] row in arr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
