using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student : Person
    {
        private int year;
        private int group;
        private int indexNumber;
        private List<Grade> grades = new List<Grade>();

        public int Year { get => year; set => year = value; }
        public int Group { get => group; set => group = value; }
        public int IndexNumber { get => indexNumber; set => indexNumber = value; }

        public Student():
            base()
        {
            year = 0;
            group = 0;
            indexNumber = 0;
        }


        public Student(string name_, string surname_, string dateOfBirth_, int year_, int group_, int indexNumber_):
            base(name_, surname_, dateOfBirth_)
        {
            year = year_;
            group = group_;
            indexNumber = indexNumber_;
        }

        public override string ToString()
        {
            return base.ToString() + $"\r\nStudent Data | Year: {year}, Group: {group}, Index Number: {IndexNumber}";
        }

        public override void Details()
        {
            Console.WriteLine(this);
            Console.WriteLine("----------");
        }

        public void GradesDetails(string subjectName_)
        {
            foreach (Grade g in grades)
            {
                if (g.SubjectName == subjectName_)
                    Console.WriteLine(g);
            }
        }

        public void DeleteGrade(string subjectName_, string date_, double note_)
        {
            for (int i = 0; i < grades.Count; )
            {
                Grade g = grades[i];
                if (g.SubjectName == subjectName_ && g.Date == date_ && g.Note == note_)
                {
                    grades.RemoveAt(i);
                }
                else
                {
                    ++i;
                }
            }
        }

        public void DeleteAllGrades()
        {
            grades.Clear();
        }

        public void AddGrade(string subjectName_, string date_, double note_) 
        {
            grades.Add(new Grade(subjectName_, date_, note_));
        }
    }
}
