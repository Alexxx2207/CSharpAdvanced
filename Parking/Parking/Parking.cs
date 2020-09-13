using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    class Parking
    {
        private List<Car> data;
        public List<Car> Data { get { return data;  } set { data = value; } }
        public string Type { get; set; }
        public int Capacity { get; set; }

        public int Count { get { return Data.Count; } }

        public Parking(string type, int capacity)
        {
            Data = new List<Car>();
            Type = type;
            Capacity = capacity;
        }

        public void Add(Car car)
        {
            if (Capacity > Count)
            {
                Data.Add(car);
            }
        }

        public bool Remove(string manufacturer, string model)
        {
            return Data.Remove(Data.Find(car => car.Manufacturer == manufacturer && car.Model == model));
        }

        public Car GetLatestCar()
        {
            if (Count != 0)
            {
                Car latest = new Car("", "", int.MinValue);

                foreach (var car in Data)
                {
                    if (car.Year > latest.Year)
                    {
                        latest = car;
                    }
                }
                return latest; 
            }
            else
            {
                return null;
            }
        }

        public Car GetCar(string manufacturer, string model)
        {
            return Data.Find(car => car.Manufacturer == manufacturer && car.Model == model);
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"The cars are parked in {Type}:");

            foreach (var car in data)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
