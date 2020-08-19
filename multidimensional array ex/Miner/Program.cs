using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Miner
{
    class Program
    {
        static int[] minerPosition = new int[2];
        static int coalCount = 0;
        static void FillMatrix(char[][] m)
        {
            for (int row = 0; row < m.Length; row++)
            {
                char[] roww = Console.ReadLine().Split().Select(char.Parse).ToArray();
                m[row] = roww;
                if (roww.Contains('s'))
                {
                    minerPosition[0] = row;
                    minerPosition[1] = Array.IndexOf(roww, 's');
                }
            }
        }
        static int CheckForCoals(char[][] m)
        {
            int hasCoals = 0;

            for (int i = 0; i < m.Length; i++)
            {
                for (int j = 0; j < m[i].Length; j++)
                {
                    if (m[i][j] == 'c')
                    {
                        hasCoals++;
                    }
                }
            }
            return hasCoals;
        }
        static void ExecuteCommands(string[] c, char[][] m)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == "up" && minerPosition[0] > 0)
                {
                    minerPosition[0]--;
                }
                else if (c[i] == "down" && minerPosition[0] < m.Length-1)
                {
                    minerPosition[0]++;
                }
                else if (c[i] == "left" && minerPosition[1] > 0)
                {
                    minerPosition[1]--;
                }
                else if (c[i] == "right" && minerPosition[1] < m[minerPosition[0]].Length - 1)
                {
                    minerPosition[1]++;
                }

                if (m[minerPosition[0]][minerPosition[1]] == 'c')
                {
                    coalCount++;
                    m[minerPosition[0]][minerPosition[1]] = '*';
                    if (CheckForCoals(m) == 0)
                    {
                        Console.WriteLine($"You collected all coals! ({minerPosition[0]}, {minerPosition[1]})");
                        break;
                    }
                }
                else if (m[minerPosition[0]][minerPosition[1]] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerPosition[0]}, { minerPosition[1]})");
                    break;
                }
                else if (CheckForCoals(m) > 0 && i == c.Length - 1)
                {
                    Console.WriteLine($"{CheckForCoals(m)} coals left. ({minerPosition[0]}, {minerPosition[1]})");
                }

            }
            
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[][] field = new char[size][];
            string[] commands = Console.ReadLine().Split();
            FillMatrix(field);
            ExecuteCommands(commands, field);

        }
    }
}
