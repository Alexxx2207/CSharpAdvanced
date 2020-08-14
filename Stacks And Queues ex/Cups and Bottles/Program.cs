using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int waterWasted = 0;
            while (cups.Any() && bottles.Any())
            {
                if (cups.Peek() - bottles.Peek() == 0)
                {
                    cups.Dequeue();
                }
                else if (cups.Peek() - bottles.Peek() < 0)
                {
                    waterWasted += bottles.Peek() - cups.Peek();
                    cups.Dequeue();
                }
                else if (cups.Peek() - bottles.Peek() > 0)
                {
                    int[] temp = new int[cups.Count];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        temp[i] = cups.Dequeue();
                    }
                    temp[0] -= bottles.Peek();
                    for (int i = 0; i < temp.Length; i++)
                    {
                        cups.Enqueue(temp[i]);
                    }
                }
                bottles.Pop();
            }
            if (bottles.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {waterWasted}");
        }
    }
}
