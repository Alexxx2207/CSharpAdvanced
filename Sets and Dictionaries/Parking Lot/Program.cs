using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carNumbers = new HashSet<string>();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(", ");
                if (tokens[0] == "IN")
                {
                    carNumbers.Add(tokens[1]);
                }
                else 
                {
                    carNumbers.Remove(tokens[1]);
                }
            }

            if (carNumbers.Any())
            {
                foreach (var carNum in carNumbers)
                {
                    Console.WriteLine(carNum);
                } 
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
