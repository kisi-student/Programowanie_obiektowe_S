using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Task2
    {
        public static void Return()
        {
            Console.WriteLine("ZADANIE 2 + PRACA DOMOWA\n");

            var library = new Library("Mostowa 4");

            library.AddLibrarian(new Librarian("Stefek", "Koron", new DateTime(1980, 3, 15), 1500));

            var catalog1 = new Catalogue("Books");
            var catalog2 = new Catalogue("Magazines");

            var book1 = new Book("Song of Ice and Fire",1, "Helion", new DateTime(2001, 3, 3), 600);
            var book2 = new Book("Silmanirion",2, "JPF", new DateTime(2006, 10, 16), 300);
            var magazine1 = new Magazine("Fantasy languages",1, "Twoja gazeta", new DateTime(2020, 1, 22), 25);

            book1.AddAuthor(new Author("George", "Martin", "American"));
            book2.AddAuthor(new Author("Christopher", "Tolkien", "British"));

            catalog1.AddPosition(book1);
            catalog1.AddPosition(book2);
            catalog2.AddPosition(magazine1);

            library.AddCatalog(catalog1);
            library.AddCatalog(catalog2);

            library.PrintAllLibrarians();
            Console.WriteLine();
            library.PrintAllPositions();

            Console.ReadKey();
            Console.Clear();
        }
    }
}