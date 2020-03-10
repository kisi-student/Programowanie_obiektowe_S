using System;

using Lab2;

namespace Tasks
{
    public class Task2
    {
        public static void DoWork()
        {
            Console.WriteLine("ZADANIE 2\n");

            Person person = new Student("Michał", "Kot", new DateTime(1990, 4, 13), 2, 1, 12345);
            var student = new Student("Krzysztof", "Jeż", new DateTime(1990, 12, 22), 2, 5, 54321);


            ((Student)person).PushMark("PO", new DateTime(2011, 2, 20), 5.0);
            ((Student)person).PushMark("Bazy danych", new DateTime(2011, 2, 13), 4.0);

            person.PrintInfo();

            student.PushMark("Bazy danych", new DateTime(2011, 5, 1), 5.0);
            student.PushMark("AWW", new DateTime(2011, 5, 11), 5.0);
            student.PushMark("AWW", new DateTime(2011, 4, 2), 4.5);

            student.PrintInfo();

            student.PopMark("AWW", new DateTime(2011, 4, 2), 4.5);

            student.PrintInfo();

            student.PushMark("AWW", new DateTime(2011, 4, 2), 4.5);
            student.PopMarks("AWW");

            student.PrintInfo();

            student.PushMark("AWW", new DateTime(2011, 4, 2), 4.5);
            student.PopMarks();

            student.PrintInfo();

            Console.ReadKey();
            Console.Clear();
        }
    }
}
