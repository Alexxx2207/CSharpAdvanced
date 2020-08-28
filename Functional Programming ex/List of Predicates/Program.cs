using System;
using System.Collections.Generic;
using System.Linq;

namespace List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> answer = list => 
            {
                HashSet<int> dividers = new HashSet<int>();

                foreach (int item in Console.ReadLine().Split().Select(int.Parse).ToArray())
                {
                    dividers.Add(item);
                }

                foreach (var div in dividers)
                {
                    list.RemoveAll(num => num % div != 0);
                }
                Console.WriteLine(string.Join(" ", list));
            };
           
            answer(Enumerable.Range(1, int.Parse(Console.ReadLine())).ToList());
        }
    }
}
