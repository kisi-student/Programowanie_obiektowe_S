using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class Library : IPositionManagement, ILibrarianManagement
    {
        public string Address { get; set; }
        private List<Librarian> _librarians = new List<Librarian>();
        private List<Catalogue> _catalogs = new List<Catalogue>();
        public Library()
        {
            Address = "none";
        }

        public Library(string address)
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                throw new Exception("Could not add empty Library object");
            }
            Address = address;
        }

        public void AddLibrarian(Librarian librarian)
        {
            if(librarian == null)
            {
                throw new Exception("Could not add null object");
            }
            _librarians.Add(librarian);
        }

        public void AddPosition(Position position, string sectionTheme)
        {
            _catalogs.Find(catalog => catalog.SectionTheme == sectionTheme).AddPosition(position);
        }

        public void AddCatalog(Catalogue catalog)
        {
            if(catalog == null)
            {
                throw new ArgumentNullException(nameof(catalog));
            }
            _catalogs.Add(catalog);
        }

        public Position FindPositionByTitle(string title)
        {
            foreach (var catalog in _catalogs)
            {
                Position FindPosition = catalog.FindPositionByTitle(title);
                if (FindPosition != null)
                {
                    return FindPosition;
                }

            }
            return null;
        }

        public Position FindPositionById(uint id)
        {
            foreach (var catalog in _catalogs)
            {
                Position FindPosition = catalog.FindPositionById(id);
                if (FindPosition != null)
                {
                    return FindPosition;
                }
            }
            return null;
        }

        public void PrintAllPositions()
        {
            foreach(var catalog in _catalogs)
            {
                Console.WriteLine($"Catalog: {catalog.SectionTheme}");
                catalog.PrintAllPositions();
                Console.WriteLine();
            }
        }

        public void PrintAllLibrarians()
        {
            Console.WriteLine($"Librarian employed at {Address}");
            foreach (var librarian in _librarians)
            {
                librarian.PrintInfo();
            }
        }
    }
}
