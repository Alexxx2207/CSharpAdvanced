using System;
using System.Linq;

namespace Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string length = Console.ReadLine();

            string[] names = Console.ReadLine().Split();


            Predicate<string[]> isValid = name => name[0].Length <= int.Parse(name[1]); 
            Action<string[]> print = list => Console.WriteLine(string.Join(Environment.NewLine, list.Where(name => isValid(new string[2] { name, length }))));

            print(names);
        }
    }
}
