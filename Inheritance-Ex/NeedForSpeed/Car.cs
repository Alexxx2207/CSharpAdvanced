using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        private const double DefaultCarFuelConsumption = 3;
        public override double FuelConsumption => DefaultCarFuelConsumption;

        public Car(int horsePower, double fuel) : base(horsePower, fuel)
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
