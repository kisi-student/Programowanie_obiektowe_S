using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class Library : IPositionsManagement,ILibrariansManagement
	{
		private IList<Librarian> librarians = new List<Librarian>();
		private IList<Catalog> catalogs = new List<Catalog>();
		public string Adres { get; set; }

		public Library()
		{
		}

		public Library(string adres)
		{
			Adres = adres;
		}

		public void AddLibrarian(Librarian l)
		{
			librarians.Add(l);
		}

		public void FireLibrarians()
		{
			librarians.Clear();
		}

		public void AddPosition(Position p, string topicSection)
		{
			((List<Catalog>)catalogs).Find(x=>x.TopicSection == topicSection).AddPosition(p);
		}
		public void RemovePosition(Position p)
		{
			foreach (Catalog c in catalogs)
			{
				if (c.FindPositionById(p.Id) != null) c.RemovePosition(p);
			}

		}

		public void AddCatalog(Catalog c)
		{
			catalogs.Add(c);
		}
		public Position FindPositionById(int id)
		{
			Position p;
			foreach(Catalog c in catalogs)
			{
				p = c.FindPositionById(id);
				if (p != null) return p;
			}
				
			return null;
		}

		public Position FindPositionByPublicationDate(int publicationDate)
		{
			Position p;
			foreach (Catalog c in catalogs)
			{
				p = c.FindPositionByPublicationDate(publicationDate);
				if (p != null) return p;
			}

			return null;
		}

		public Position FindPositionByPublisher(string publisher)
		{
			Position p;
			foreach (Catalog c in catalogs)
			{
				p = c.FindPositionByPublisher(publisher);
				if (p != null) return p;
			}

			return null;
		}

		public Position FindPositionByTitle(string title)
		{
			Position p;
			foreach (Catalog c in catalogs)
			{
				p = c.FindPositionByTitle(title);
				if (p != null) return p;
			}

			return null;
		}

		public void LibrariansDetails()
		{
			Console.WriteLine(String.Join("\r\n", librarians));
		}

		public void PositionsDetails()
		{
			Console.WriteLine(String.Join("\r\n", catalogs));
		}
	}
}
