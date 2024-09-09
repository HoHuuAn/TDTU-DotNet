using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Library
    {
        private List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public Book FindBookByTitle(string title)
        {
            Book? book = books.Find(book => book.Title == title);
            if (book == null)
            {
                return new Book();
            }
            return book;

        }

        public void ListAllBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine("Title: " + book.Title);
                Console.WriteLine("Author: " + book.Author);
                Console.WriteLine("ISBN: " + book.ISBN);
                Console.WriteLine("Year of Publication: " + book.YearOfPublication);
                Console.WriteLine();
            }
        }

        public void ListBorrowedBooks()
        {
            foreach (Book book in books)
            {
                if (book.IsBorrowed)
                {
                    Console.WriteLine("Title: " + book.Title);
                    Console.WriteLine("Author: " + book.Author);
                    Console.WriteLine("ISBN: " + book.ISBN);
                    Console.WriteLine("Year of Publication: " + book.YearOfPublication);
                    Console.WriteLine();
                }
            }
        }
    }
}
