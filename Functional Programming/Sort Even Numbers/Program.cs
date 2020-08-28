using System;
using System.Collections.Generic;
using System.Linq;

namespace Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int[]> print = list => Console.WriteLine(string.Join(", ", list));
            print(Console.ReadLine()
                  .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .Where(n => n % 2 == 0)
                  .OrderBy(n => n)
                  .ToArray()
                 );
        }
    }
}
