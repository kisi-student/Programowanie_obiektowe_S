using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3;

namespace Tasks
{
    public class Task_2
    {
        public static void DoWork()
        {

            var library = new Library("Sienkiewicza 32");

            library.AddLibrarian(new Librarian("Jadwiga", "Ksiazkowska", new DateTime(2005, 7, 20), 500));

            var catalog1 = new Catalog("Books");
            var catalog2 = new Catalog("Magazines");

            var book1 = new Book(1, "Wiedzmin", "WydawnictwoJakies", new DateTime(2010, 5, 5), 300);
            var book2 = new Book(2, "Podroze male i duze", "WydawnictwoJakiesDwa", new DateTime(2007, 01, 20), 360);
            var magazine1 = new Magazine(1, "Swierszczyk", "Magazzyn", new DateTime(2020, 03, 03), 30);

            book1.AddAuthor(new Author("Andrzej", "Sapkowski", "Poland"));
            book2.AddAuthor(new Author("Janusz", "Shwabinski", "Germany"));

            catalog1.AddEntry(book1);
            catalog1.AddEntry(book2);
            catalog2.AddEntry(magazine1);

            library.AddCatalog(catalog1);
            library.AddCatalog(catalog2);

            library.PrintAllLibrarians();
            Console.WriteLine();
            library.PrintAllEntries();

            Console.ReadKey();
            Console.Clear();

        }
    }
}
