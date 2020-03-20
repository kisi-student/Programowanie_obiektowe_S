using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Book(uint id,string title,  string publishingHouse, DateTime year, int pageCount)
            : base(id, title, publishingHouse, year)
        {
            PageCount = pageCount;
        }

        public void AddAuthor(Author author)
        {
            _authors.Add(author);
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Book Title: {_title}, Publisher: {_publishingHouse}, Publication date: {_year}, Pages: {PageCount}\n");
        }
    }
}
