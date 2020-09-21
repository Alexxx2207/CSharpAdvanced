using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class SportCar : Car
    {
        private const double DefaultSportCarFuelConsumption = 10;

        public override double FuelConsumption => DefaultSportCarFuelConsumption;

        public SportCar(int horsePower, double fuel) : base(horsePower, fuel)
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
