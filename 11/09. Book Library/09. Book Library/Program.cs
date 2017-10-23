namespace _09.Book_Library
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.IO;
    using System.Text;

    public class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Publisher { get; set; }
        public string IsbnNumber { get; set; }
        public double Price { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(File.ReadLines("Input.txt").First());
            Library booksByAutor = new Library();
            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                books.Add(ReadBook(i + 2));
            }

            booksByAutor.Books = books;
            Dictionary<string, double> pricePerAutor = AddValuesToDictionary(booksByAutor);
            PrintResults(pricePerAutor);
        }

        static void PrintResults(Dictionary<string, double> pricePerAutor)
        {

            using (StreamWriter outputFile = new StreamWriter("Output.txt"))
            {
                foreach (var autor in pricePerAutor.OrderByDescending(a => a.Value).ThenBy(b => b.Key))
                {
                    outputFile.WriteLine("{0} -> {1:f2}", autor.Key, autor.Value);
                }
            }


        }

        public static Dictionary<string, double> AddValuesToDictionary(Library booksByAutor)
        {
            Dictionary<string, double> pricePerAutor = new Dictionary<string, double>();

            for (int i = 0; i < booksByAutor.Books.Count; i++)
            {
                if (!pricePerAutor.ContainsKey(booksByAutor.Books[i].Autor))
                {
                    pricePerAutor.Add(booksByAutor.Books[i].Autor, 0);
                }

                pricePerAutor[booksByAutor.Books[i].Autor] += booksByAutor.Books[i].Price;
            }

            return pricePerAutor;
        }

        private static string GetLine(string fileName, int line)
        {
            using (var sr = new StreamReader(fileName))
            {
                for (int i = 1; i < line; i++)
                    sr.ReadLine();
                return sr.ReadLine();
            }
        }

        private static Book ReadBook(int line)
        {
            Book book = new Book();

            string[] booksData = GetLine("Input.txt", line).Split(' ').ToArray();

            book.Title = booksData[0];
            book.Autor = booksData[1];
            book.Publisher = booksData[2];
            book.ReleaseDate = DateTime.ParseExact(booksData[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            book.IsbnNumber = booksData[4];
            book.Price = double.Parse(booksData[5]);
            return book;
        }
    }
}
    

