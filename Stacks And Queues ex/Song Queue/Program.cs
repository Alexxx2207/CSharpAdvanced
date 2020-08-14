using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Song_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));

            while (songs.Any())
            {
                string[] tokens = Console.ReadLine().Split();

                if (tokens[0] == "Play")
                {
                    songs.Dequeue();
                }
                else if (tokens[0] == "Add")
                {
                    StringBuilder song = new StringBuilder();
                    for (int i = 1; i < tokens.Length; i++)
                    {
                        if (i + 1 != tokens.Length)
                        {
                            song.Append(tokens[i] + " ");
                        }
                        else
                        {
                            song.Append(tokens[i]);

                        }
                    }
                    if (!songs.Contains(song.ToString()))
                    {
                        songs.Enqueue(song.ToString()); 
                    }
                    else
                    {
                        Console.WriteLine($"{song.ToString()} is already contained!");
                    }
                }
                else if (tokens[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
