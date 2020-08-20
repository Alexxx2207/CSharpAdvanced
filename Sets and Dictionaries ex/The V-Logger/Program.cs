using System;
using System.Collections.Generic;
using System.Linq;

namespace The_V_Logger
{
    class Vlogger
    {
        public string Name { get; set; }
        public int Following{ get; set; }
        public SortedSet<string> FollowersSet { get; set; }

        public Vlogger(string name)
        {
            Name = name;
            Following = 0;
            FollowersSet = new SortedSet<string>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Vlogger> website = new Dictionary<string, Vlogger>();

            string input;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] tokens = input.Split();

                if (tokens[1] == "joined")
                {
                    if (!website.ContainsKey(tokens[0]))
                    {
                        website.Add(tokens[0], new Vlogger(tokens[0]));
                    }
                }
                else if(website.ContainsKey(tokens[0]) && website.ContainsKey(tokens[2]) && website[tokens[0]].Name != tokens[2])
                {
                    if (!website[tokens[2]].FollowersSet.Contains(tokens[0]))
                    {
                        website[tokens[0]].Following++; 
                    }
                    website[tokens[2]].FollowersSet.Add(tokens[0]);
                }
            }
            Console.WriteLine($"The V-Logger has a total of {website.Count} vloggers in its logs.");
            website = website.OrderByDescending(x => x.Value.FollowersSet.Count).ThenBy(x => x.Value.Following).ToDictionary(k => k.Key, v => v.Value);

            int count = 1;
            foreach (var vlogger in website)
            {
                Console.WriteLine($"{count++}. {vlogger.Key} : {vlogger.Value.FollowersSet.Count} followers, {vlogger.Value.Following} following");
                foreach (var follower in vlogger.Value.FollowersSet)
                {
                    Console.WriteLine($"*  {follower}");
                }
                website.Remove(vlogger.Key);
                break;
            }

            foreach (var vlogger in website)
            {
                Console.WriteLine($"{count++}. {vlogger.Key} : {vlogger.Value.FollowersSet.Count} followers, {vlogger.Value.Following} following");
            }
        }
    }
}
