using System;

namespace GenericCountMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            Box<double> value = new Box<double>(double.Parse(Console.ReadLine()));
            Console.WriteLine(value.GreaterThan(arr));
        }
    }
}
