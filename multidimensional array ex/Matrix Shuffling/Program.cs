using System;
using System.Linq;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] arr = new string[size[0], size[1]];

            for (int row = 0; row < size[0]; row++)
            {
                string[] r = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < size[1]; col++)
                {
                    arr[row, col] = r[col];
                }
            }

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 5 && tokens[0] == "swap" && int.Parse(tokens[1]) >= 0 && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[3]) < size[0] && int.Parse(tokens[4]) < size[1])
                {
                    int row1 = int.Parse(tokens[1]);
                    int col1 = int.Parse(tokens[2]);
                    int row2 = int.Parse(tokens[3]);
                    int col2 = int.Parse(tokens[4]);

                    string temp = arr[row1, col1];
                    arr[row1, col1] = arr[row2, col2];
                    arr[row2, col2] = temp;

                    for (int row = 0; row < size[0]; row++)
                    {
                        for (int col = 0; col < size[1]; col++)
                        {
                            Console.Write(arr[row,col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }

        }
    }
}
