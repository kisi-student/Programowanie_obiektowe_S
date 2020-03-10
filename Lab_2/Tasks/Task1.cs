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
            Person o = new Person("Adam", "Mis", "20.03.1980");
            Person o2 = new Student("Michal", "Kot", "13.04.1990",2,1,12345);
            Person o3 = new Footballer("Mateusz", "Zbik", "10.08.1986","Center Back","FC Czestochowa");

            o.PrintInfo();
            o2.PrintInfo();
            o3.PrintInfo();

            Student s = new Student("Krzysztof", "Jez", "22.12.1990", 2, 5, 54321);
            Footballer p = new Footballer("Piotr", "Kos", "14.09.1984", "Striker", "FC Politechnika ");

            s.PrintInfo();
            p.PrintInfo();

            ((Footballer)o3).Shoot();
            p.Shoot();
            p.Shoot();

            o3.PrintInfo();
            p.PrintInfo();

            Console.ReadKey();
        }
    }
}
