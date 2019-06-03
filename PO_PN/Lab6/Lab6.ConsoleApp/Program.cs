using System;
using System.Collections.Generic;
using System.Linq;
using Lab5.BLL;

namespace Lab5.ConsoleApp
{
    public class Program
    {
        private static void Main()
        {

Console.WriteLine("Nowe zoo");
var zoo = new Zoo();
zoo.Add(new Person("Romek", "Atomek", new DateTime(2000, 12, 01)))
    .Add(new Cage("Ptaszarnia", 10))
    .Add(new Person("Wojtek", "Nowak", new DateTime(2002, 12, 01)))
    .Add(new Cage("Wybieg", 5))
    .PrintInfo();

Console.WriteLine("Nowe zwierzęta:");
zoo.Get<Cage>(c => c.Id == "Wybieg")
    .Add(new Bird("Gołąb", "Wiktor", "nasiona", "centrum miasta", 20))
    .Add(new Bird("Gołąb", "Jacek", "nasiona", "centrum miasta", 20))
    .PrintInfo();
            
Console.WriteLine("Klatki Romka:");
zoo.GetList<Cage>(c => c.Keeper != null && c.Keeper.FirstName == "Romek")
    .Print();


            Console.ReadKey();
        }

        static void III()
        {

        }
    }
}
