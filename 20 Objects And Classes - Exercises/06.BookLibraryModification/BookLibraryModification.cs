namespace _06.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibraryModification
    {
        public static void Main()
        {
            var library = new Library()
            {
                Name = "Prosveta",
                Books = new List<Book>()
            };

            int booksCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < booksCount; i++)
            {
                string[] tokens = Console.ReadLine().Split();

                string title = tokens[0];
                string author = tokens[1];
                string publisher = tokens[2];
                DateTime releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                string isbn = tokens[4];
                decimal price = decimal.Parse(tokens[5]);

                Book book = new Book(title, author, publisher, releaseDate, isbn, price);

                library.Books.Add(book);
            }
            DateTime givenDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            List<Book> afterGivenDate = library.Books
                                                    .Where(x => x.ReleaseDate > givenDate)
                                                    .OrderBy(x => x.ReleaseDate)
                                                    .ThenBy(x => x.Title)
                                                    .ToList();

            foreach (var book in afterGivenDate)
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
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
