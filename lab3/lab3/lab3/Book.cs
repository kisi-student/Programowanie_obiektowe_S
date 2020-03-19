using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Book : Position
    {
        public int Pages { get; set; }
        private List<Author> author = new List<Author>();
        
        public Book() : base()
        { }
        public Book(string _title, int _id, string _publishing, int _publicationDate, int _pages) : base(_title, _id, _publishing, _publicationDate)
        {
            Pages = _pages;
        }
        
        public override string ToString()
        {
            string str = base.ToString() + $"Page numbers: {Pages} \nAuthors: \n";
            foreach (var item in author)
            {
                str += item + "\n";
            }
            return str;
        }
        public override void WriteInfo()
        {
            Console.WriteLine(this);
        }
        public void AddAuthor(Author _author)
        {
            author.Add(_author);
        }
       
    }
}
