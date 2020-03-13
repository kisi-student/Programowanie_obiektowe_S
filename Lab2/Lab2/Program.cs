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
            s1.AddGrade("English", "10-04-2016", 4.5);
            s1.AddGrade("Polish", "10-04-2016", 4.5);
            s1.GradesDetails("English");
            s1.GradesDetails("Polish");
            Console.ReadKey();
            s1.DeleteGrade("English", "10-04-2016", 4.5);
            s1.GradesDetails("English");
            s1.GradesDetails("Polish");
            Console.ReadKey();
            s1.DeleteAllGrades();
            s1.GradesDetails("English");
            s1.GradesDetails("Polish");
            Console.ReadKey();

            Player p1 = new Player("Damian", "Bulski", "12.12.12", "kopacz", "RKS HUWDU");
            p1.Details();
            Console.ReadKey();
            p1.Goal();
            p1.Details();
            Console.ReadKey();

            FootballPlayer f1 = new FootballPlayer("Żabson", "Ziomal", "11.11.11", "biegacz", "Polonia NAPLETON");
            f1.Details();
            Console.ReadKey();
            f1.Goal();
            f1.Details();
            Console.ReadKey();

            HandballPlayer h1 = new HandballPlayer("Mati", "Kuc", "01.02.03", "rzucacz", "REMIS Jaworzno");
            h1.Details();
            Console.ReadKey();
            h1.Goal();
            h1.Details();
            Console.ReadKey();
        }
    }
}
