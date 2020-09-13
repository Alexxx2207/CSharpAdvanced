using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Queue<int> casing = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).Reverse());

            int cherryOne = 0;
            int daruteOne = 0;
            int smokeOne = 0;

            while (effects.Any() && casing.Any())
            {
                if (cherryOne > 2 && daruteOne > 2 && smokeOne > 2)
                {
                    break;
                }
                if (casing.Peek() + effects.Peek() == 40)
                {
                    daruteOne++;
                    casing.Dequeue();
                    effects.Dequeue();
                }
                else if (casing.Peek() + effects.Peek() == 60)
                {
                    cherryOne++;
                    casing.Dequeue();
                    effects.Dequeue();
                }
                else if (casing.Peek() + effects.Peek() == 120)
                {
                    smokeOne++;
                    casing.Dequeue();
                    effects.Dequeue();
                }
                else
                {
                    casing.Enqueue(casing.Dequeue() - 5);
                    for (int i = 0; i < casing.Count-1; i++)
                    {
                        casing.Enqueue(casing.Dequeue());
                    }
                }
            }

            if (cherryOne > 2 && daruteOne > 2 && smokeOne > 2)
            {
                Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine($"You don't have enough materials to fill the bomb pouch.");
            }

            if (!effects.Any())
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");
            }

            if (!casing.Any())
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casing)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherryOne}");
            Console.WriteLine($"Datura Bombs: {daruteOne}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeOne}");
        }
    }
}
