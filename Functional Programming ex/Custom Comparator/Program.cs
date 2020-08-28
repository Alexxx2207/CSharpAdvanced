using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initial = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> evenOnes = new List<int>();

            Predicate<int> isEven = num => num % 2 == 0;

            Action<List<int>, List<int>> answer = (initial, evenList) =>
            {
                evenList = initial.FindAll(num => isEven(num));
                initial.RemoveAll(num => isEven(num));

                evenList.Sort();
                initial.Sort();
                Console.WriteLine(string.Join(" ", evenList) + " " + string.Join(" ", initial) );
            };

            answer(initial, evenOnes);
        }
    }
}
