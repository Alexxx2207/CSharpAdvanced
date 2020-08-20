using System;
using System.Collections.Generic;
using System.Linq;

namespace Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            HashSet<int> nums1 = new HashSet<int>();
            HashSet<int> nums2 = new HashSet<int>();
            HashSet<int> inBoth = new HashSet<int>();


            for (int i = 0; i < sizes[0]; i++)
            {
                nums1.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < sizes[1]; i++)
            {
                nums2.Add(int.Parse(Console.ReadLine()));
            }

            foreach (int num in nums1)
            {
                if (nums2.Contains(num))
                {
                    inBoth.Add(num);
                }
            }

            Console.WriteLine(string.Join(" ", inBoth));
        }
    }
}
