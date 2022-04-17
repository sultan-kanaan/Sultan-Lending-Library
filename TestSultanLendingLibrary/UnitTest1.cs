using System;
using Xunit;
using Sultan_Lending_Library;

namespace TestSultanLendingLibrary
{
    public class UnitTest1
    {
       
            [Fact]
            public void Add_Book_To_Library_That_Exists()
            {
                Library<Book> Library = new Library<Book>();
                Library.Add("The Lord of the Rings", "J.R.R.", "Tolkien", 100);
                int expected = 1;
                Assert.Equal(expected, Library.Count);
        }

            [Fact]
            public void TestBorrowing()
            {
            Library<Book> library = new Library<Book>();
            Book expected = new Book("The Lord of the Rings", "J.R.R.", "Tolkien", 100);
            library.Return(expected);
            Assert.Contains(expected, library);
            }

            [Fact]
            public void TestUnpackBackpack()
            {
            Backpack<Book> backpack = new Backpack<Book>();
            Book expected = new Book("The Lord of the Rings", "J.R.R.", "Tolkien", 100);
            Assert.DoesNotContain(expected, backpack);
            }
    }
}
