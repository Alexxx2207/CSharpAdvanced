using System;
using System.Collections.Generic;
using System.Linq;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> nums = new Dictionary<string, int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string num = Console.ReadLine();
                if (nums.ContainsKey(num))
                {
                    nums[num]++;
                }
                else
                {
                    nums.Add(num, 1);
                }
            }
            foreach (var pair in nums)
            {
                if (pair.Value % 2 == 0)
                {
                    Console.WriteLine(pair.Key);
                    break;
                }
            }
        }
    }
}
