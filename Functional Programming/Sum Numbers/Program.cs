using System;
using System.Linq;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> printCount = count => Console.WriteLine(count.Length);
            Action<int[]> printSum = arr => Console.WriteLine(arr.Sum());
            Func<string, int> parser = item => int.Parse(item);

            int[] array = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(parser).ToArray();
            printCount(array);
            printSum(array);
        }
    }
}
