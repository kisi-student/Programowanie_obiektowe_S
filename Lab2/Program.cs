using System;


namespace Lab2
{
    class Program
    {
        static void Main()
        {
            Person o = new Person("Adam", "Miś", new DateTime(1980,03,20));
            Person o2 = new Student("Michał", "Kot", new DateTime(1990,04,13), 2, 1, 12345);
            Person o3 = new Footballer("Mateusz", "Żbik", new DateTime(1986,08,10), "Obrońca", "Fc Czestochowa");



         //   o.WriteInfo();
         //   o2.WriteInfo();
         //   o3.WriteInfo();

            Student s = new Student("Krzysztof", "Jeż", new DateTime(1990,12,22), 2, 5, 54321);
            Footballer p = new Footballer("Piotr", "Kos", new DateTime(1984,09,14), "Napastnik", "Fc Politechnika");

         //   s.WriteInfo();
         //   p.WriteInfo();

            ((Footballer)o3).Score();
            p.Score();
            p.Score();

          //  o3.WriteInfo();
          //  p.WriteInfo();

            ((Student)o2).AddGrade("PO", new DateTime(2011, 02, 20), 5.0);
            ((Student)o2).AddGrade("Bazy Danych", new DateTime(2011, 02, 13), 4.0);

            o2.WriteInfo();

            s.AddGrade("Bazy danych", new DateTime(2011, 05, 11), 5.0);
            s.AddGrade("AWWW", new DateTime(2011, 05, 11), 5.0);
            s.AddGrade("AWWW", new DateTime(2011, 04, 02), 4.5);

            s.WriteInfo();

            s.DeleteGrade("AWWW", new DateTime(2011, 04, 02), 4.5);

            s.WriteInfo();

            s.DeleteGrades("AWWW");

            s.WriteInfo();

            s.DeleteGrades();
            s.WriteInfo();

            Console.ReadKey();
        }
    }
}
