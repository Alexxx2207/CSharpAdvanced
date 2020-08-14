using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> str = new Stack<char>();
            bool isOk = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '[' || input[i] == '(')
                {
                    str.Push(input[i]);
                }
                else
                {
                    if (str.Any() && ( (input[i] == ')' && str.Peek() == '(') || (input[i] == ']' && str.Peek() == '[') || (input[i] == '}' && str.Peek() == '{') ))
                    {
                        str.Pop();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        isOk = false;
                        break;
                    }
                }
            }
            if (isOk)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
