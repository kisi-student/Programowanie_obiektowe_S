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
            if (librarian != null)
                Librarians.Add(librarian);
        }
        public void WriteLibrarians()
        {
            string str = "Liblarians: \n";
            for (int i =0; i<Librarians.Count; i++)
            {
                str += Librarians + "\n";
            }
        }
        public void AddCatalog(Catalog catalog)
        {
            Catalogs.Add(catalog);
        }
        public void AddPosition(Position p, string thematicDepartment)
        {
            
        }
        public void FindPositionById()
        {

        }

    }
}
