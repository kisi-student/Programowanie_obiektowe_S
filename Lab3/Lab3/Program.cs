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
            Book b1 = new Book("Stary Człowiek i morze", 1, "Nowa Era", 1995, 78);
            Book b2 = new Book("Produkcja miętówek wg Schubbermanna", 2, "Wtorek Świata", 2002, 114);
            Magazine m1 = new Magazine("Piłkarz Siedlecki", 14, "Gmina Siedlce", 2019, 5);
            Catalog c1 = new Catalog("Lektury");          
            b1.AddAuthor("Ernest", "Hemingway");
            c1.AddItem(b1);
            c1.AddItem(m1);
            c1.AddItem(b2);
            c1.Details();
            c1.FindItemByNumber(2019);
            c1.FindItemByPhrase("Gmina Siedlce");

            Console.ReadKey();
        }
    }
}
