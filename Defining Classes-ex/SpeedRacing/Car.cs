using System;
using System.Collections.Generic;
using System.Text;

namespace Speed_Racing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumption)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumption;
            TravelledDistance = 0;
        }

        public bool CanDrive(int km)
        {
            if (FuelConsumptionPerKilometer * km > FuelAmount)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return false;
            }
            else
            {
                FuelAmount -= FuelConsumptionPerKilometer * km;
                TravelledDistance += km;
                return true;
            }
        }
    }
}
