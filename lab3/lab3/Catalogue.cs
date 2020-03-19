using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Catalogue: IPositionManagament
    {
        public string Section { get; set; }
        public List<Position> Positions = new List<Position>(); 

        public Catalogue()
        {
            Section = null;
        }
        public Catalogue(string section)
        {
            Section = section;
        }

        public void AddPosition(Position position)
        {
            Positions.Add(position);
        }
        public Position FindPositionById(int id)
        {
            foreach (Position element in Positions)
            {
                if (element.Id == id)
                    return element;
            }
            return null;
        }
        public Position FindPositionByTitle(string title)
        {
            foreach (Position element in Positions)
            {
                if (element.Title == title)
                    return element;
            }
            return null;
        }
        public Position FindPositionByPublisher(string publisher)
        {
            foreach (Position element in Positions)
            {
                if (element.Publisher == publisher)
                    return element;
            }
            return null;
        }
        public Position FindPositionByPublishYear(int publishYear)
        {
            foreach (Position element in Positions)
            {
                if (element.PublishYear == publishYear)
                    return element;
            }
            return null;
        }

        public void InfoAll()
        {
            Console.WriteLine($"Katalog: {Section}, Pozycje:");
            foreach (Position element in Positions)
            {
                element.Info();
            }
        }
    }
}
