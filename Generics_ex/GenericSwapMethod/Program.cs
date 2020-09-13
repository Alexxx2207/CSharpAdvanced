using System;
using System.Linq;

namespace GenericSwapMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Swapper<int>.SwapAndPrint(array, indexes);
        }
    }
}
