using System;

using Lab2;

namespace Tasks
{
    public class Task1
    {
        public static void DoWork()
        {
            Console.WriteLine("ZADANIE 1\n");

            Person person1 = new Person("Adam", "Miś", new DateTime(1980,3,20));
            Person person2 = new Student("Michał", "Kot", new DateTime(1990, 4, 13), 2, 1, 12345);
            Person person3 = new Footballer("Mateusz", "Żbik", new DateTime(1986, 8, 10), "obrońca", "FC Częstochowa");

            person1.PrintInfo();
            person2.PrintInfo();
            person3.PrintInfo();

            var student = new Student("Krzysztof", "Jeż", new DateTime(1990, 12, 22), 2, 5, 54321);
            var footballer = new Footballer("Piotr", "Kos", new DateTime(1984, 9, 14), "napastnik", "FC Politechnika");

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
