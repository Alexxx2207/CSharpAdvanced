using System;
using System.Collections.Generic;

namespace CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < N; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 2)
                {
                    engines.Add(tokens[0], new Engine(tokens[0], int.Parse(tokens[1])));
                }
                else if (tokens.Length == 3)
                {
                    if (int.TryParse(tokens[2], out int value))
                    {
                        engines.Add(tokens[0], new Engine(tokens[0], int.Parse(tokens[1]), value));
                    }
                    else
                    {
                        engines.Add(tokens[0], new Engine(tokens[0], int.Parse(tokens[1]), tokens[2]));

                    }
                }
                else if (tokens.Length == 4)
                {
                    engines.Add(tokens[0], new Engine(tokens[0], int.Parse(tokens[1]), tokens[2], tokens[3]));
                }
            }
            int M = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (engines.ContainsKey(tokens[1]))
                {
                    if (tokens.Length == 2)
                    {
                        cars.Add(new Car(tokens[0], engines[tokens[1]]));
                    }
                    else if (tokens.Length == 3)
                    {
                        if (int.TryParse(tokens[2], out int value))
                        {
                            cars.Add(new Car(tokens[0], engines[tokens[1]], value));
                        }
                        else
                        {
                            cars.Add(new Car(tokens[0], engines[tokens[1]], tokens[2]));
                        }
                    }
                    else if (tokens.Length == 4)
                    {
                        cars.Add(new Car(tokens[0], engines[tokens[1]], tokens[2], tokens[3]));
                    } 
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.Model + ":");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
