using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Tasks
{
    public class Task2
    {
        public static void DoWork()
        {
            Console.WriteLine("ZADANIE 2 + PRACA DOMOWA\n");

            var library = new Library("Mostowa 4");

            library.AddLibrarian(new Librarian("Stefek", "Koron", new DateTime(1980, 3, 15), 1500));

            var catalog1 = new Catalog("Books");
            var catalog2 = new Catalog("Magazines");

            var book1 = new Book(1, "Song of Ice and Fire", "Helion", new DateTime(2001, 3, 3), 600);
            var book2 = new Book(2, "Silmanirion", "JPF", new DateTime(2006, 10, 16), 300);
            var magazine1 = new Magazine(1, "Fantasy languages", "Twoja gazeta", new DateTime(2020, 1, 22), 25);

            book1.AddAuthor(new Author("George", "Martin", "American"));
            book2.AddAuthor(new Author("Christopher", "Tolkien", "British"));

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
