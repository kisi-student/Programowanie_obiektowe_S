using System;
using System.Collections.Generic;
using Lab3.Interfaces;

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
            if(string.IsNullOrWhiteSpace(address))
            {
                throw new Exception("Could not instantiate Library object. Ivalid contruction params.");
            }
            Address = address;
        }

        public void AddCatalog(Catalog catalog)
        {
            if(catalog == null)
            {
                throw new ArgumentNullException(nameof(catalog));
            }
            _catalogs.Add(catalog);
        }

        public void AddLibrarian(Librarian librarian)
        {
            if(librarian == null)
            {
                throw new ArgumentNullException(nameof(librarian));
            }
            _librarians.Add(librarian);
        }

        public void PrintAllLibrarians()
        {
            Console.WriteLine($"Librarians employed at {Address}");
            foreach (var librarian in _librarians)
            {
                librarian.PrintInfo();
            }
        }

        public void AddEntry(Entry entry, string sectionTheme)
        {
            _catalogs.Find(catalog => catalog.SectionTheme == sectionTheme).AddEntry(entry);
        }
        
        public Entry FindEntryById(uint id)
        {
            foreach (var catalog in _catalogs)
            {
                Entry foundEntry = catalog.FindEntryById(id);
                if (foundEntry != null)
                {
                    return foundEntry;
                }
            }
            return null;
        }

        public Entry FindEntryByTitle(string title)
        {
            foreach (var catalog in _catalogs)
            {
                Entry foundEntry = catalog.FindEntryByTitle(title);
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
                Console.WriteLine($"Catalog: {catalog.SectionTheme}");
                catalog.PrintAllEntries();
                Console.WriteLine();
            }
        }
    }
}
