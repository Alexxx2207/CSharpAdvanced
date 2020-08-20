using System;
using System.Collections.Generic;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new SortedDictionary<string, Dictionary<string, double>>();

            string input;

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] tokens = input.Split(", ");

                if (!shops.ContainsKey(tokens[0]))
                {
                    shops.Add(tokens[0], new Dictionary<string, double>());
                }
                shops[tokens[0]].Add(tokens[1], double.Parse(tokens[2]));
            }

            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var productPricePair in shop.Value)
                {
                    Console.WriteLine($"Product: {productPricePair.Key}, Price: {productPricePair.Value}");
                }
            }
        }
    }
}
