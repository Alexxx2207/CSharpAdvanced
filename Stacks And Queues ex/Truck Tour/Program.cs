using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace Truck_Tour
{
    class Pump
    {
        public int number { get; set; }
        public int petrolReserve { get; set; }
        public int disctanceFromTheNext { get; set; }

        public Pump(int num,int pr, int dftn)
        {
            number = num;
            petrolReserve = pr;
            disctanceFromTheNext = dftn;
        }
    }
    class Program
    {
        static bool CheckIfItWorks(Queue<Pump> c, int si)
        {
            int crossed = 0;
            Pump[] temp = c.ToArray();
            int oilinTheTank = 0;
            int i = 0;
            while (crossed < c.Count)
            {
                if (temp[i].petrolReserve + oilinTheTank >= temp[i].disctanceFromTheNext)
                {
                    crossed++;
                    oilinTheTank += temp[i].petrolReserve;
                    oilinTheTank -= temp[i].disctanceFromTheNext;
                    i++;
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int countPumps = int.Parse(Console.ReadLine());
            int startingpoint = 0;
            Queue<Pump> circle = new Queue<Pump>();

            for (int i = 0; i < countPumps; i++)
            {
                int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
                circle.Enqueue(new Pump(i, data[0], data[1]));
                
            }

            for (int i = 0; i < countPumps; i++)
            {
                if (circle.Peek().petrolReserve >= circle.Peek().disctanceFromTheNext)
                {
                    startingpoint = i;

                    if (CheckIfItWorks(circle, startingpoint))
                    {
                        break;
                    }
                    else
                    {
                        circle.Enqueue(circle.Dequeue());
                    }

                }
                else
                {
                    circle.Enqueue(circle.Dequeue());
                }
            }
            Console.WriteLine(startingpoint);
        }
    }
}
