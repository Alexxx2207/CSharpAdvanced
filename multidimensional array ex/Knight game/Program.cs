using System;
using System.Linq;

namespace Knight_game
{
    class Program
    {
        static int[,] matrix(char[,] board, int size)
        {
            int[,] matrix = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (board[row, col] == 'K')
                    {
                        if (col - 2 >= 0)
                        {
                            if (row + 1 < size)
                            {
                                if (board[row + 1, col - 2] == 'K')
                                {
                                    
                                    matrix[row,col]++;
                                }
                            }
                            if (row - 1 >= 0)
                            {
                                if (board[row - 1, col - 2] == 'K')
                                {
                                   
                                    matrix[row,col]++;

                                }
                            }
                        }
                        if (col + 2 < size)
                        {
                            if (row - 1 >= 0)
                            {
                                if (board[row - 1, col + 2] == 'K')
                                {
                                    
                                    matrix[row,col]++;

                                }
                            }
                            if (row + 1 < size)
                            {
                                if (board[row + 1, col + 2] == 'K')
                                {
                                    
                                    matrix[row,col]++;

                                }
                            }
                        }
                        if (row - 2 >= 0)
                        {
                            if (col + 1 < size)
                            {
                                if (board[row - 2, col + 1] == 'K')
                                {
                                    matrix[row,col]++;

                                }
                            }
                            if (col - 1 >= 0)
                            {
                                if (board[row - 2, col - 1] == 'K')
                                {
                                  
                                    matrix[row,col]++;

                                }
                            }
                        }
                        if (row + 2 < size)
                        {
                            if (col - 1 >= 0)
                            {
                                if (board[row + 2, col - 1] == 'K')
                                {
                                    matrix[row,col]++;

                                }
                            }
                            if (col + 1 < size)
                            {
                                if (board[row + 2, col + 1] == 'K')
                                {
                                    matrix[row,col]++;

                                }
                            }
                        }

                    }
                }
            }
            return matrix;
        }
        static int[] findBiggest(int[,] m, int size)
        {
            int[] tokens = new int[3];

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (m[row,col] > tokens[0])
                    {
                        tokens[0] = m[row, col];
                        tokens[1] = row;
                        tokens[2] = col;
                    }
                }
            }
            return tokens;
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] board = new char[size, size];

            int remove = 0;

            for (int row = 0; row < size; row++)
            {
                char[] wrow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    board[row, col] = wrow[col];
                }
            }
            while (true)
            {
                int[,] m = matrix(board, size);
                int[] tokens = findBiggest(m, size);
                if (tokens[0] == 0)
                {
                    break;
                }
                else
                {
                    board[tokens[1], tokens[2]] = '0';
                    remove++;
                }
            }

            Console.WriteLine(remove);
        }
    }
}
