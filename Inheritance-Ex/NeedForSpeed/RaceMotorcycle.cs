using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double DefaultFuelConsumptionForRaceMotorCycle = 8;
        public override double FuelConsumption => DefaultFuelConsumptionForRaceMotorCycle;
        public RaceMotorcycle(int horsepower, double fuel) : base(horsepower, fuel)
        {

        }
        public override void Drive(double kilometers)
        {
            if (kilometers * FuelConsumption <= Fuel)
            {
                Fuel -= kilometers * FuelConsumption;
            }
        }
    }
}
