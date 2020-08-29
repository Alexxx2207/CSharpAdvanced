using System;
using System.Collections.Generic;
using System.Linq;

namespace Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Car[] cars = new Car[N];
            for (int i = 0; i < N; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                List<Tire> package = new List<Tire>();
                for (int j = 5; j < tokens.Length - 1; j += 2)
                {
                    package.Add(new Tire(double.Parse(tokens[j]), int.Parse(tokens[j + 1])));
                }
                cars[i] = new Car(tokens[0],
                                  new Engine(int.Parse(tokens[1]), int.Parse(tokens[2])),
                                  new Cargo(int.Parse(tokens[3]), tokens[4]),
                                  package.ToArray());
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.CargoType == "fragile")
                    {
                        foreach (var tire in car.Tires)
                        {
                            if (tire.Pressure < 1)
                            {
                                Console.WriteLine($"{car.Model}");
                                break;
                            }
                        }
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.Cargo.CargoType == "flamable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                }
            }
        }
    }
}
