using System;
using System.Collections.Generic;
using System.Linq;

namespace Santa_s_Present_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> materials = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> magicLevel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Dictionary<string, int> toys = new Dictionary<string, int>
            {
                { "Doll", 0 },
                { "Wooden train", 0 },
                { "Teddy bear", 0 },
                { "Bicycle", 0 }
            };

            while (materials.Any() && magicLevel.Any())
            {

                if (materials.Peek() == 0)
                {
                    if (magicLevel.Peek() == 0)
                    {
                        magicLevel.Dequeue();
                    }
                    materials.Pop();
                    continue;
                }

                if (magicLevel.Peek() == 0)
                {
                    magicLevel.Dequeue();
                    continue;
                }

                int multiplication = materials.Peek() * magicLevel.Peek();

                if (multiplication > 0)
                {
                    if (multiplication == 150)
                    {
                        toys["Doll"]++;
                        materials.Pop();
                        magicLevel.Dequeue();
                    }
                    else if (multiplication == 250)
                    {
                        toys["Wooden train"]++;
                        materials.Pop();
                        magicLevel.Dequeue();
                    }
                    else if (multiplication == 300)
                    {
                        toys["Teddy bear"]++;
                        materials.Pop();
                        magicLevel.Dequeue();
                    }
                    else if (multiplication == 400)
                    {
                        toys["Bicycle"]++;
                        materials.Pop();
                        magicLevel.Dequeue();
                    }
                    else
                    {
                        magicLevel.Dequeue();
                        int temp = materials.Pop() + 15;
                        materials.Push(temp);
                    }
                }
                else if (multiplication < 0)
                {
                    int sum = materials.Pop() + magicLevel.Dequeue();
                    materials.Push(sum);
                }
            }

            if ( ( toys["Doll"] > 0 && toys["Wooden train"] > 0 ) || ( toys["Teddy bear"] > 0 && toys["Bicycle"] > 0 ) )
            {
                Console.WriteLine("The presents are crafted! Merry Christmas!");
            }
            else
            {
                Console.WriteLine("No presents this Christmas!");
            }

            if (materials.Any())
            {
                Console.WriteLine($"Materials left: {string.Join(", ", materials)}"); 
            }
            
            if (magicLevel.Any())
            {
                Console.WriteLine($"Magic left: {string.Join(", ", magicLevel)}"); 
            }

            toys = toys.OrderBy(pair => pair.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (var toy in toys)
            {
                if (toy.Value > 0)
                {
                    Console.WriteLine($"{toy.Key}: {toy.Value}"); 
                }
            }
        }
    }
}
