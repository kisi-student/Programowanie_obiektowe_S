using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Lab3
{
    public class Library : IItemManagement
    {
        public string Address { get; set; }
        public IList<Librarian> Librarians { get; set; }
        public IList<Catalog> Catalogs { get; set; }
        public Library(string address, IList<Librarian> librarians, IList<Catalog> catalogs)
        {
            Address = address;
            Catalogs = catalogs;
            Librarians = librarians;
        }

        public void AddLibrarian(Librarian librarian)
        {
            if (librarian != null)
                Librarians.Add(librarian);
        }

        public void ShowAllLibrarians()
        {
            string str = "Librarians: \r\n";
            foreach (var librarian in Librarians)
            {
                str += librarian + "\r\n";
            }
            Console.WriteLine(str);
        }

        public void AddCatalog(Catalog catalog)
        {
            if (catalog != null)
                Catalogs.Add(catalog);
        }

        public void AddItem(Item item, string thematicDepartment)
        {
            if (string.IsNullOrWhiteSpace(thematicDepartment) || item == null) return;
            var catalog = Catalogs.FirstOrDefault(x => x.ThematicDepartment == thematicDepartment);
            catalog?.AddItem(item);
        }

        public void ShowAllItems()
        {
            foreach (var catalog in Catalogs)
            {
                Console.WriteLine(catalog);
            }
        }

        public Item FindItemBy(int id)
        {
            foreach (var catalog in Catalogs)
            {
                foreach (var item in catalog.Items)
                {
                    if (item.Id == id)
                        return item;
                }
            }
            throw new Exception("Item of given id is not found");
        }

        public Item FindItemBy(string title)
        {
            foreach (var catalog in Catalogs)
            {
                foreach (var item in catalog.Items)
                {
                    if (String.Compare(item.Title, title, StringComparison.Ordinal) == 0)
                        return item;
                }
            }
            throw new Exception("Item of given title is not found");
        }

        public Item FindItem(Expression<Func<Item, bool>> predicate)
        {
            var item = Catalogs.SelectMany(x => x.Items).FirstOrDefault(predicate.Compile());
            if (item != null)
                return item;
            throw new Exception("Item is not found");
        }
        public override string ToString()
        {
            var str = $"LIBRARY \r\n Address: {Address}\r\n Librarians: \r\n";
            foreach (var librarian in Librarians)
                str += librarian;
            str += " Catalogs: \r\n ";
            foreach (var catalog in Catalogs)
                str += catalog;
            return str;
        }
    }
}
