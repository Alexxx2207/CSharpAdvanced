using System;

namespace CustomLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> nums = new MyLinkedList<int>(new int[5] { 1,2,4,5,6 } );
            Console.WriteLine(string.Join(" ", nums));
            nums.AddFirst(0);
            Console.WriteLine(string.Join(" ", nums));
            nums.AddLast(7);
            Console.WriteLine(string.Join(" ", nums));
            nums.AddBefore(nums.Find(4), new Node<int>(3));
            Console.WriteLine(string.Join(" ", nums));
            nums.AddBefore(nums.Find(4), 99);
            Console.WriteLine(string.Join(" ", nums));
            nums.AddAfter(nums.Find(5), new Node<int>(97));
            Console.WriteLine(string.Join(" ", nums));
            nums.AddAfter(nums.Find(5), 121);
            Console.WriteLine(string.Join(" ", nums));
            nums.RemoveFirst();
            Console.WriteLine(string.Join(" ", nums));
            nums.RemoveLast();
            Console.WriteLine(string.Join(" ", nums));
            nums.Remove(nums.Find(6));
            Console.WriteLine(string.Join(" ", nums));
            nums.Remove(4);
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine(nums.Contains(1000000));
            Console.WriteLine(nums.Contains(1));
        }
    }
}
