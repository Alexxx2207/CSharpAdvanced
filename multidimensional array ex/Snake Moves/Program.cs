using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] arr = new char[size[0], size[1]];
            string snake = Console.ReadLine();
            char direction = 'l';

            Queue<char> snakeBuffer = new Queue<char>(snake);
            for (int row = 0; row < size[0]; row++)
            {
                for (int col = 0; col < size[1]; col++)
                {
                   
                    if (!snakeBuffer.Any())
                    {
                        for (int i = 0; i < snake.Length; i++)
                        {
                            snakeBuffer.Enqueue(snake[i]); 
                        }
                    }

                    if (direction == 'l')
                    {
                        arr[row, col] = snakeBuffer.Dequeue();
                    }
                    else
                    {
                        arr[row, size[1] - col - 1] = snakeBuffer.Dequeue();

                    }
                }
                if (direction == 'l')
                {
                    direction = 'r';
                }
                else
                {
                    direction = 'l';
                }
            }
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
