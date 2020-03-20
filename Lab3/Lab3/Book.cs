using System;
using System.Collections.Generic;

namespace Lab3
{
    public class Book : Entry
    {
        public int PageCount { get; set; }
        private List<Author> _authors = new List<Author>();

        public Book()
        {
            PageCount = 0;
        }

        public Book(uint id, string title, string publisher, DateTime publicationDate, int pageCount)
            : base(id, title, publisher, publicationDate)
        {
            PageCount = pageCount;
        }

        public void AddAuthor(Author author)
        {
            if (author == null)
            {
                throw new Exception("Attempt to add a null reference to Authors list.");
            }
            _authors.Add(author);
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Book title: {_title} Publisher: {_publisher}\nPublication date: {_publicationDate.ToShortDateString()}" +
                $" Pages: {PageCount}");
        }
    }
}
