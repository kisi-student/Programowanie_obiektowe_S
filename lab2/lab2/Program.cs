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
            //ZADANIE 1
            
            Person o = new Person("Adam", "Miś", "20.03.1980");
            Person o2 = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345);
            Person o3 = new Player("Mateusz", "Żbik", "10.08.1986", "obrońca", "FC Czestochowa");

            o.Info();
            o2.Info();
            o3.Info();

            Student s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
            Player p = new Player("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politechnika");

            s.Info();
            p.Info();

            ((Player)o3).ScoreGoal();
            p.ScoreGoal();
            p.ScoreGoal();

            o3.Info();
            p.Info();

            Console.ReadKey();


            //ZADANIE 2
            ((Student)o2).AddMark("PO", "20.02.2011", 5.0);
            ((Student)o2).AddMark("Bazy Danych", "13.02.2011", 4.0);

            o2.Info();

            s.AddMark("Bazy Danych", "01.05.2011", 5.0);
            s.AddMark("AWWW", "11.05.2011", 5.0);
            s.AddMark("AWWW", "02.04.2011", 4.5);

            s.Info();

            s.RemoveMark("AWWW", "02.04.2011", 4.5);

            s.Info();

            s.AddMark("AWWW", "02.04.2011", 4.5);
            s.RemoveAllMarks("AWWW");

            s.Info();

            s.AddMark("AWWW", "02.04.2011", 4.5);
            s.RemoveAllMarks();

            s.Info();

            Console.ReadKey();
            
        }
    }
}
