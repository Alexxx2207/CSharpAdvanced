using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(" -> ");
                if (!wardrobe.ContainsKey(tokens[0]))
                {
                    wardrobe.Add(tokens[0], new Dictionary<string, int>());

                }
                
                string[] clothes = tokens[1].Split(",");

                foreach (var cloth in clothes)
                {
                    if (wardrobe[tokens[0]].ContainsKey(cloth))
                    {
                        wardrobe[tokens[0]][cloth]++;

                    }
                    else
                    {
                        wardrobe[tokens[0]].Add(cloth, 1);
                    }
                }
            }

            string[] search = Console.ReadLine().Split();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloth in color.Value)
                {
                    if (cloth.Key == search[1] && color.Key == search[0])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value}");

                    }
                }
            }
        }
    }
}
