using System;
using System.Collections.Generic;

namespace Speed_Racing
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                cars.Add(tokens[0], new Car(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2])));
            }

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input.Split();

                if (cars.ContainsKey(tokens[1]))
                {
                    cars[tokens[1]].CanDrive(int.Parse(tokens[2]));
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} {car.Value.FuelAmount:f2} {car.Value.TravelledDistance}");
            }

        }
    }
}
