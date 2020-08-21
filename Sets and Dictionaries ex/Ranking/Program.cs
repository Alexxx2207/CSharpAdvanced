using System;
using System.Collections.Generic;
using System.Linq;

namespace Ranking
{
    class Contestant
    {
        public Dictionary<string, int> contests { get; set; }

        public Contestant()
        {
            contests = new Dictionary<string, int>();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            SortedDictionary<string, Contestant> participants = new SortedDictionary<string, Contestant>();
            string input;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] tokens = input.Split(":");
                if (!contests.ContainsKey(tokens[0]))
                {
                    contests.Add(tokens[0], tokens[1]);
                }
            }

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] tokens = input.Split("=>");

                if (contests.ContainsKey(tokens[0]) && contests[tokens[0]] == tokens[1])
                {
                    if (!participants.ContainsKey(tokens[2]))
                    {
                        participants.Add(tokens[2], new Contestant());
                        participants[tokens[2]].contests.Add(tokens[0], int.Parse(tokens[3]));

                    }
                    else if (!participants[tokens[2]].contests.ContainsKey(tokens[0]))
                    {

                        participants[tokens[2]].contests.Add(tokens[0], int.Parse(tokens[3]));
                    }
                    else if (participants[tokens[2]].contests[tokens[0]] < int.Parse(tokens[3]))
                    {
                        participants[tokens[2]].contests[tokens[0]] = int.Parse(tokens[3]);
                    }
                }
            }
            Dictionary<string, int> tempMax = new Dictionary<string, int>();
            foreach (var person in participants)
            {
                int sum = 0;
                foreach (var contest in person.Value.contests)
                {
                    sum += contest.Value;
                }
                tempMax.Add(person.Key, sum);
            }
            tempMax = tempMax.OrderByDescending(p => p.Value).ToDictionary(k => k.Key, v => v.Value);

            foreach (var person in tempMax)
            {
                
                Console.WriteLine($"Best candidate is {person.Key} with total {person.Value} points.");
                break;
            }

            Console.WriteLine("Ranking:");
            foreach (var person in participants)
            {
                person.Value.contests = person.Value.contests.OrderByDescending(p => p.Value).ToDictionary(k => k.Key, v => v.Value);
                Console.WriteLine($"{person.Key}");
                foreach (var contest in person.Value.contests)
                {
                    Console.WriteLine($"# {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
