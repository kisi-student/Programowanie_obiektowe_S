using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person o = new Person("Adam", "Miś", "20.03.1980");
            Person o2 = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345);
            Person o3 = new Player("Mateusz", "Żbik", "10.08.1986", "obrońca", "FC Częstochowa");

            o.WriteInfo();
            o2.WriteInfo();
            o3.WriteInfo();

            Student s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
            Player p = new Player("Piotr", "kos", "14.09.1984", "napastnik", "FC Politechnika");

            s.WriteInfo();
            p.WriteInfo();

            ((Player)o3).ScoreAGoal();
            p.ScoreAGoal();
            p.ScoreAGoal();

            o3.WriteInfo();
            p.WriteInfo();

            ((Student)o2).AddGrade("PO", "2011, 02, 20", 5.0);
            ((Student)o2).AddGrade("Bazy Danych", "2011, 02, 13", 4.0);

            o2.WriteInfo();

            s.AddGrade("Bazy danych", "2011, 05, 11", 5.0);
            s.AddGrade("AWWW", "2011, 05, 11", 5.0);
            s.AddGrade("AWWW","2011, 04, 02", 4.5);

            s.WriteInfo();

            s.RemoveGrade("AWWW", "2011, 04, 02", 4.5);

            s.WriteInfo();

            s.RemoveGrades("AWWW");

            s.WriteInfo();

            s.RemoveGrades();
            s.WriteInfo();


            Console.WriteLine("chyba dziala");
            Console.ReadKey();

        }
    }
}
