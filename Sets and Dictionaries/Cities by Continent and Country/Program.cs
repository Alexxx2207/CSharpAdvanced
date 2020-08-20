using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var encyclopedia = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                if (!encyclopedia.ContainsKey(tokens[0]))
                {
                    encyclopedia.Add(tokens[0], new Dictionary<string, List<string>>());
                    encyclopedia[tokens[0]].Add(tokens[1], new List<string>() { tokens[2] });
                }
                else if (!encyclopedia[tokens[0]].ContainsKey(tokens[1]))
                {
                    encyclopedia[tokens[0]].Add(tokens[1], new List<string>() { tokens[2] });
                }
                else
                {
                    encyclopedia[tokens[0]][tokens[1]].Add(tokens[2]);
                }
            }

            foreach (var Continent in encyclopedia)
            {
                Console.WriteLine($"{Continent.Key}:");
                foreach (var country in Continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
