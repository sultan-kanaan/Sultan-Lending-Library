using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sultan_Lending_Library
{
    public class Library<T> : ILibrary
    {
        private Dictionary<string, Book> Dictionary = new Dictionary<string, Book>();

        public int Count { set; get; }

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            Dictionary.Add(title, new Book(title, firstName, lastName, numberOfPages));
            Count++;
        }
        public Book Borrow(string title)
        {
            if (Dictionary.ContainsKey(title))
            {
                Book book = Dictionary[title];
                Dictionary.Remove(title);
                Count--;
                return book;
            }
            else
            {
                return null;
            }

        }
        public void Return(Book book)
        {
            Dictionary.Add(book.Title, book);
            Count++;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book book in Dictionary.Values)
                yield return book;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

