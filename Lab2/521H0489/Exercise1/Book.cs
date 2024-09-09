using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Book
    {
        public String Title;
        public String Author;
        public String ISBN;
        public int YearOfPublication;
        public bool IsBorrowed;

        public Book()
        {
        }


        public Book(string title, string author, string iSBN, int yearofPublication)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            YearOfPublication = yearofPublication;
        }
    }
}
