using System;
using System.Linq;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> Min = nums => nums.Min();
            Console.WriteLine(Min(Console.ReadLine().Split().Select(int.Parse).ToArray()));
        }
    }
}
