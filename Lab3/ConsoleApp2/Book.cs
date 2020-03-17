using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Book : Position
    {
        public IList<Author> Authors { get; set; }
        public int PagesNumber { get; set; }
        public Book() : base()
        {
            PagesNumber = 0;
        }

        public Book(string _title, int _id, string _publisher, DateTime _publicationDate,
            int _pagesNumber) : base(_title, _id, _publisher, _publicationDate)
        {
            PagesNumber = _pagesNumber;
            Authors = new List<Author>();
        }

        public void AddAuthor(Author _author)
        {
            Authors.Add(_author);
        }

        public override string ToString()
        {
            var str = base.ToString() + $"Page numbers: {PagesNumber} \nAuthors: \n";
            foreach (var item in Authors)
            {
                str += item + "\n";
            }
            return str;
        }

        public override void WriteInfo()
        {
            Console.WriteLine(this);
        }
    }
}
