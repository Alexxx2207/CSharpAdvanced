using System;

namespace Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstPair = Console.ReadLine().Split();
            Tuple1<string, string,string> pair1 = new Tuple1<string,string,string>($"{firstPair[0]} {firstPair[1]}", firstPair[2], firstPair[3]);
            Console.WriteLine(pair1.Item1 + " -> " + pair1.Item2 + " -> " + pair1.Item3);
            
            string[] secondtPair = Console.ReadLine().Split();
            Tuple1<string, int,bool> pair2 = new Tuple1<string,int, bool>($"{secondtPair[0]}", int.Parse(secondtPair[1]), secondtPair[2] == "drunk");
            Console.WriteLine(pair2.Item1 + " -> " + pair2.Item2 + " -> " + pair2.Item3);
            
            string[] thirdtPair = Console.ReadLine().Split();
            Tuple1<string, double,string> pair3 = new Tuple1<string, double, string>(thirdtPair[0], double.Parse(thirdtPair[1]), thirdtPair[2]);
            Console.WriteLine(pair3.Item1 + " -> " + pair3.Item2 + " -> " + pair3.Item3);
        }
    }
}
