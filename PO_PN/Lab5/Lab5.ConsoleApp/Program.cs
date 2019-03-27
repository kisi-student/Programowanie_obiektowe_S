using System;
using System.Collections.Generic;
using System.Linq;
using Lab5.BLL;

namespace Lab5.ConsoleApp
{
    public class Program
    {
        private static void Main()
        {
            Department db = new Department("WIM",
                new Lecturer("Jan", "Nowak", DateTime.Now.AddYears(-56), "dr hab.", "dziekan"),
                new List<OrganizationUnit>
                {
                    new OrganizationUnit("IOO", "Reolnicza 2"),
                    new OrganizationUnit("SKL", "Miedziana 13")
                }
            );

            Random rnd = new Random();
            var first = new string[] {"Ala", "Jacek", "Maciej", "Monika"};
            var last = new string[] { "Nowak", "Saoplica", "Krawczyk", "Walaszek" };
            var spec = new string[] { "Informatyka", "Mechanika" };
            string randGet(string[] l) => l[rnd.Next(l.Length)];
            for (int i = 0; i<10; i++)
            {
                db.Add(new Student( randGet(first), randGet(last), DateTime.Now.AddYears(-rnd.Next(18, 26)), randGet(spec), rnd.Next(1, 6)));
            }


            db.Add(new Student("Jacek", "Placek", new DateTime(1989, 2, 12), "Matematyka", 1))
                .Add(new Student("Marek", "Kulawy", new DateTime(2001, 12, 1), "Matematyka", 1))
                .PrintInfo()
                .Set<Student>().PrintInfo()
                    //.First().GetList<FinalGrade>(g=>g.Subject.Name=="Informatyka").PrintInfo();
              ;

            db.Set<Student>().First().GetList<FinalGrade>(g => g.Subject.Name == "Informatyka").PrintInfo();
            

            db.Add(new Subject("PO", "Informatyka", 2, 10))
                .Add(new Subject("Sieci", "Informatyka", 2, 30));

            db.Get<OrganizationUnit>("SKL")
                .Add(new Lecturer("Maria", "Mangdalena", new DateTime(1912, 12, 1), "mgr", "Katecheta"))
                ;//.PrintInfo();


            db.Set<OrganizationUnit>().PrintInfo();


            db.Get<OrganizationUnit>("SKL")
                .Remove<Lecturer>(l => l.FirstName == "Maria")
                .AddInto(db.Get<OrganizationUnit>("IOO"));

            db.Set<OrganizationUnit>().PrintInfo();

            /*db.Get<Student>(s=>s.IndexId == 1000)
                .Print<Student, FinalGrade>()
                .Add(new FinalGrade(db.Get<Subject>(s=>s.Name == "PO"), 4, DateTime.Now))                
                //.Add(new FinalGrade(db.Get<Subject>("Sieci"), 4, DateTime.Now))
                //.Print<FinalGrade,Student>();
                ;
            db.PrintInfo<Student>();*/

            Console.ReadKey();
        }
    }
}
