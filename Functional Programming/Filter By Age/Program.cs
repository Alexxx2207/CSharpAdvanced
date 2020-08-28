using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> records = new Dictionary<string, int>();
            int count = int.Parse(Console.ReadLine());

            Func<Dictionary<string, int>, string, int, Dictionary<string, int>> filter = (records, condition, age) =>
            {
                if (condition == "younger")
                {
                    return records.Where(records => records.Value <= age).ToDictionary(k => k.Key, v => v.Value);
                }
                else
                {
                    return records = records.Where(records => records.Value >= age).ToDictionary(k => k.Key, v => v.Value);
                }
            };

            Action<Dictionary<string, int>, string> print = (records, format) =>
            {
                if (format == "name")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, records.Keys));
                }
                else if (format == "age")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, records.Values));
                }
                else if (format == "name age")
                {
                    foreach (var pair in records)
                    {
                        Console.WriteLine($"{pair.Key} - {pair.Value}");
                    }
                }
            };

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                if (!records.ContainsKey(tokens[0]))
                {
                    records.Add(tokens[0], int.Parse(tokens[1]));
                }
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string Format = Console.ReadLine();

            print(filter(records, condition, age), Format);

        }
    }
}
