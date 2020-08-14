using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> nums = new Queue<int>();
            int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = tokens[0];
            int S = tokens[1];
            int X = tokens[2];

            int[] numbersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < N; i++)
            {
                nums.Enqueue(numbersInput[i]);
            }

            for (int i = 0; i < S && nums.Count > 0; i++)
            {
                nums.Dequeue();
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
