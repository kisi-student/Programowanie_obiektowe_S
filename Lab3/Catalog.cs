using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
	class Catalog: IPositionsManagement
	{
		private string topicSection = "brak";
		private IList<Position> positions = new List<Position>();

		public Catalog()
		{
		}

		public Catalog(string topicSection)
		{
			this.topicSection = topicSection;
		}

		public void AddPosition(Position p)
		{
			positions.Add(p);
		}

		public void RemovePosition(Position p)
		{
			positions.Remove(p);
		}

		public Position FindPositionById(int id)
		{
			return ((List<Position>)positions).Find(x => x.Id == id);
		}
		public Position FindPositionByTitle(string title)
		{
			return ((List<Position>)positions).Find(x => x.Title.Equals(title));
		}

		public Position FindPositionByPublisher(string publisher)
		{
			return ((List<Position>)positions).Find(x => x.Publisher.Equals( publisher));
		}

		public Position FindPositionByPublicationDate(int publicationDate)
		{
			return ((List<Position>)positions).Find(x => x.PublicationDate == publicationDate);
		}

		public void PositionsDetails()
		{
			Console.WriteLine(String.Join(",\r\n",positions));
		}

		public string TopicSection { get => topicSection; set => topicSection = value; }

		public void Details()
		{
			Console.WriteLine(this);
		}

		public override string ToString()
		{
			return $"Katalog sekcja:{topicSection}, pozycje: "+ String.Join(",\r\n", positions);
		}
	}
}
