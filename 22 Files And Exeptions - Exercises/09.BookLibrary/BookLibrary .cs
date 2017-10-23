namespace _09.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            Library library = new Library()
            {
                Name = "Prosveta",
                Books = new List<Book>()
            };

            string[] inputLine = File.ReadAllLines("../../Input.txt");
            File.Delete("../../Output.txt");

            int booksCount = int.Parse(inputLine[0]);

            for (int i = 0; i < booksCount; i++)
            {
                string[] tokens = inputLine[i + 1].Split();

                string title = tokens[0];
                string author = tokens[1];
                string publisher = tokens[2];
                DateTime releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = tokens[4];
                decimal price = decimal.Parse(tokens[5]);

                Book book = new Book(title, author, publisher, releaseDate, isbn, price);

                library.Books.Add(book);
            }

            string[] authors = library
                                    .Books
                                    .Select(a => a.Author)
                                    .Distinct()
                                    .ToArray();

            List<AuthorInfo> authorSales = new List<AuthorInfo>();

            foreach (var author in authors)
            {
                decimal sales = library.Books
                                       .Where(a => a.Author == author)
                                       .Sum(a => a.Price);

                AuthorInfo authorInfo = new AuthorInfo()
                {
                    Author = author,
                    Sales = sales
                };
                authorSales.Add(authorInfo);
            }

            authorSales = authorSales.OrderByDescending(a => a.Sales).ThenBy(a => a.Author).ToList();

            foreach (var authorInfo in authorSales)
            {
                string result = $"{authorInfo.Author} -> {authorInfo.Sales:F2}";
                File.AppendAllText("../../Output.txt", result + Environment.NewLine);
            }
        }
    }

    class AuthorInfo
    {
        public string Author { get; set; }

        public decimal Sales { get; set; }
    }

    class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Isbn = isbn;
            Price = price;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Isbn { get; set; }

        public decimal Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}
