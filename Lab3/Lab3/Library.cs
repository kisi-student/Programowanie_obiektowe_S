using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Library : IEntryManagement, ILibrarianManagement
    {
        public string Address { get; set; }
        private List<Librarian> _librarians = new List<Librarian>();
        private List<Catalog> _catalogs = new List<Catalog>();

        public Library()
        {
            Address = "none";
        }

        public Library(string address)
        {
            Address = address;
        }

        public void AddLibrarian(Librarian librarian)
        {
            _librarians.Add(librarian);
        }

        public void AddCatalog(Catalog catalog)
        {
            _catalogs.Add(catalog);
        }

        public void PrintAllLibrarians()
        {
            foreach (var librarian in _librarians)
            {
                librarian.PrintInfo();
            }
        }

        public void AddEntry(Entry entry, string theme)
        {
            _catalogs.Find(catalog => catalog.Theme == theme).AddEntry(entry); //dla kazdego katalogu w kataloach sprawdzi jego temat jest rowny tego co przyszło,
                                                                               //jesli jest to go doda
        }

        public Entry FindById(int id)
        {
            foreach (var catalog in _catalogs)
            {
                var foundEntry = catalog.FindById(id);
                if (foundEntry != null)
                {
                    return foundEntry;
                }
            }
            return null;
        }

        public Entry FindByTitle(string title)
        {
            foreach (var catalog in _catalogs)
            {
                var foundEntry = catalog.FindByTitle(title);
                if (foundEntry != null)
                {
                    return foundEntry;
                }
            }
            return null;
        }

        public void PrintAllEntries()
        {
            foreach (var catalog in _catalogs)
            {
                catalog.PrintAllEntries();
            }
        }
    }
}
