using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    class ListyIterator <T> : IEnumerable<T>
    {
        private List<T> elements;

        private int currentIndex;
        public ListyIterator(List<T> el)
        {
            currentIndex = 0;
            elements = el;
        }

        public bool Move()
        {
            bool hasNext = this.HasNext();
            if (hasNext)
            {
                currentIndex++;
                             
            }
            return hasNext;
        }

        public void Print()
        {
            if(!elements.Any())
            {
                throw new InvalidOperationException("Invalid Operation!");

            }
           
            Console.WriteLine(elements[currentIndex].ToString());

        }

        public bool HasNext()
        {
            if (currentIndex < elements.Count - 1)
            {
                return true;
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in elements)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
