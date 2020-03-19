using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Book: Position
    {
        public int PageCount { get; set; }
        public List<Author> Authors = new List<Author>();

        public Book()
        {
            PageCount = 0;
        }
        public Book(string title, int id, string publisher, int publishYear, int pageCount)
        {
            Title = title;
            Id = id;
            Publisher = publisher;
            PublishYear = publishYear;
            PageCount = pageCount;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }


        public override string ToString()
        {
            return $"{base.ToString()}, Liczba stron: {PageCount}";
        }

        public override void Info()
        {
            Console.WriteLine(this);
            Console.WriteLine("Autorzy:");
            foreach(Author element in Authors)
            {
                Console.WriteLine($"{element.FirstName} {element.LastName}");
            }

        }
    }
}
