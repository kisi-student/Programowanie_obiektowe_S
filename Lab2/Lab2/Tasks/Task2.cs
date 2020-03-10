using System;

using Lab2;

namespace Tasks
{
    public class Task2
    {
        public static void DoWork()
        {
            Console.WriteLine("ZADANIE 2\n");

            Person person = new Student("Michał", "Kot", "13.04.1990", 2, 1, 12345);
            var student = new Student("Krzysztof", "Jeż", "22.12.1990", 2, 5, 54321);


            ((Student)person).PushMark("PO", "20.02.2011", 5.0);
            ((Student)person).PushMark("Bazy danych", "13.02.2011", 4.0);

            person.PrintInfo();

            student.PushMark("Bazy danych", "01.05.2011", 5.0);
            student.PushMark("AWW", "11.05.2011", 5.0);
            student.PushMark("AWW", "02.04.2011", 4.5);

            student.PrintInfo();

            student.PopMark("AWW", "02.04.2011", 4.5);

            student.PrintInfo();

            student.PushMark("AWW", "02.04.2011", 4.5);
            student.PopMarks("AWW");

            student.PrintInfo();

            student.PushMark("AWW", "02.04.2011", 4.5);
            student.PopMarks();

            student.PrintInfo();

            Console.ReadKey();
            Console.Clear();
        }
    }
}
