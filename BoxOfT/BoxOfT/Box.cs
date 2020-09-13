using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    class Box<T>
    {
        private Stack<T> box;
        public int Count { get { return box.Count; } }
        public Box()
        {
            box = new Stack<T>();
        }
        public void Add(T element)
        {
            box.Push(element);
        }
        public T Remove()
        {
            return box.Pop();
        }
    }
}
