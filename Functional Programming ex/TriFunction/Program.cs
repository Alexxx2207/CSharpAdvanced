using System;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printName = name => Console.WriteLine(name);

            Func<string, int, bool> checkerFunc = (name, num) =>
            {
                if (name.Sum(c => c) >= num)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            Func<Func<string, int, bool>, int, string[], string> logic = (checker, number, names) =>
            {
                foreach (var name in names)
                {
                    if (checker(name, number))
                    {
                        return name;
                    }
                    else
                    {
                        continue;
                    }
                }
                return "";
            };

            printName( logic ( checkerFunc, int.Parse(Console.ReadLine()), Console.ReadLine().Split() ) );
        }
    }
}
