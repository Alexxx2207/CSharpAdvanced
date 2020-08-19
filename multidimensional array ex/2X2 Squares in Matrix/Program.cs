using System;
using System.Linq;

namespace _2X2_Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (size[0] > 1 && size[1] > 1)
            {
                char[,] arr = new char[size[0], size[1]];

                for (int i = 0; i < size[0]; i++)
                {
                    char[] row = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                    for (int col = 0; col < size[1]; col++)
                    {
                        arr[i, col] = row[col];
                    }
                }

                for (int row = 0; row < arr.GetLength(0) - 1; row++)
                {
                    for (int col = 0; col < arr.GetLength(1) - 1; col++)
                    {
                        if (arr[row, col] == arr[row, col + 1] && arr[row, col] == arr[row + 1, col] && arr[row, col] == arr[row + 1, col + 1])
                        {
                            count++;
                        }
                    }
                }
                Console.WriteLine(count); 
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
