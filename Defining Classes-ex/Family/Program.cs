using System;

namespace Family
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Family familia = new Family();
            for (int i = 0; i < N; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                if (int.Parse(tokens[1]) > 30)
                {
                    familia.AddMember(new Person(tokens[0], int.Parse(tokens[1]))); 
                }
            }

            familia.SortAndPrintMembers();
        }
    }
}
