namespace Exercise4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //========================================================== Integer ==========================================================
            Console.WriteLine("=================== Integer ===================");
            CustomList<int> intList = new CustomList<int>();

            // Adding items
            for (int i = 0; i < 10; i++)
            {
                intList.Add(i);
                Console.WriteLine("Count: " + intList.Count + ", Capacity: " + intList.Capacity);
            }
            // Retrieving items
            Console.WriteLine("Items in the list:");
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }

            // Removing an item
            intList.Remove(4);

            // Retrieving items after removal
            Console.WriteLine("Items in the list after removal:");
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine(intList[i]);
            }


            //========================================================== Animal ==========================================================
            Console.WriteLine("=================== Animal ===================");
            CustomList<Animal> animalList = new CustomList<Animal>();

            // Adding items
            for (int i = 1; i <= 15; i++)
            {
                Animal animal = new Animal()
                {
                    Name = "Animal " + i,
                    Age = i
                };

                animalList.Add(animal);
                Console.WriteLine("Count: " + animalList.Count + ", Capacity: " + animalList.Capacity);
            }
            // Retrieving items
            Console.WriteLine("Items in the list:");
            for (int i = 0; i < animalList.Count; i++)
            {
                Console.WriteLine(animalList[i]);
            }
            // Removing an item
            animalList.RemoveAt(6);
            // Retrieving items after removal
            Console.WriteLine("Items in the list after removal:");
            for (int i = 0; i < animalList.Count; i++)
            {
                Console.WriteLine(animalList[i]);
            }
            

            //========================================================== Book ==========================================================
            Console.WriteLine("=================== Book ===================");
            CustomList<Book> bookList = new CustomList<Book>();

            // Adding items
            for (int i = 1; i <= 20; i++)
            {
                Book book = new Book()
                {
                    Title = "Book " + i,
                    Author = "Author " + i,
                    Year = 2000 + i
                };

                bookList.Add(book);
                Console.WriteLine("Count: " + bookList.Count + ", Capacity: " + bookList.Capacity);
            }
            // Retrieving items
            Console.WriteLine("Items in the list:");
            for (int i = 0; i < bookList.Count; i++)
            {
                Console.WriteLine(bookList[i]);
            }
            // Removing an item
            bookList.RemoveAt(2);
            // Retrieving items after removal
            Console.WriteLine("Items in the list after removal:");
            for (int i = 0; i < bookList.Count; i++)
            {
                Console.WriteLine(bookList[i]);
            }


            //========================================================== Movie ==========================================================
            Console.WriteLine("=================== Movie ===================");
            CustomList<Movie> movieList = new CustomList<Movie>();

            // Adding items
            for (int i = 1; i <= 12; i++)
            {
                Movie movie = new Movie()
                {
                    Title = "Movie " + i,
                    Director = "Director " + i,
                    Year = 2010 + i
                };

                movieList.Add(movie);
                Console.WriteLine("Count: " + movieList.Count + ", Capacity: " + movieList.Capacity);
            }
            // Retrieving items
            Console.WriteLine("Items in the list:");
            for (int i = 0; i < movieList.Count; i++)
            {
                Console.WriteLine(movieList[i]);
            }
            // Removing an item
            movieList.RemoveAt(3);
            // Retrieving items after removal
            Console.WriteLine("Items in the list after removal:");
            for (int i = 0; i < movieList.Count; i++)
            {
                Console.WriteLine(movieList[i]);
            }

        }
    }
}