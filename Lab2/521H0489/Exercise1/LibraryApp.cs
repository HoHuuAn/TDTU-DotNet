using System;

namespace Exercise1
{
    internal class LibraryApp
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Harry Potter", "J. K. Rowling", "978-1338878929", 1990);
            Book b2 = new Book("The lord of the Rings", "J. R. R. Tolkien", "978-0544003415", 1980);
            Book b3 = new Book("Tony Buoi Sang - Tren Duong Bang", "Tony Buoi Sang", "8934974150510", 1995);
            Book b4 = new Book("Ut oi", "978-604-1-23448-2", "8934974150510", 2000);

            Library library = new Library();
            library.AddBook(b1);
            library.AddBook(b2);
            library.AddBook(b3);
            library.AddBook(b4);

            Console.WriteLine("==========Find Harry Potter in Library==========");
            if (library.FindBookByTitle("Harry Potter") != null )
            {
                Console.WriteLine("Found in the Library");
            }
            else
            {
                Console.WriteLine("Not Found in the Library");
            }

            Console.WriteLine("==========List of Books in Library==========");
            library.ListAllBooks();

            Console.WriteLine("==========After Remove Ut oi in Library==========");
            library.RemoveBook(b4);
            library.ListAllBooks();


            Person p1 = new Person("An", 20);
            Person p2 = new Person("Bao", 22);

            p1.BorrowBook(b1);
            p2.BorrowBook(b2);


            Console.WriteLine("==========List of Borrowed Book in Library==========");
            library.ListBorrowedBooks();

            p1.ReturnBook(b1);
            Console.WriteLine("==========List of Borrowed Book in Library After return==========");
            library.ListBorrowedBooks();

            Console.ReadKey();
        }
    }
}