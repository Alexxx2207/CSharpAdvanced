using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public IEnumerator<Book> GetEnumerator() =>  new LibraryIterator(this.books);
        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();   
                this.books = new List<Book>(books);
            }


            public Book Current => this.books[this.currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
              
            }

            public bool MoveNext()
            {
                return ++currentIndex < this.books.Count;
            }

            public void Reset()
            {
                currentIndex = -1;
            }
        }
        private List<Book> books;
        public Library(params Book[] books)
        {

            IComparer<Book> comparer = new BookComparator();
            this.books = new List<Book>(books);
            this.books.Sort(comparer);

        }
    }
}
