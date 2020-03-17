using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("----------------ZAD1---------------");
            Position item1 = new Journal("CDACTION", 1, "WKO", new DateTime(2020, 2, 1), 21);
            Author author = new Author("Mariusz", "Czkawka", "BOLZGA");
            Position item2 = new Book("NIE DLA GRAFIKI", 2, "POMOC", new DateTime(2020, 03, 17), 1);
            ((Book)item2).AddAuthor(author);
            IList<Position> items = new List<Position>
            {
                item1,
                item2
            };

            Catalog catalog = new Catalog("Koniec zartow", items);
            Console.WriteLine(catalog);

            Position foundedByID = catalog.FindPositionById(21);
            Position foundedByTITLE = catalog.FindPositionByTitle("NIE DLA GRAFIKI");
            Console.WriteLine(foundedByID);
            Console.WriteLine(foundedByTITLE);
            catalog.WriteAllPositions();
            
            Console.WriteLine("----------------END---------------");
            
            Console.WriteLine("----------------ZAD 2-------------");
            Person librarian = new Librarian("Jakub", "Tynkowski", new DateTime(2020,03,18), 4000);
            Library library = new Library("Czestochowa, Armii Krajowej 36", new List<Librarian>(), new List<Catalog>());
            library.AddLibrarian((Librarian)librarian);
            library.WriteLibrarians();
            library.AddCatalog(catalog);
            Position newPosition = new Book("OGNIEM I MIECZEM", 4, "Publisher", new DateTime(2211, 11, 21), 100);
            library.AddPosition(newPosition, "Horrorryyyyyy");
            Console.WriteLine(library);
            library.WriteAllPositions();
           
            Console.WriteLine("--------------END----------------");
            Console.ReadKey();
        }

    }
}
