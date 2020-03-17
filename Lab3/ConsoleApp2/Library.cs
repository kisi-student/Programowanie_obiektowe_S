using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Library : IPositionManagment, ILibrariansManagment
    {
        public string Address { get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs { get; set; }

        public Library()
        {
            Address = "Unknown";
        }

        public Library(string _address, IList<Librarian> _librarians, IList<Catalog> _catalogs)
        {
            Address = _address;
            Librarians = _librarians;
            Catalogs = _catalogs;
        }

        public void AddLibrarian(Librarian _librarian)
        {
            Librarians.Add(_librarian);
        }

        public void AddCatalog(Catalog _catalog)
        {
            Catalogs.Add(_catalog);
        }

        public void AddPosition(Position position, string _topicSection)
        {
            var catalog = new Catalog
            {
                TopicSection = _topicSection
            };
            if (catalog.Positions != null)
            {
                catalog.Positions.Add(position);
            }
            
        }

        public override string ToString()
        {
            var str = $"Library address:{Address}, librarians:\n";
            foreach (var item in Librarians)
            {
                str += item + "\n";
            }
            str += "Catalogs:\n";
            foreach (var item in Catalogs)
            {
                str += item + "\n";
            }
            return str;
        }

        public void WriteAllPositions()
        {
            foreach (var item in Catalogs)
            {
                Console.WriteLine(item);
            }
        }

        public Position FindPositionById(int _id)
        {
            foreach (var catalog in Catalogs)
            {
                foreach (var position in catalog.Positions)
                {
                    if (position.Id == _id)
                    {
                        return position;
                    }
                }
            }
            return null;
        }
        public Position FindPositionByTitle(string _title)
        {
            foreach (var catalog in Catalogs)
            {
                foreach (var position in catalog.Positions)
                {
                    if (position.Title == _title)
                    {
                        return position;
                    }
                }
            }
            return null;
        }

        public void WriteLibrarians()
        {
            var str = "Librarians:\n";
            foreach (var item in Librarians)
            {
                str += item + "\n";
            }
            Console.WriteLine(str);
        }

    }
}
