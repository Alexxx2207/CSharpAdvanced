using System;
using System.Linq;

namespace Radioactive_Mutant_Vampire_Bunnies
{
    class Program
    {
        static int[] PP = new int[2];
        static void FillMatrix(char[,] m)
        {
            for (int row = 0; row < m.GetLength(0); row++)
            {
                char[] roww = Console.ReadLine().ToCharArray();
                for (int i = 0; i < m.GetLength(1); i++)
                {
                    m[row, i] = roww[i];
                }
                if (roww.Contains('P'))
                {
                    PP[0] = row;
                    PP[1] = Array.IndexOf(roww, 'P'); 
                }
            }
        }
        static bool ExecuteCommands(char[,] m, char[] c)
        {
            bool isWin = false;
            bool end = false;
            for (int i = 0; i < c.Length && !end; i++)
            {
                if (c[i] == 'U')
                {
                    if (PP[0] == 0)
                    {
                        end = true;
                        isWin = true;
                    }
                    else
                    {
                        m[PP[0], PP[1]] = '.';
                        PP[0]--;
                    }
                }
                else if (c[i] == 'D')
                {
                    if (PP[0] == m.GetLength(0) - 1)
                    {
                        end = true;
                        isWin = true;

                    }
                    else
                    {
                        m[PP[0], PP[1]] = '.';

                        PP[0]++;
                    }
                }
                else if (c[i] == 'R')
                {
                    if (PP[1] == m.GetLength(1) - 1)
                    {
                        end = true;
                        isWin = true;

                    }
                    else
                    {
                        m[PP[0], PP[1]] = '.';

                        PP[1]++;
                    }
                }
                else if (c[i] == 'L')
                {
                    if (PP[1] == 0)
                    {
                        end = true;
                        isWin = true;

                    }
                    else
                    {
                        m[PP[0], PP[1]] = '.';

                        PP[1]--;
                    }
                }

                if (BunniesSpread(m))
                {
                    end = true;
                }
            }
            
            return isWin;
        }
        static bool Validation(char[,] m, int r, int c)
        {
            return r >= 0 && c >= 0 && r < m.GetLength(0) && c < m.GetLength(1) && (m[r, c] == '.' || m[r, c] == 'P' || m[r, c] == 'V');
        }
        static void Spread(char[,] m, int r, int c)
        {
            if (Validation(m, r - 1, c)) m[r - 1, c] = 'V';
            if (Validation(m, r + 1, c)) m[r + 1, c] = 'V';
            if (Validation(m, r, c + 1)) m[r, c + 1] = 'V';
            if (Validation(m, r, c - 1)) m[r, c - 1] = 'V';
        }
        static bool BunniesSpread(char[,] m)
        {
            bool catched = false;
            for (int row = 0; row < m.GetLength(0); row++)
            {
                for (int col = 0; col < m.GetLength(1); col++)
                {
                    if (m[row, col] == 'B')
                    {
                        Spread(m, row, col);
                        
                    }
                }
            }
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (m[i, j] == 'V')
                    {
                        m[i, j] = 'B';
                    }
                }
            }
            if (m[PP[0], PP[1]] == 'B')
            {
                catched = true;
            }
            return catched;
        }
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] lair = new char[size[0], size[1]];
            FillMatrix(lair);

            char[] commands = Console.ReadLine().ToCharArray();

            if (ExecuteCommands(lair, commands))
            {
                for (int row = 0; row < lair.GetLength(0); row++)
                {
                    for (int col = 0; col < lair.GetLength(1); col++)
                    {
                        Console.Write(lair[row, col]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"won: {PP[0]} {PP[1]}");

            }
            else
            {
                for (int row = 0; row < lair.GetLength(0); row++)
                {
                    for (int col = 0; col < lair.GetLength(1); col++)
                    {
                        Console.Write(lair[row, col]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"dead: {PP[0]} {PP[1]}");

            }
        }
    }
}
