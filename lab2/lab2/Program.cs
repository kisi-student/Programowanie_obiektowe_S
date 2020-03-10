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
        }
    }
}
