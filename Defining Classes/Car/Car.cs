using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        //Fields
        private string _make;
        private string _model;
        private int _year;
        private double _fuelQuantity;
        private double _fuelConsumption;
        private Engine _engine;
        private Tire[] _tires; 

        //Properties
        public string Make 
        {
            get { return _make; }
            set { _make = value; }
        } 
        public string Model 
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Year 
        {
            get { return _year; }
            set { _year = value; }
        }
        public double FuelQuantity 
        {
            get { return _fuelQuantity; }
            set { _fuelQuantity = value; }
        }
        public double FuelConsumption 
        {
            get { return _fuelConsumption; }
            set { _fuelConsumption = value; }
        }

        public Engine Engine { get { return _engine; } set { _engine = value; } }
        public Tire[] Tires { get { return _tires; } set { _tires = value; } }

        //Methods
        public void Drive(double distance) 
        {
            var consumption = FuelConsumption * distance / 100;
            if (consumption > FuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= consumption;
            }
        }
        public string WhoAmI()
        {
            var result = new StringBuilder();

            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.AppendLine($"HorsePowers: {this.Engine.HorsePower}");
            result.Append($"FuelQuantity: {this.FuelQuantity}");

            return result.ToString();
        }

        //Constructor
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year) : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires) : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }
    }
}
