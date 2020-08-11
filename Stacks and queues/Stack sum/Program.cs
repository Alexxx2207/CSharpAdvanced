using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> nums = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());


            string input;

            while ((input = Console.ReadLine()).ToLower() != "end")
            {
                string[] commands = input.Split();
                if (commands[0].ToLower() == "add" && commands.Length == 3)
                {
                    for (int i = 1; i < 3; i++)
                    {
                        nums.Push(int.Parse(commands[i])); 
                    }
                    
                }
                else if (commands[0].ToLower() == "remove" && commands.Length == 2 && int.Parse(commands[1]) <= nums.Count)
                {
                    for (int i = 0; i < int.Parse(commands[1]); i++)
                    {
                        nums.Pop();
                    }
                }
            }
            Console.WriteLine($"Sum: {nums.Sum()}");
        }
    }
}
