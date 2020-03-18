using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Book : Position
    {
        public int Pages { get; set; }
        public Book()
        { }
        public Book(string _title, int _id, string _publishing, int _publicationDate, int _pages) : base(_title, _id, _publishing, _publicationDate)
        {
            Pages = _pages;
        }
        public void AddAuthor(Author author)
        {

        }
        public override void WriteInfo()
        {
            Console.WriteLine("Tittle:  {0}\nId: {1}\nPublishing: {2}\nPublication Date: {3}\nPages: {4}", Title, Id, Publishing, PublicationDate, Pages);
        }
    }
}
