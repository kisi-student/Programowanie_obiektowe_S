using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Library : IPositionManagment
    {
        public string Address { get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs { get; set; }
        public Library()
        { }
        public Library(string _address, IList<Librarian> _librarians, IList<Catalog> _catalogs)
        {
            Address = _address;
            Librarians = _librarians;
            Catalogs = _catalogs;
        }
        public void AddLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
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
        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }
        public void AddPosition(Position p, string thematicDepartment)
        {
            var catalog = new Catalog
            {
                ThematicDepartment = thematicDepartment
            };
            if (catalog.position != null)
            {
                catalog.position.Add(p);
            }
        }
        public Position FindPositionById(int _id)
        {
            
            foreach (var catalog in Catalogs)
            {
                foreach (var Position in catalog.position)
                {
                    if (Position.Id == _id)
                    {
                        return Position;
                    }
                }
            }
            return null;
        }
        public Position FindPositionByTitle(string _title)
        {
            foreach (var catalog in Catalogs)
            {
                foreach (var Position in catalog.position)
                {
                    if (Position.Title == _title)
                    {
                        return Position;
                    }
                }
            }
            return null;
        }
        public override string ToString()
        {
            
            var str = $"Library address: {Address}\nLibrarians:\n";
            for(int i=0; i<Librarians.Count; i++)
            {

                Librarian l = Librarians[i];
                str +=  l + "\n";
            
            }
            var str1= "Catalogs:\n";
            Console.WriteLine(Catalogs[0]);
            for(int i=0; i<Catalogs.Count; i++)
            {
                Catalog c = Catalogs[i];
                str1 +=  c + "\n";
            }
            var str3 = str+str1 ;
            return str3;
        }

        public void WriteAllPositions()
        {
            for(int i=0; i<Catalogs.Count;i++)
            {
                Catalog c = Catalogs[i];
                Console.WriteLine(c);
            }
        }

    }
}
