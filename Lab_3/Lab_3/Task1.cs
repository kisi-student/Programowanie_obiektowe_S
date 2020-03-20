using System;

namespace Lab_3
{
    public class Task1
    {
        public static void Return()
        {
            Console.WriteLine("ZADANIE 1\n");

            var catalog1 = new Catalogue("Books");
            var catalog2 = new Catalogue("Magazines");

            var author1 = new Author("George", "Martin", "American");
            var author2 = new Author("Christopher", "Tolkien", "British");

            var book1 = new Book("Song of Ice and Fire",1, "Helion", new DateTime(2001, 3, 3), 600);
            var book2 = new Book("Silmanirion",2, "JPF", new DateTime(2006, 10, 16), 300);
            var magazine1 = new Magazine("Fantasy languages",1, "Twoja gazeta", new DateTime(2020, 1, 22), 25);

            book1.PrintInfo();
            book2.PrintInfo();
            magazine1.PrintInfo();

            book1.AddAuthor(author1);
            book2.AddAuthor(author2);

            catalog1.AddPosition(book1);
            catalog1.AddPosition(book2);

            catalog2.AddPosition(magazine1);

            Console.ReadKey();
            Console.Clear();
        }
    }
}