using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5.BLL
{
    public class Student : Person, IObject, IAction
    {
        static int _LaastId = 1000;

        public int Semester { get; set; }

        public int Group { get; set; }

        public int IndexId { get; set; }

        public IList<FinalGrade> Grades { get; private set; }

        public string Specjalization { get; set; }
        
        public Student(string firstName, string lastName, DateTime dateOfBirth, string specjalization,
                        int group, int semester = 1)
            : base(firstName, lastName, dateOfBirth)
        {
            Semester = semester;
            Group = group;
            IndexId = _LaastId++;
            Grades = new List<FinalGrade>();
            Specjalization = specjalization;
        }

        public override string ToString()
        {
            return base.ToString() + $" {Specjalization}, sem: {Semester}, gr: {Group}, index: {IndexId}";            
        }

        public double AverageGrade { get { return Grades.Sum(g=>g.Value)/Grades.Count; } }


        public void Add(Subject subject, double value, DateTime date)
        {
            FinalGrade grade = new FinalGrade(subject, value, date);
            Grades.Add(grade);
        }

        public override void DisplayInfo()
        {
            Console.WriteLine(this);
            Console.WriteLine("Grades:");
            Grades.ToList().ForEach(g => Console.WriteLine($"\t{g}"));
        }

        public IList<C> Set<C>() where C : IObject
        {
            if (typeof(C) == typeof(FinalGrade))
                return (IList<C>)Grades;
            throw new ArgumentException();
        }

    }
}
