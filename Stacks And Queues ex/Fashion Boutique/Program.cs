using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> box = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackSum = int.Parse(Console.ReadLine());

            int racks = 0;
            int currentSum = 0;

            while (box.Any())
            {
                if (currentSum + box.Peek() <= rackSum)
                {
                    currentSum += box.Pop();
                }
                else
                {
                    racks++;
                    currentSum = 0;
                }
            }
            if (currentSum > 0)
            {
                racks++;
            }
            Console.WriteLine(racks);
        }
    }
}
