using System;
using System.Collections.Generic;

namespace Lab3
{
    class Program
    {
        static void Main()
        {
            Item item1 = new Journal("JAISCR", 1, "Springer", new DateTime(2000, 1, 1), 1);
            Author author = new Author("Robert", "Cook", "Polish");
            Item item2 = new Book("Agile C#", 2, "SPRINGER", new DateTime(2015, 1, 1), 500);
            ((Book)item2).AddAuthor(author);
            IList<Item> items = new List<Item>();
            items.Add(item1);
            items.Add(item2);
            Catalog catalog = new Catalog("IT C# development", items);
            Console.WriteLine(catalog);
            //--- find position
            string valueObtainedFromUser = "Agile C#";

            Item foundedItemById = catalog.FindItem(item => item.Id == 1);
            Item foundedItemByTitle = catalog.FindItem(item => item.Title == valueObtainedFromUser);
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine(foundedItemById);
            Console.WriteLine(foundedItemByTitle);
            Item foundedOldWayId = catalog.FindItemBy(1);
            Item foundedOldWayTitle = catalog.FindItemBy("Agile C#");
            Console.WriteLine("Found old way");
            Console.WriteLine(foundedOldWayId);
            Console.WriteLine(foundedOldWayTitle);
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            catalog.ShowAllItems();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("ZAD 2");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Person librarian = new Librarian("John", "Kowalsky", DateTime.Now.Date, 2000);
            Library library = new Library("Czestochowa, Armii Krajowej 36", new List<Librarian>(), new List<Catalog>());
            library.AddLibrarian((Librarian) librarian);
            library.ShowAllLibrarians();
            Catalog catalog2 = new Catalog("Novels", new List<Item>());
            library.AddCatalog(catalog2);
            library.AddCatalog(catalog);
            Item newItem = new Book("Song of Ice and FIre", 4, "Publisher", new DateTime(2011, 1, 1), 800);
            library.AddItem(newItem, "Novels");
            Console.WriteLine(library);
            Console.WriteLine("===========================ALL ITEMs=======================\r\n");
            library.ShowAllItems();
            Console.WriteLine("===========================FIND BY=======================\r\n");
            var findById = library.FindItemBy(4);
            var findByTitle = library.FindItemBy("Agile C#");
            var findByLambda = library.FindItem(x => x.Publisher == "Springer");
            Console.WriteLine(findById);
            Console.WriteLine(findByTitle);
            Console.WriteLine(findByLambda);
            Console.ReadKey();
        }
    }
}
