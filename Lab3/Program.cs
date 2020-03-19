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
			Console.WriteLine("Zad 1");
			Book bk = new Book("Das Kapital. Kritik der politischen Ökonomie",1, "Meissner", 1867, 3242);
			Author karl = new Author("Karl", "Marx", "Deutsch");
			bk.AddAuthor(karl);
			bk.Details();

			Position mg = new Magazine("Die Lage der arbeitenden Klasse in England", 2, "DP", 1845);

			Catalog cat = new Catalog("Komedie");
			cat.AddPosition(bk);
			cat.AddPosition(mg);
			Console.WriteLine("Test 1:");
			cat.Details();
			cat.RemovePosition(mg);
			Console.WriteLine("Test 2:");
			cat.PositionsDetails();
			Console.WriteLine();
			Console.WriteLine("Zad 2");
			//zad 2 i praca domowa

			IPositionsManagement cat2 = new Catalog("Dramaty");
			Magazine mg2 = new Magazine("Ludzkie Dzialanie", 3, "PWN", 1949);
			Librarian librarian1 = new Librarian("Ludwig", "von Mises", "1940", 2000);
			Librarian librarian2 = new Librarian("Friedrich August", "von Hayek", "1974", 2000);
			ILibrariansManagement library = new Library("Friedmanstrasse 5");
			library.AddLibrarian(librarian1);
			library.AddLibrarian(librarian2);
			Console.WriteLine("Test 3:");
			library.LibrariansDetails();
			
			((Library)library).AddCatalog((Catalog)cat2);
			((Library)library).AddCatalog(cat);
			Console.WriteLine("Test 4:");
			((Library)library).PositionsDetails();
			Console.WriteLine("tu");
			((Library)library).AddPosition(mg, ((Catalog)cat2).TopicSection);
			((Catalog)cat2).AddPosition(mg2);
			Console.WriteLine("Test 5:");
			((Library)library).PositionsDetails();
			Console.WriteLine("Test 6:");
			Console.WriteLine(((Library)library).FindPositionByTitle("Ludzkie Dzialanie"));
			Console.WriteLine(((Library)library).FindPositionByPublisher("DP"));
			Console.WriteLine(cat.FindPositionById(1));
			Console.WriteLine("Test 7:");
			((Library)library).FireLibrarians();
			((Library)library).RemovePosition(mg2);
			((Library)library).LibrariansDetails();//nic
			((Library)library).PositionsDetails();


			Console.ReadKey();

		}
	}
}
