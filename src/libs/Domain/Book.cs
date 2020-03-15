using System;

namespace Domain
{
    public class Book
    {
        public Book(string title, string author, DateTime datePublished, string genre, double rating)
        {
            Title = title;
            Author = author;
            DatePublished = datePublished;
            Genre = genre;
            Rating = rating;
        }

        public string Title { get; set; }

        public string Author { get; set; }

        public DateTime DatePublished { get; set; }

        public string Genre { get; set; }

        public double Rating { get; set; }
    }
}
