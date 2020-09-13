using System;

namespace GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                Box<object> box = new Box<object>(int.Parse(line));
                Console.WriteLine(box.ToString());
            }
        }
    }
}
