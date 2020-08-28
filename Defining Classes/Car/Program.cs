using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();
            var tiresPacket = new List<Tire[]>();
            var engines = new List<Engine>();
            string input;

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tireInfo = input.Split();
                Tire[] currentTirePacket = new Tire[4];

                for (int j = 0, packetConter = 0; j < tireInfo.Length - 1; j += 2, packetConter++)
                {
                    currentTirePacket[packetConter] = new Tire(int.Parse(tireInfo[j]), double.Parse(tireInfo[j + 1]));
                }
                tiresPacket.Add(currentTirePacket);

            }

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = input.Split();
                engines.Add( new Engine( int.Parse(engineInfo[0]), double.Parse(engineInfo[1]) ) );
            }

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input.Split();
                cars.Add(new Car(carInfo[0],
                                 carInfo[1],
                                 int.Parse(carInfo[2]),
                                 double.Parse(carInfo[3]),
                                 double.Parse(carInfo[4]),
                                 engines[int.Parse(carInfo[5])],
                                 tiresPacket[int.Parse(carInfo[6])]));
            }

            foreach (var car in cars)
            {
                double tiresPressureSum = 0;
                for (int i = 0; i < car.Tires.Length; i++)
                {
                    tiresPressureSum += car.Tires[i].Pressure;
                }
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && tiresPressureSum >= 9 && tiresPressureSum <= 10)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }
}
