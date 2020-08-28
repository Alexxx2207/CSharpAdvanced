using System;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().Split().Select(int.Parse).ToList();

            Action<List<int>> reverse = list => list.Reverse();

            reverse(arr);

            Predicate<int[]> divisible = (num) => num[0] % num[1] == 0;

            int div = int.Parse(Console.ReadLine());

            arr.RemoveAll(x => divisible(new int[2] { x, div}));

            Action<List<int>> print = list => Console.WriteLine(string.Join(" ", list));
            print(arr);
        }
    }
}
