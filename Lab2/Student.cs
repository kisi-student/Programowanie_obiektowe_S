using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Student:Person
    {
        private int year;
        private int group;
        private int indexNumber;
        private IList<Grade> grades = new List<Grade>();

        public Student() : base()
        {

        }

        public Student(string name, string surname, string birthday, int year, int group, int indexNumber) : base(name, surname, birthday)
        {
            this.year = year;
            this.group = group;
            this.indexNumber = indexNumber;

        }

        public void AddGrade(string subjectName, string date, double value)
        {
            grades.Add(new Grade(subjectName, date, value));
        }

        public void PrintGrades()
        {
            foreach (Grade g in grades)
                Console.WriteLine(g);
        }

        public void PrintGrades(string subjectName)
        {
            foreach (Grade g in ((List<Grade>)grades).FindAll(x=> x.SubjectName == subjectName))
            {
                Console.WriteLine(g);
            }
                
        }

        public void RemoveGrade(string subjectName, string date, double value)
        {
            grades.Remove(new Grade(subjectName, date, value));

        }

        public void RemoveAllGrades()
        {
            grades.Clear();
        }

        public void RemoveGrades(string subjectName)
        {
            foreach (Grade g in ((List<Grade>)grades).FindAll(x => x.SubjectName == subjectName))
            {
                grades.Remove(g);
            }
        }


        public int Year { get => year; set => year = value; }
        public int Group { get => group; set => group = value; }
        public int IndexNumber { get => indexNumber; set => indexNumber = value; }

        public override void Details()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            string res = base.ToString() + $", rok:{year}, grupa:{group}, nr indeksu:{indexNumber}, oceny: ";
            foreach (Grade g in grades)
                res += g.ToString();
            return res;
        }
    }
}
