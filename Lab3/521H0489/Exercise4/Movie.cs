using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, Director: {Director}, Year: {Year}";
        }
    }
}
