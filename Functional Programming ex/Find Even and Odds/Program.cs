using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_Even_and_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bonds = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string choice = Console.ReadLine();

            Array.Sort(bonds);

            List<int> numbers = Enumerable.Range(bonds[0], bonds[1] - bonds[0] + 1).ToList();

            Predicate<int> isEven = n => n % 2 == 0;

            if (choice.ToUpper().Equals("EVEN"))
            {
                numbers.RemoveAll(x => !isEven(x));

            }
            else if (choice.ToUpper().Equals("ODD"))
            {
                numbers.RemoveAll(x => isEven(x));

            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
