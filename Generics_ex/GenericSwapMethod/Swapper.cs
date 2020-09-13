using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethod
{
    static class Swapper<T>
    {
        public static void SwapAndPrint(T[] arr, int[] indexes)
        {
            T temp = arr[indexes[0]];
            arr[indexes[0]] = arr[indexes[1]];
            arr[indexes[1]] = temp;

            foreach (var item in arr)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
    }
}
