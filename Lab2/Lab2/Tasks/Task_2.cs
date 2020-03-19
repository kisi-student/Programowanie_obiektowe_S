using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2;
namespace Tasks
{
   public class Task_2
    {
        public static void DoWork()
        {
            Person o2 = new Student("Michał", "Kot", new DateTime(1990, 4, 13), 2, 1, 12345);
            Student s = new Student("Krzysztof", "Jeż", new DateTime(1990, 12, 22), 2, 5, 54321);

            ((Student)o2).AddMark("PO", new DateTime(2011, 2, 20), 5.0);
            ((Student)o2).AddMark("Bazy", new DateTime(2011, 2, 13), 4.0);

            o2.PrintInfo();
            Console.WriteLine();
            s.AddMark("Bazy", new DateTime(2011, 5, 1), 5.0);
            s.AddMark("AWWW", new DateTime(2011, 5, 11), 5.0);
            s.AddMark("AWWW", new DateTime(2011, 4, 2), 4.5);

            s.PrintInfo();
            Console.WriteLine();
            s.RemoveMark("AWWW", new DateTime(2011, 4, 2), 4.5);

            s.PrintInfo();
            Console.WriteLine();

            s.AddMark("AWWW", new DateTime(2011, 4, 2), 4.5);
            s.RemoweMarks("AWWW");

            s.PrintInfo();
            Console.WriteLine();

            s.AddMark("AWWW", new DateTime(2011, 4, 2), 4.5);
            s.RemoweMarks();

            s.PrintInfo();

            Console.ReadKey();

        }
    }
}
