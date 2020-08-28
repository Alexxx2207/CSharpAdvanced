using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {

            Action<List<string>> print = words => words.ForEach(i => Console.WriteLine($"Sir {i}"));
            print(Console.ReadLine().Split().ToList());
        }
    }
}
