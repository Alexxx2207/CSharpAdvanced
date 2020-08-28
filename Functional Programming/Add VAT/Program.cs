using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVAT = price => price += price * 0.2m;
            Action<decimal> print = prices => Console.WriteLine($"{prices:f2}");

            decimal[] prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(addVAT)
                .ToArray();
            foreach (var price in prices)
            {
                print(price);
            }
        }
    }
}
