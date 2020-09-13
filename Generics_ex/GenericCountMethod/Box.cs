using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethod
{
    class Box<T>
    {
        private readonly T value;
        private string type;

        public Box(T value)
        {
            this.value = value;
            type = value.GetType().ToString();
            
        }

        public int GreaterThan(T[] elements)
        {
            int count = 0;
            Comparer<T> comparer = Comparer<T>.Default;
            foreach (var item in elements)
            {
                if (comparer.Compare(item, value) > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public override string ToString()
        {
            return $"{type}: {value}";
        }
    }
}
