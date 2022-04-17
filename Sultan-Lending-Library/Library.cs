using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sultan_Lending_Library
{
    public class Library<Book> : IEnumerable
    {
        public static Book[] library = new Book[5];
        public static int count;
        
        public void Add(Book book)
        {
          if (count == library.Length)
          {
            Array.Resize(ref library, library.Length * 2);
          }
            library[count++] = book;
        }
        public Book Remove(Book book)
        {
            int temporaryCounter = 0;
            Book[] temp;
            Book removed = default(Book);
            if (count < library.Length / 2)
            {
                temp = new Book[count - 1];
            }
            else
            {
                temp = new Book[library.Length];
            }

            for (int i = 0; i < count; i++)
            {
                if (library[i] != null)
                {
                    if (library[i].Equals(book))
                    {
                        removed = library[i];
                    }
                    else
                    {
                        temp[temporaryCounter] = library[i];
                        temporaryCounter++;
                    }
                }
            }  
            library = temp;
            count--;

            return removed;
        }
        
        public int Count()
        {
            return count;
        }
       

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return library[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}

