using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace Tasks
{
    public class Task1
    {
        public static void Return()
        {
            Person o = new Person("Adam", "Mis", new DateTime (1980,03,20));
            Person o2 = new Student("Michal", "Kot",new DateTime(1990,04,13),2,1,12345);
            Person o3 = new Player("Mateusz", "Zbik",new DateTime(1986,08,10),"Center Back","FC Czestochowa");

            o.PrintInfo();
            o2.PrintInfo();
            o3.PrintInfo();

            Student s = new Student("Krzysztof", "Jez",new DateTime(1990,12,22), 2, 5, 54321);
            Player p = new Player("Piotr", "Kos",new DateTime(1984,09,14), "Striker", "FC Politechnika ");

            s.PrintInfo();
            p.PrintInfo();

            ((Player)o3).Shoot();
            p.Shoot();
            p.Shoot();

            o3.PrintInfo();
            p.PrintInfo();

            Console.ReadKey();
        }
    }
}
