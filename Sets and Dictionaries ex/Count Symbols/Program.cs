using System;
using System.Collections.Generic;

namespace Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = new SortedDictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (chars.ContainsKey(input[i]))
                {
                    chars[input[i]]++;
                }
                else
                {
                    chars.Add(input[i], 1);
                }
            }
            foreach (var pair in chars)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} time/s");
            }
        }
    }
}
