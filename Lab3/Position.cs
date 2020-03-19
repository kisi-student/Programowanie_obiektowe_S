using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	abstract class Position
	{
		protected string title;
		protected int id;
		protected string publisher;
		protected int publicationDate;

		public string Title { get => title; set => title = value; }
		public int Id { get => id; set => id = value; }
		public string Publisher { get => publisher; set => publisher = value; }
		public int PublicationDate { get => publicationDate; set => publicationDate = value; }

		protected Position()
		{
		}

		protected Position(string title, int id, string publisher, int publicationDate)
		{
			this.title = title;
			this.id = id;
			this.publisher = publisher;
			this.publicationDate = publicationDate;
		}

		public abstract void Details();

		public override string ToString()
		{
			return $"Id: {id}, tytul:{title}, wydawnictwo:{publisher}, data publikacji:{publicationDate}";
		}

		public override bool Equals(object obj)
		{
			return obj.ToString().Equals(this.ToString());
		}
	}
}
