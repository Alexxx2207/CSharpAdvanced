using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            List<string> elements = Console.ReadLine().Split().Skip(1).ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(elements);

            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                else if (input == "Move")
                {
                    Console.WriteLine(listyIterator.Move());
                }
                else if (input == "HasNext")
                {
                    Console.WriteLine(listyIterator.HasNext());
                }
                else if(input == "PrintAll")
                {
                    Console.WriteLine(string.Join(" ", listyIterator));
                }
            }
        }
    }
}
