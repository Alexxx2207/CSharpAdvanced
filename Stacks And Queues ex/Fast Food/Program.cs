using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodCapacity = int.Parse(Console.ReadLine());
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());
            if (queue.Any())
            {
                Console.WriteLine(queue.Max());
                
            }
            while (queue.Any())
            {
                if (foodCapacity < queue.Peek())
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
                    break;
                }
                foodCapacity -= queue.Dequeue();
            }
            if (!queue.Any())
            {
                Console.WriteLine("Orders complete");
            }

        }
    }
}
