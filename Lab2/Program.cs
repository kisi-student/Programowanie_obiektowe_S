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
            Person p = new Person("Adam", "Mis", "27.03.1980");
            Person p2 = new Student("Michal", "Kot", "13.04.1990", 2,1,12345);
            Person p3 = new Player("Mateusz", "Zbik", "10.08.1986", "obronca","FC CZestochowa");

            p.Details();
            p2.Details();
            p3.Details();


            Student s = new Student("Krzysztof", "Jez", "22.12.1990", 2,5,54321);
            Player pl = new Player("Piotr", "Kos", "14.09.1984", "napastniik", "FC Plobuda");

            s.Details();
            pl.Details();

            ((Player)p3).ShootGoal();
            pl.ShootGoal();
            pl.ShootGoal();

            p3.Details();
            pl.Details();
            
            Console.WriteLine();
            //ZAD 2
            ((Student)p2).AddGrade("PO", "20.02.2011", 5.0);
            ((Student)p2).AddGrade("Bazy Danych", "13.02.2011", 4.0);

            p2.Details();

            s.AddGrade("Bazy danych", "01.05.2011", 5.0);
            s.AddGrade("AWW", "11.05.2011", 5.0);
            s.AddGrade("AWW", "02.04.2011", 4.5);

            s.Details();

            s.RemoveGrade("AWW", "02.04.2011", 4.5);

            s.Details();
            s.AddGrade("AWW", "02.04.2011", 4.5);
            s.RemoveGrades("AWW");
            s.Details();

            s.AddGrade("AWW", "02.04.2011", 4.5);
            s.RemoveAllGrades();
            s.Details();

            Console.WriteLine();
            //zad dom
            Player hand = new Handballer("Jacek", "Kuku", "14.09.1984", "szatniarz", "FC Plobuda");
            Person foot = new Footballer("Adam", "Gadam", "10.08.1986", "obronca", "FC CZestochowa");
            hand.Details();
            foot.Details();

            ((Handballer)hand).ShootGoal();
            ((Footballer)foot).ShootGoal();
            

            Console.ReadKey();
        }
    }
}
