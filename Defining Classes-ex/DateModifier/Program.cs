using System;

namespace DateModifierN
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime();
            d1 = DateTime.Parse(Console.ReadLine());
            DateTime d2 = new DateTime();
            d2 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(DateModifier.Calc(d1, d2));
        }
    }
}
