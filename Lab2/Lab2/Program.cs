using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Student s1 = new Student("Paweł", "Filipiak", "1.21.37", 2, 1, 129665);
            s1.Details();
            Console.ReadKey();

            Player p1 = new Player("Damian", "Bulski", "12.12.12", "kopacz", "RKS HUWDU");
            p1.Details();
            Console.ReadKey();
            p1.Goal();
            p1.Details();
            Console.ReadKey();
        }
    }
}
