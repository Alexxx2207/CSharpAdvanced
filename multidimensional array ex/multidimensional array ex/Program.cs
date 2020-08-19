using System;
using System.Linq;

namespace multidimensional_array_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] arr = new int[size, size];

            int fDiagonal = 0, sDiaginal = 0;
            for (int i = 0; i < size; i++)
            {
                int[] row = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    arr[i, col] = row[col];
                }
            }
            for (int row = 0, col = 0; row < size && col < size; row++, col++)
            {
                fDiagonal += arr[row, col];
            }
            for (int row = size-1, col = 0; row > -1 && col < size; row--, col++)
            {
                sDiaginal += arr[row, col];
            }
            Console.WriteLine(Math.Abs(sDiaginal-fDiagonal));
        }
    }
}
