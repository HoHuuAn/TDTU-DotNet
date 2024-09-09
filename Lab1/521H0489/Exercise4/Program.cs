namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = ReadWordsFromFile("words.txt");

            do
            {
                Console.Write("Enter a word to search: ");

                string searchWord = Console.ReadLine();

                bool findWord = SearchWord(words, searchWord);

                if (findWord)
                {
                    Console.WriteLine($"The word '{searchWord}' is in the list.");
                }
                else
                {
                    Console.WriteLine($"The word '{searchWord}' was not found in the list.");
                }

            }while (true);
        }

        static List<string> ReadWordsFromFile(string filePath)
        {
            List<string> words = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        words.Add(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
            }
            return words;
        }

        static bool SearchWord(List<string> words, string searchWord)
        {
            return words.Contains(searchWord);
        }
    }
}