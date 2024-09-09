using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Person
    {
        public String Name;
        public int Age;
        public List<Book> BorrowedBooks;


        public Person(String name, int age) { 
            Name = name;
            Age = age;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (!book.IsBorrowed)
            {
                book.IsBorrowed = true;
                BorrowedBooks.Add(book);
                Console.WriteLine($"{Name} borrowed {book.Title} successfully");
            }
            else
            {
                Console.WriteLine("Book is already borrowed.");
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                book.IsBorrowed = false;
                BorrowedBooks.Remove(book);
                Console.WriteLine($"{Name} return {book.Title} successfully");
            }
            else
            {
                Console.WriteLine("Book is not borrowed by this person.");
            }
        }

    }
}
