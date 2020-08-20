using System;
using System.Collections.Generic;

namespace Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            SortedSet<string> chemicals = new SortedSet<string>();

            for (int i = 0; i < count; i++)
            {
                string[] chems = Console.ReadLine().Split();

                foreach (var item in chems)
                {
                    chemicals.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ", chemicals));
        }
    }
}
