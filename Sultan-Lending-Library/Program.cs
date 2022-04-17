using System;
using System.Collections;
using System.Collections.Generic;



namespace Sultan_Lending_Library
{
    class Program
    {
        public static Library<Book> library = new Library<Book>();
        public static Backpack<Book> backpack = new Backpack<Book>();


        public static void Main(string[] args)
        {
          
            PhilOurLibrary();
            UserInterFace();
        }

        public static void UserInterFace()
        {
            int userChoice = 0;
            while (userChoice != 6)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. View All Books");
                Console.WriteLine("2. Add a Book");
                Console.WriteLine("3. Borrow a Book");
                Console.WriteLine("4. Return a Book");
                Console.WriteLine("5. View Your Book Bag");
                Console.WriteLine("6. Exit");

                userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        Console.Clear();
                        ViewLibrary();
                        break;
                    case 2:
                        Console.Clear();
                        AddABookToLibrary();
                        break;
                    case 3:
                        Console.Clear();
                        BorrowABook();
                        break;
                    case 4:
                        Console.Clear();
                        ReturnBook();
                        break;
                    case 5:
                        Console.Clear();
                        ViewBookBag();
                        break;
                    default:
                        Console.Beep();
                        Console.WriteLine("Invaled number Plz Enter right number");
                        break;
                }


            }
        }
    
        public static void ViewLibrary()
        {
            Console.WriteLine("Here are the books in the library: \n");

            foreach (Book book in library)
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.Title} by {book.Author.FirstName} {book.Author.LastName}, with {book.NumberOfPages} pages ");
                }
            }
        }

        public static void ViewBookBag()
        {
            Console.WriteLine("Here are the books in your book bag:");
            foreach (Book book in backpack)
            {
                if (book != null)
                {
                    Console.WriteLine($"{book.Title} by {book.Author.FirstName} {book.Author.LastName}, with {book.NumberOfPages} pages ");
                }
            }
        }

        public static void AddABookToLibrary()
        {
            Console.WriteLine("Please enter the title of the book:");
            string thisTitle = Console.ReadLine();
            Console.WriteLine("Please enter the first name of the author");
            string thisFirstName = Console.ReadLine();
            Console.WriteLine("Please enter the last name of the author");
            string thisLastName = Console.ReadLine();
            Console.WriteLine("Please enter the number of pages in the book");
            int thisPageNumber = Convert.ToInt32(Console.ReadLine());
            
            library.Add(thisTitle, thisFirstName, thisLastName, thisPageNumber);
            Console.WriteLine("Successfully added your book to the library");
        }

        public static void BorrowABook()
        {
            int count = 1;
            foreach (Book book in library)
            {
                Console.WriteLine($" {count++}. {book.Title} BY {book.Author.FirstName} {book.Author.LastName}");
            }
            Console.WriteLine();
            Console.WriteLine("Which book would you like to borrow?");
            string userChoice = Console.ReadLine();
            if (userChoice == null)
            {
                Console.WriteLine("Sorry that book is not available, try again!");
            }
            else
            {
            Book Borrowed = library.Borrow(userChoice);
            backpack.Pack(Borrowed);

            }
        }

        static void ReturnBook()
        {
            int counter = 1;
            foreach (Book item in backpack)
            {
                Console.WriteLine($"{counter++}. {item.Title}");
            }
            Console.WriteLine();
            Console.WriteLine("Which book would you like to return");
            int response = Convert.ToInt32(Console.ReadLine());
            Book Returned = backpack.Unpack(response - 1);
            library.Return(Returned);
        }

        public static void PhilOurLibrary()
        {
            library.Add("The Lord of the Rings", "J.R.R.", "Tolkien", 1007);
            library.Add("Carrie", "Steven", "King", 199);
            library.Add("The Left Hand Of Darkness", "Ursula K.", "LeGuin", 286);
            library.Add("Fifty Shades of Grey", "E.L.", "James", 514);
            library.Add("Experience the Joy of Painting", "Bob", "Ross", 68);
            
        }




    }
}
  

