using System;
using System.Linq;

namespace Present_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPresents = int.Parse(Console.ReadLine());
            int sizeOfTheNeighborhood = int.Parse(Console.ReadLine());

            int numberOfV = 0;
            int SantaRow = 0, SantaCol = 0;

            char[,] hood = new char[sizeOfTheNeighborhood, sizeOfTheNeighborhood];

            /// fill matrix + Santa coords
            for (int row = 0; row < sizeOfTheNeighborhood; row++)
            {
                char[] rowInfo = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < sizeOfTheNeighborhood; col++)
                {
                    if (rowInfo[col] == 'S')
                    {
                        SantaCol = col;
                        SantaRow = row;
                    }
                    else if (rowInfo[col] == 'V')
                    {
                        numberOfV++;
                    }
                    hood[row, col] = rowInfo[col];
                }
            }

            hood[SantaRow, SantaCol] = '-';
            string input;

            while (countOfPresents > 0 && (input = Console.ReadLine()) != "Christmas morning")
            {
                if (input == "up" && SantaRow > 0)
                {
                    SantaRow--;
                }
                else if (input == "down" && SantaRow < sizeOfTheNeighborhood - 1)
                {
                    SantaRow++;
                }
                else if (input == "left" && SantaCol > 0)
                {
                    SantaCol--;
                }
                else if (input == "right" && SantaCol < sizeOfTheNeighborhood - 1)
                {
                    SantaCol++;
                }

                if (hood[SantaRow,SantaCol] == 'V')
                {
                    countOfPresents--;
                    hood[SantaRow, SantaCol] = '-';
                }
                else if (hood[SantaRow, SantaCol] == 'C')
                {
                    if (hood[SantaRow - 1, SantaCol] == 'X' || hood[SantaRow - 1, SantaCol] == 'V')
                    {
                        
                        hood[SantaRow - 1, SantaCol] = '-';
                        countOfPresents--;
                       
                    }
                    if (hood[SantaRow + 1, SantaCol] == 'X' || hood[SantaRow + 1, SantaCol] == 'V')
                    {
                        countOfPresents--;

                        hood[SantaRow + 1, SantaCol] = '-';
                    }
                    if (hood[SantaRow, SantaCol - 1] == 'X' || hood[SantaRow, SantaCol - 1] == 'V')
                    {
                        countOfPresents--;

                        hood[SantaRow, SantaCol - 1] = '-';
                    }
                    if (hood[SantaRow, SantaCol + 1] == 'X' || hood[SantaRow, SantaCol + 1] == 'V')
                    {
                        countOfPresents--;

                        hood[SantaRow, SantaCol + 1] = '-';
                    }   
                }
                else
                {
                    hood[SantaRow, SantaCol] = '-';

                }
            }

            if (countOfPresents == 0)
            {
                Console.WriteLine("Santa ran out of presents!");
            }
            int numberOfVleft = 0;
            hood[SantaRow, SantaCol] = 'S';
            //print
            for (int row = 0; row < sizeOfTheNeighborhood; row++)
            {
                for (int col = 0; col < sizeOfTheNeighborhood; col++)
                {
                    
                    if (hood[row,col] == 'V')
                    {
                        numberOfVleft++;
                    }
                    Console.Write(hood[row,col] + " ");
                }
                Console.WriteLine();
            }

            if (numberOfVleft == 0)
            {
                Console.WriteLine($"Good job, Santa! {numberOfV} happy nice kid/s.");
            }
            else
            {
                Console.WriteLine($"No presents for {numberOfVleft} nice kid/s.");
            }


        }
    }
}
