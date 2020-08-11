using System;
using System.Collections.Generic;
using System.Linq;

namespace Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> indexes = new Stack<int>();

            string line = Console.ReadLine();
            char[] input = line.ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    indexes.Push(i);
                }
                else if (input[i] == ')')
                {
                    Console.WriteLine(line.Substring(indexes.Peek(), i - indexes.Pop()+1));
                }
            }
        }
    }
}
