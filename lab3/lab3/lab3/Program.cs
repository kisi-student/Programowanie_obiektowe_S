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
          Position magazine = new Magazine("GLAMOUR", 1, "Burda International Polska", 2020, 21);
          Author author = new Author("Andrzej", "Sapkowski");
          Position book = new Book("Pani Jeziora", 2, "superNOWA", 1999, 596);
          magazine.WriteInfo();
          Console.WriteLine("\n");
          book.WriteInfo();
          Console.WriteLine("\n");

          ((Book)book).AddAuthor(author);
          IList<Position> items = new List<Position>
          {
              magazine,
              book
          };
            
          Catalog catalog = new Catalog("Koniec zartow", items);
            
        
          Position foundedById = catalog.FindPositionById(1);
          Position foundedByTitle = catalog.FindPositionByTitle("Pani Jeziora");
          Position foundedByPublishing = catalog.FindPositionByPublishing("superNOWA");
          Position foundedByPublicationDate = catalog.FindPositionByPublicationDate(2020);
          Console.WriteLine("\nSearch:\n");
          Console.WriteLine("By Id: \n"+foundedById+"\n");
          Console.WriteLine("By title:\n" +foundedByTitle+"\n");
          Console.WriteLine("By publishing\n"+foundedByPublishing+"\n");
          Console.WriteLine("By publication date\n"+foundedByPublicationDate + "\n");
          catalog.WriteAllPositions();
          Console.ReadKey();
        }
    }
}
