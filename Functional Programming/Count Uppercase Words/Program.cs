using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = word => word[0] == word.ToUpper()[0];
            Action<string[]> printUppercaseWords = list => Console.WriteLine(string.Join(Environment.NewLine, list));

            printUppercaseWords(
                     Console.ReadLine()
                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                     .Where(checker)
                     .ToArray()
                     );
        }
    }
}
