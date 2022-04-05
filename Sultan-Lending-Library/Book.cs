using System;
using System.Collections.Generic;
using System.Text;

namespace Sultan_Lending_Library
{
    public class Book
    {
        public string Title { get; set; }
        public Author Author { get; set; }

        public int NumberOfPages { get; set; }

        public Genre Genre { get; set; }

        
        public Book()
        {

        }
        public Book(string title, string firstName, string lastName, int numberOfPages, Genre genre)
        {
            {
                Title = title;
                Author = new Author()
                {
                    FirstName = firstName,
                    LastName = lastName
                };
                NumberOfPages = numberOfPages;
                Genre = genre;
            }
        }

    }
    public enum Genre
    {
        SciFi = 1,
        Mystery,
        Fantasy,
        Romance,
        NonFiction
    }
}