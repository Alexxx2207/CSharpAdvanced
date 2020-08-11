using System;
using System.Collections.Generic;

namespace Traffic_jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int passedCars = 0;
            Queue<string> carName = new Queue<string>();

            int N = int.Parse(Console.ReadLine());


            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "green")
                {
                    for (int x = 0; x < N && carName.Count > 0; x++)
                    {
                        Console.WriteLine($"{carName.Dequeue()} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    carName.Enqueue(input);
                }
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
