using System;
using System.Linq;

namespace Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Action<int[]> add = list =>
            {
                for(int i = 0; i < list.Length; i++)
                {
                    list[i]++;
                }
            }; 
            Action<int[]> sub = list =>
            {
                for(int i = 0; i < list.Length; i++)
                {
                    list[i]--;
                }
            };
            Action<int[]> mul = list =>
            {
                for(int i = 0; i < list.Length; i++)
                {
                    list[i]*=2;
                }
            };
            Action<int[]> div = list =>
            {
                for(int i = 0; i < list.Length; i++)
                {
                    list[i] /= 2;
                }
            };


            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                switch (input)
                {
                    case "add":
                        add(nums);
                        break;
                    case "subtract":
                        sub(nums);
                        break;
                    case "multiply":
                        mul(nums);
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
