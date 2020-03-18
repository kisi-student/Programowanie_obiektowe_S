using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Book : Item
    {
        private int numberOfPages;
        private List<Author> author = new List<Author>();

        public int NumberOfPages { get => numberOfPages; set => numberOfPages = value; }

        public Book(): 
            base()
        {
            numberOfPages = 0;
        }

        public Book(string title_, int id_, string publishingHouse_, int releaseYear_, int numberOfPages_):
            base(title_, id_, publishingHouse_, releaseYear_)
        {
            numberOfPages = numberOfPages_;
        }

        public override string ToString()
        {
            return base.ToString() + $"\r\nBook Details | Number of Pages: {numberOfPages}";
        }

        public void AddAuthor(string name_, string surname_)
        {
            author.Add(new Author(name_, surname_));
        }

        public override void Details()
        {
            Console.WriteLine(this);
            foreach (Author a in author)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("-----------");
            //throw new NotImplementedException();
        }
    }
}
