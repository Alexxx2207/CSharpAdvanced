using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<decimal>>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                if (students.ContainsKey(tokens[0]))
                {
                    students[tokens[0]].Add(decimal.Parse(tokens[1]));
                }
                else
                {
                    students.Add(tokens[0], new List<decimal>() { decimal.Parse(tokens[1]) });
                }
            }

            foreach (var pair in students)
            {
                Console.Write($"{pair.Key} -> ");

                foreach (var grade in pair.Value)
                {
                    Console.Write($"{grade:f2} ");
                }

                Console.WriteLine($"(avg: {pair.Value.Average():f2})");
            }
        }
    }
}
