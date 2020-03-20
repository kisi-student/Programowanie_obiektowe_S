using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab3;
namespace Tasks
{
    class Task_1
    {
      public static void DoWork()
        {
            var catalog1 = new Catalog("Books");
            var catalog2 = new Catalog("Magazines");

            var author1 = new Author("Andrzej", "Sapkowski", "Poland");
            var author2 = new Author("Janusz", "Shwabinski", "Germany");


            var book1 = new Book(1, "Wiedzmin", "WydawnictwoJakies", new DateTime(2010, 5, 5), 300);
            var book2 = new Book(2, "Podroze male i duze", "WydawnictwoJakiesDwa", new DateTime(2007, 01, 20), 360);
            var magazine1 = new Magazine(1, "Swierszczyk", "Magazzyn", new DateTime(2020, 03, 03), 30);

            book1.PrintInfo();
            book2.PrintInfo();
            magazine1.PrintInfo();

            book1.AddAuthor(author1);
            book2.AddAuthor(author2);

            catalog1.AddEntry(book1);
            catalog1.AddEntry(book2);

            catalog2.AddEntry(magazine1);

            Console.ReadKey();
            Console.Clear();


        }
    }
}
