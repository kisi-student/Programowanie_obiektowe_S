using System;

namespace Lab3.Tasks
{
    public class Task1
    {
        public static void DoWork()
        {
            Console.WriteLine("ZADANIE 1\n");

            var catalog1 = new Catalog("Books");
            var catalog2 = new Catalog("Magazines");

            var author1 = new Author("George", "Martin", "American");
            var author2 = new Author("Christopher", "Tolkien", "British");

            var book1 = new Book(1, "Song of Ice and Fire", "Helion", new DateTime(2001, 3, 3), 600);
            var book2 = new Book(2, "Silmanirion", "JPF", new DateTime(2006, 10, 16), 300);
            var magazine1 = new Magazine(1, "Fantasy languages", "Twoja gazeta", new DateTime(2020, 1, 22), 25);

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
