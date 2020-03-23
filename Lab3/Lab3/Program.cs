using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Item i1 = new Book();

            Book b1 = new Book("Stary Człowiek i morze", 1, "Nowa Era", 1995, 78);
            Book b2 = new Book("Produkcja miętówek wg Schubbermanna", 2, "Wtorek Świata", 2002, 114);
            
            Magazine m1 = new Magazine("Piłkarz Siedlecki", 14, "Gmina Siedlce", 2019, 5);
            Magazine m2 = new Magazine();

            Catalog c1 = new Catalog("Lektury");
            Catalog c2 = new Catalog("Beleterystyka");

            Librarian l1 = new Librarian("Mariusz", "Jebaka", "13.02.15", 2100.00);
            Librarian l2 = new Librarian("Krzystof", "Bebok", "13.12.02", 2150.00);
            Library lib1 = new Library("ul. Mikołowska 13");

            b1.AddAuthor("Ernest", "Hemingway", "Polak");
            c1.AddItem(b1);
            c1.AddItem(m1);
            c1.AddItem(b2);

            c2.AddItem(i1);
            c2.AddItem(m2);
            c2.AddItem(b2);

            //c1.Details();
            //c1.FindItemByNumber(2019);
            //c1.FindItemByPhrase("Gmina Siedlce");

            lib1.AddLibrarian(l1);
            lib1.AddLibrarian(l2);

            //lib1.ShowLibrarians();
            
            lib1.AddCatalog(c1);
            lib1.AddCatalog(c2);
            lib1.AddItem(i1, "Lektury");

            lib1.ShowAll();
            lib1.ShowAllLibrarians();

            lib1.FindItemByNumber(2019);
            lib1.FindItemByPhrase("Stary Człowiek i morze");
            lib1.FindLibrarian("Bebok");

            //lib1.Details();

            Console.ReadKey();
        }
    }
}
