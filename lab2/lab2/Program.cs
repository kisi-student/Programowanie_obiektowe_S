using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Adam", "Miś", "1990, 3, 20");
            Person person2 = new Student("Michał", "Kot", "1990, 4, 13", 3, 5, 12345);
            Person person3 = new HandBallPlayer("Mateusz", "Żbik", "1986, 8, 10", "striker", "FC Barcelona", 10);
            person1.Details();
            person2.Details();
            person3.Details();
            Student student = new Student("Krzysztof", "Jeż", "1990, 12, 29", 2, 5, 54321);
            Player footballer = new FootBallPlayer("Piotr", "Kos", "1984, 9, 14", "striker", "FC Politechnika");
            student.Details();
            footballer.Details();
            ((Player)person3).ScoreGoal();
            footballer.ScoreGoal();
            footballer.ScoreGoal();
            person3.Details();
            footballer.Details();
            Console.WriteLine("+=++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();


            ((Student)person2).AddGrade("PO", "20.02.2011", 5.0);
            ((Student)person2).AddGrade("PO", "20.02.2011", 5.0);

            person2.Details();

            student.AddGrade("BD", "12.32.33", 3.0);
            student.AddGrade("asd", "12.32.33", 5.0);
            student.AddGrade("asd", "62.32.33", 1.0);

            student.Details();

            student.AddGrade("asd", "12333,3", 6.0);
            student.DeleteGrade("asd");

            student.AddGrade("AWWW", "02.20.2111", 4.5);
            student.DeleteGrades();

            student.Details();

            Console.ReadKey();


        }
    }
}
