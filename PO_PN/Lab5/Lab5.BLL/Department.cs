using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5.BLL
{
    public class Department : ISearchAction, IObject
    {
        public string Name { get; set; }
        public Person Dean { get; set; }
        public IList<OrganizationUnit> OrganizationUnits { get; set; }
        public IList<Subject> Subjects { get; set; }
        public IList<Student> Students { get; set; }
        public Department(string name, Person dean, List<OrganizationUnit> units = null, IList<Subject> subjects = null, IList<Student> students = null)
        {
            Name = name;
            Dean = dean;
            OrganizationUnits = units ?? new List<OrganizationUnit>();
            Subjects = subjects ?? new List<Subject>();
            Students = students ?? new List<Student>();
        }
        
        public IList<C> Set<C>() where C : IObject
        {
            if (typeof(C) == typeof(OrganizationUnit))
                return (IList<C>)OrganizationUnits;
            if (typeof(C) == typeof(Subject))
                return (IList<C>)Subjects;
            if (typeof(C) == typeof(Student))
                return (IList<C>)Students;
            throw new NotImplementedException();
        }

        public Func<C, bool> SearchFn<C>(string searchId) where C : IObject        
        {
            if (typeof(C) == typeof(OrganizationUnit))
                return ((Func<OrganizationUnit, bool>)(s => s.Name == searchId)) as Func<C, bool>;
            if (typeof(C) == typeof(Subject))
                return ((Func<Subject, bool>)(s => s.Name == searchId)) as Func<C, bool>;
            if (typeof(C) == typeof(Student))
                return ((Func<Student, bool>)(s => s.IndexId.ToString() == searchId)) as Func<C, bool>;
            throw new NotImplementedException();
        }






        public void StudentsInfo()
        {
            Console.WriteLine("Students in UNIT");
            Students.PrintInfo();
        }

        public void UnitsInfo()
        {
            Console.WriteLine("Organization Units");
            OrganizationUnits.PrintInfo();
        }

        public void SubjectsInfo()
        {
            Console.WriteLine("Subjects:");
            Subjects.PrintInfo();
        }

        
        public override string ToString()
        {
            return $"Department: {Name}, Dean: {Dean}"; 
        }
        
        public void DisplayInfo()
        {
            Console.WriteLine($"{this}");

            Console.WriteLine($"\n\tUnits:");
            OrganizationUnits.All(s => { Console.WriteLine($"\t{s}"); return true; });

            Console.WriteLine($"\n\tSubjects:");
            Subjects.All(s => { Console.WriteLine($"\t{s}"); return true; });

            Console.WriteLine($"\n\tStudents:");
            Students.All(s => { Console.WriteLine($"\t{s}"); return true; });
        }

       
    }
}
