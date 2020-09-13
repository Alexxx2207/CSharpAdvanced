using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
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

        public override string ToString()
        {
            return $"{type}: {value}";
        }
    }
}
