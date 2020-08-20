using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_and_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> counter = new Dictionary<string, int>();

            string[] row = Console.ReadLine().Split();
            foreach (var element in row)
            {
                if (!counter.ContainsKey(element))
                {
                    counter.Add(element, 1);
                }
                else
                {
                    counter[element]++;
                }
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}

