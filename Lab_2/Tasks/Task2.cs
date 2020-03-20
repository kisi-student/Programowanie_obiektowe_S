using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace Tasks
{
    public static class Task2
    {
        public static void Return()
        {
            Person person2 = new Student("Michał", "Kot", new DateTime(1990, 4, 13), 2, 1, 12345);
            Student student = new Student("Krzysztof", "Jeż", new DateTime(1990, 12, 22), 2, 5, 54321);

            ((Student)person2).AddMark("PO", new DateTime(2011, 2, 20), 5.0);
            ((Student)person2).AddMark("Bazy danych", new DateTime(2011, 2, 13), 4.0);

            person2.PrintInfo();

            student.AddMark("Bazy danych", new DateTime(2011, 5, 1), 5.0);
            student.AddMark("AWW", new DateTime(2011, 5, 11), 5.0);
            student.AddMark("AWW", new DateTime(2011, 04, 02), 4.5);

            student.PrintInfo();

            student.RemoveMark("AWW", new DateTime(2011, 04, 02), 4.5);

            student.PrintInfo();

            student.AddMark("AWW", new DateTime(2011, 04, 02), 4.5);
            student.RemoveAllMarks("AWW");

            student.PrintInfo();

            student.AddMark("AWW",new DateTime(2011,04,02), 4.5);
            student.RemoveAllMarks();

            student.PrintInfo();

            Console.ReadKey();
        }
    }
}

