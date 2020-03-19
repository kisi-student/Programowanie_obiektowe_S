using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using lab2;


namespace Tasks
{
    public class Task_1
    {
        public static void DoWork()
        {
            Person o = new Person("Adam", "Mis", new DateTime(1980,03,20));
            Person o2 = new Student("Michał", "Kot", new DateTime(1990, 4, 13), 2, 1, 12345);
            Person o3 = new Player("Mateusz", "Zbik", new DateTime(1986, 8, 10), "obronca", "FC Czestochowa");

            o.PrintInfo();
            o2.PrintInfo();
            o3.PrintInfo();

            Student s = new Student("Krzysztof", "Jeż", new DateTime(1990, 12, 22), 2, 5, 54321);
            Player p = new Player("Piotr", "Kos", new DateTime(1984, 9, 14), "napastnik", "FC Politechnika");

            s.PrintInfo();
            p.PrintInfo();

            ((Player)o3).Score();
            p.Score();
            p.Score();

            o3.PrintInfo();
            p.PrintInfo();

            Console.ReadKey();
        }
    }
}
