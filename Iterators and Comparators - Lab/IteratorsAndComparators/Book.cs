using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; private set; }
        public int Year { get; private set; }
        public IReadOnlyList<string> Authors { get; private set; }

        public Book(string title = "", int year = 0, params string[] authors)
        {
            Title = title;
            Year = year;
            Authors = new List<string>(authors);
        }

        public int CompareTo(Book other)
        {
            int result = this.Title.CompareTo(other.Title);
            if (result == 0)
            {
                result = this.Year.CompareTo(other.Year);
                if (result > 0)
                {
                    result -= result * 2;
                }
                else
                {
                    result += result * 2;
                }
            }
            return result;
        }

        
        public override string ToString()
        {
            return $"{Title} - {Year}";
        }
    }
}
