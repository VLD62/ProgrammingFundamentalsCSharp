namespace _10.Book_Library_Modification
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
            string date1 = File.ReadLines("Input.txt").Last();
            Library booksByAutor = new Library();
            List<Book> books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                books.Add(ReadBook(i + 2));
            }
            booksByAutor.Books = books;
            Dictionary<string, DateTime> booksAfterDate = AddBooksAfterDate(booksByAutor);
            PrintResults(booksAfterDate, date1);
        }
        static void PrintResults(Dictionary<string, DateTime> booksAfterDate, string date1)
        {
            DateTime date = DateTime.ParseExact(date1, "d.M.yyyy", CultureInfo.InvariantCulture);
            using (StreamWriter outputFile = new StreamWriter("Output.txt"))
            {
                foreach (var title in booksAfterDate.Where(d => d.Value > date).OrderBy(a => a.Value).ThenBy(b => b.Key))
                {
                    outputFile.WriteLine("{0} -> {1:dd.MM.yyy}", title.Key, title.Value);
                }
            }

        }

        public static Dictionary<string, DateTime> AddBooksAfterDate(Library booksByAutor)
        {
            Dictionary<string, DateTime> booksAfterDate = new Dictionary<string, DateTime>();
            foreach (Book book in booksByAutor.Books)
            {
                if (!booksAfterDate.ContainsKey(book.Title))
                {
                    booksAfterDate.Add(book.Title, new DateTime());
                }
                booksAfterDate[book.Title] = book.ReleaseDate;
            }
            return booksAfterDate;
        }

        public static Dictionary<string, double> AddValuesToDictionary(Library booksByAutor)
        {
            Dictionary<string, double> pricePerAutor = new Dictionary<string, double>();
            foreach (Book book in booksByAutor.Books)
            {
                if (!pricePerAutor.ContainsKey(book.Autor))
                {
                    pricePerAutor.Add(book.Autor, 0);
                }

                pricePerAutor[book.Autor] += book.Price;
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
