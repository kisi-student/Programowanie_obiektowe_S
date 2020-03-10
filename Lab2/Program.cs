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
            Person o = new Person("Adam", "Miś", "20.03.1980");
            Person o2 = new Student("Michał", "Kot", "13.04.1990r", 2, 1, 12345);
            Person o3 = new Footballer("Mateusz", "Żbik", "10.08.1986", "Obrońca", "Fc Czestochowa");



            o.WriteInfo();
            o2.WriteInfo();
            o3.WriteInfo();

            Student s = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
            Footballer p = new Footballer("Piotr", "Kos", "14.09.1984", "Napastnik", "Fc Politechnika");

            s.WriteInfo();
            p.WriteInfo();

            ((Footballer)o3).IncrementGoals();
            p.IncrementGoals();
            p.IncrementGoals();

            o3.WriteInfo();
            p.WriteInfo();

            Console.ReadKey();
        }
    }
}
