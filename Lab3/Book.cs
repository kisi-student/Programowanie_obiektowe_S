using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class Book:Position
	{
		private int pagesNumber;
		private IList<Author> authors = new List<Author>();

		public Book()
		{
		}

		public Book(string title, int id, string publisher, int publicationDate, int pagesNumber) : base(title, id, publisher, publicationDate)
		{
			this.pagesNumber = pagesNumber;
		}

		public void AddAuthor(Author a)
		{
			authors.Add(a);
		}

		public int PagesNumber { get => pagesNumber; set => pagesNumber = value; }

		public override void Details()
		{
			Console.WriteLine(this);
		}

		public override string ToString()
		{
			
			return base.ToString() + $", ilosc Stron: {pagesNumber}, autorzy: \r\n" + String.Join("\r\n", authors);
		}
	}
}
