﻿namespace _06.Book_Library_Modification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

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
            int n = int.Parse(Console.ReadLine());
            Library booksByAutor = new Library();
            List<Book> books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                books.Add(ReadBook());
            }
            booksByAutor.Books = books;
            Dictionary<string, DateTime> booksAfterDate = AddBooksAfterDate(booksByAutor);
            PrintResults(booksAfterDate);
        }
        static void PrintResults(Dictionary<string, DateTime> booksAfterDate)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            foreach (var title in booksAfterDate.Where(d => d.Value > date).OrderBy(a => a.Value).ThenBy(b => b.Key))
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyy}", title.Key, title.Value);
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
        static void PrintResults(Dictionary<string, double> pricePerAutor)
        {
            foreach (var autor in pricePerAutor.OrderByDescending(a => a.Value).ThenBy(b => b.Key))
            {
                Console.WriteLine("{0} -> {1:f2}", autor.Key, autor.Value);
            }
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
        private static Book ReadBook()
        {
            Book book = new Book();
            string[] booksData = Console.ReadLine().Split(' ').ToArray();

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