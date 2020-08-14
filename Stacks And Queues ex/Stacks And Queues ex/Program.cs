using System;
using System.Collections.Generic;
using System.Linq;

namespace Stacks_And_Queues_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> nums = new Stack<int>();
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = tokens[0];
            int S = tokens[1];
            int X = tokens[2];

            int[] numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < N; i++)
            {
                nums.Push(numbersInput[i]);
            }

            for (int i = 0; i < S && nums.Count > 0; i++)
            {
                nums.Pop();
            }

            if (nums.Contains(X))
            {
                Console.WriteLine("true");
            }
            else if (nums.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(nums.Min());
            }
        }
    }
}
