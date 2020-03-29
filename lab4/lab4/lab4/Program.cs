using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new MyList<Person>
            {
                new Person("Jan", "kowalski",12),
                new Person("Ala", "Nowak", 32),
                new Person("Maja", "Marchewka", 14),
                new Person("Jakub", "kowalski",27)
            };
            Console.WriteLine("\nAdults:");
            
            foreach (var e in list)
            {
                if (e.Age >= 18)
                    Console.WriteLine($"\t{e}");
            }
            list.RemoveAt(1);
            Console.WriteLine("\nAdults after remove one person:");
            
            foreach (var e in list)
            {
                if(e.Age >= 18)
                Console.WriteLine($"\t{e}");
            }
            list.Insert(1, new Person("Daria", "Wisniewska", 22));

            Console.WriteLine("\nAdults after add one person:");

            foreach (var e in list)
            {
                if (e.Age >= 18)
                    Console.WriteLine($"\t{e}");
            }

            
            Console.ReadKey();
        }

    }
}
