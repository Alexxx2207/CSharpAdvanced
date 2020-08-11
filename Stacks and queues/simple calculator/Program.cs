using System;
using System.Collections.Generic;
using System.Linq;

namespace simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<int> numbers = new Stack<int>();
            Stack<char> operators = new Stack<char>();
            string operatorsPattern = "+-";

            for (int i = input.Length - 1; i > -1; i--)
            {
                if (int.TryParse(input[i], out int value))
                {
                    numbers.Push(value);
                }
                else if (char.TryParse(input[i], out char @char))
                {
                    if (operatorsPattern.Contains(@char))
                    {
                        operators.Push(@char);
                    }
                }
            }
            numbers.Reverse();
            while (operators.Count != 0 && numbers.Count > 1)
            {
                int num1 = numbers.Pop();
                int num2 = numbers.Pop();
                char op = operators.Pop();

                numbers.Push(Evaluate(num1, num2, op));
            }
            Console.WriteLine(numbers.Pop());
        }

        static int Evaluate(int num1, int num2, char op)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;

                case '-': return num1 - num2;
                default: return 0;
            }
        }
    }
}
