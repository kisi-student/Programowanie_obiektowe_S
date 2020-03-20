using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Book : Position
    {
        public int NumberOfPages { get; set; }
        private List<Author> _authors = new List<Author>();

        public Book()
        {
            NumberOfPages = 0;
            
        }

        

        public Book(string title,uint id,string publisher,DateTime publicationYear,int numberOfPages):
            base(title,id,publisher,publicationYear)
        {
            NumberOfPages = NumberOfPages;
        }

        public void AddAuthor(Author author) 
        {
            if (author == null)
            {
                throw new Exception("Could not add null elemnet to List");
            }
            _authors.Add(author);
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Id: {_id} Book title: {_title} Publisher: {_publisher} " +
                $"Publication Year: {_publicationYear.ToShortDateString()} Pages: {NumberOfPages}");
        }
       
    }
}
