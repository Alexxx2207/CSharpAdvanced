using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    class Parking
    {
        private Dictionary<string, Car> cars;
        private int capacity;
        private int count;
        public Dictionary<string,Car> Cars { get { return cars; } set { cars = value; } }
        public int Capacity { get { return capacity; } set { capacity = value; } }
        public int Count { get { return count; } set { count = value; } }
        public Parking(int capacity)
        {
            Cars = new Dictionary<string, Car>();
            Capacity = capacity;
            Count = 0;
        }

        public string AddCar(Car Car)
        {
            if (Cars.ContainsKey(Car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (Count >= Capacity)
            {
                return "Parking is full!";
            }
            else
            {
                Cars.Add(Car.RegistrationNumber, Car);
                Count++;
                return $"Successfully added new car {Car.Make} {Car.RegistrationNumber}";
            }
        }
        public string RemoveCar(string RegistrationNumber)
        {
            if (!Cars.ContainsKey(RegistrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                Cars.Remove(RegistrationNumber);
                Count--;
                return $"Successfully removed {RegistrationNumber}";
            }
        }

        public Car GetCar(string RegistrationNumber)
        {
            return Cars[RegistrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var num in RegistrationNumbers)
            {
                if (Cars.ContainsKey(num))
                {
                    Cars.Remove(num);
                    Count--;
                }
            }
        }
    }
}
