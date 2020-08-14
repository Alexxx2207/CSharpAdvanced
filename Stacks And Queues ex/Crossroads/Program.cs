using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            int passed = 0;
            bool crash = false;
            Queue<string> queue = new Queue<string>();
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                if (input != "green")
                {
                    queue.Enqueue(input);
                }
                else
                {
                    int timer = greenLight;

                    while (timer > 0 && !crash && queue.Any())
                    {
                        if (timer >= queue.Peek().Length)
                        {
                            passed++;
                            timer -= queue.Peek().Length;
                            queue.Dequeue();
                        }
                        else if (freeWindow >= queue.Peek().Length - timer)
                        {
                            passed++;
                            queue.Dequeue();
                            timer = 0;
                        }
                        else
                        {
                            crash = true;
                            Console.WriteLine($"A crash happened!\nHummer was hit at {queue.Peek()[freeWindow + timer]}.");
                        }
                    }
                }
            }
            if (!crash)
            {
                Console.WriteLine($"Everyone is safe.\n{passed} total cars passed the crossroads.");
            }
        }
    }
}
