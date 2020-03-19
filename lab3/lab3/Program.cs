using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ZADANIE 1
            /*
            Book b = new Book();
            b.Info();
            Position magazine = new Magazine("GLAMOUR", 1, "Burda International Polska", 2020, 21);
            Author author = new Author("Andrzej", "Sapkowski");
            Position book = new Book("Pani Jeziora", 2, "superNOWA", 1999, 596);
            magazine.Info();
            Console.WriteLine("\n");
            book.Info();
            Console.WriteLine("\n");

            ((Book)book).AddAuthor(author);
            book.Info();
            Console.WriteLine("\n");
            Catalogue catalog = new Catalogue("Koniec zartow");
            catalog.AddPosition(magazine);
            catalog.AddPosition(book);

            Position foundById = catalog.FindPositionById(1);
            Position foundByTitle = catalog.FindPositionByTitle("Pani Jeziora");
            Position foundByPublishing = catalog.FindPositionByPublisher("superNOWA");
            Position foundByPublicationDate = catalog.FindPositionByPublishYear(2020);
            Console.WriteLine("\nSearch:\n");
            Console.WriteLine("By Id: \n" + foundById + "\n");
            Console.WriteLine("By title:\n" + foundByTitle + "\n");
            Console.WriteLine("By publishing:\n" + foundByPublishing + "\n");
            Console.WriteLine("By publication date:\n" + foundByPublicationDate + "\n");
            catalog.InfoAll();
            Console.ReadKey();
            */
            //ZADANIE 2

            Library l1 = new Library();
            Library l2 = new Library("ul. Armii Krajowej 51");
            Person librarian = new Librarian("Maciej", "Bibliotekarz", "10.03.2020", 2500);
            Person a1 = new Author("Andrzej", "Sapkowski", "Polska");
            Position b1 = new Book("Pani Jeziora", 2, "superNOWA", 1999, 596);
            Position m1 = new Magazine("GLAMOUR", 1, "Burda International Polska", 2020, 21);
            Catalogue c1 = new Catalogue("Fantastyka");
            Catalogue c2 = new Catalogue("Czasopisma");
            l2.AddLibrarian(((Librarian)librarian));
            l2.AddCatalogue(c1);
            l2.AddCatalogue(c2);
            ((Book)b1).AddAuthor((Author)a1);
            l2.AddPosition(b1, "Fantastyka");
            l2.AddPosition(m1, "Czasopisma");

            Console.WriteLine("Libraries Information: \n\t");
            l1.InfoAll();
            Console.WriteLine("Librarian info: \n\t");
            l1.LibrariansInfo();
            l2.InfoAll();
            l2.LibrariansInfo();

            Console.WriteLine("-------===========-------\nSearch in l2:\n");
            Console.WriteLine("By Id: \n" + l2.FindPositionById(1) + "\n");
            Console.WriteLine("By title:\n" + l2.FindPositionByTitle("Pani Jeziora") + "\n");
            Console.WriteLine("By publishing:\n" + l2.FindPositionByPublisher("Burda International Polska") + "\n");
            Console.WriteLine("By publication date:\n" + l2.FindPositionByPublishYear(1999) + "\n");


            Console.ReadKey();

        }
    }
}
