using System;
using System.Collections.Generic;
using System.Linq;

namespace Key_revolver
{
    class Program
    {
        static void Reload(Queue<int> g, Stack<int> r, int size)
        {
            for (int i = 0; i < size; i++)
            {
                if (r.Any())
                {
                    g.Enqueue(r.Pop());     
                }
                else
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intelPrice = int.Parse(Console.ReadLine());

            Stack<int> reserve = new Stack<int>(bullets);
            Queue<int> inGun = new Queue<int>();
            Queue<int> locksQueue = new Queue<int>(locks);

            if (reserve.Any())
            {
                Reload(inGun, reserve, gunBarrel); 
            }

            while (locksQueue.Any() && inGun.Any())
            {
                if (locksQueue.Peek() >= inGun.Peek())
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                inGun.Dequeue();
                intelPrice -= bulletPrice;

                if (!inGun.Any() && reserve.Any())
                {
                    Console.WriteLine("Reloading!");
                    Reload(inGun, reserve, gunBarrel);
                }
            }

            if (locksQueue.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
            else 
            {
                Console.WriteLine($"{reserve.Count + inGun.Count} bullets left. Earned ${intelPrice}");

            }

        }
    }
}
