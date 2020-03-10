using System;

using Lab2;

namespace Tasks
{
    public class Task1
    {
        public static void DoWork()
        {
            Console.WriteLine("ZADANIE 1\n");

            Person person1 = new Person("Adam", "Miś", "20.03.1980");
            Person person2 = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345);
            Person person3 = new Footballer("Mateusz", "Żbik", "10.08.1986", "obrońca", "FC Częstochowa");

            person1.PrintInfo();
            person2.PrintInfo();
            person3.PrintInfo();

            var student = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);
            var footballer = new Footballer("Piotr", "Kos", "14.09.1984", "napastnik", "FC Politechnika");

            student.PrintInfo();
            footballer.PrintInfo();

            ((Footballer)person3).Score();
            footballer.Score();
            footballer.Score();

            person3.PrintInfo();
            footballer.PrintInfo();

            Console.ReadKey();
            Console.Clear();
        }
    }
}
