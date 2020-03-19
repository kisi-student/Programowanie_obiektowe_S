using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Student: Person
    {
        //moze tak byc, bo w domysle np. przy "get" jest anonimowe prywatne pole
        public int Year { get; set; }
        public int Group { get; set; }
        public int IndexNo { get; set; }

        private List<Mark> Marks = new List<Mark>();

        public Student(string firstName, string lastName, string birthDate, int year, int group, int indexNo):
            base(firstName, lastName, birthDate)
        {
            Year = year;
            Group = group;
            IndexNo = indexNo;
        }

        public void AddMark(string subjectName, string date, double value)
        {
            Mark mark = new Mark(subjectName, date, value);
            Marks.Add(mark);
        }



        public void MarksInfo()
        {
            foreach(Mark element in Marks)
            {
                element.Info();
            }
        }

        public void MarksInfo(string subjectName)
        {
            foreach(Mark element in Marks)
            {
                if (element.SubjectName == subjectName)
                    element.Info();
            }
        }
        
        public void RemoveMark(string subjectName, string date, double value)
        {
            for(int i=0; i<Marks.Count(); i++)
            {
                if (Marks[i].SubjectName == subjectName && Marks[i].Date == date && Marks[i].Value == value)
                    Marks.RemoveAt(i);
            }
        }

        public void RemoveAllMarks()
        {
            Marks.Clear();
        }
        public void RemoveAllMarks(string subjectName)
        {
            for (int i=0; i<Marks.Count(); i++)
            {
                if (Marks[i].SubjectName == subjectName)
                {
                    Marks.RemoveAt(i);
                }
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}, nr indeksu: {IndexNo}, grupa {Group}, rok {Year}";
        }

        public override void Info()
        {
            Console.WriteLine(this);
            Console.WriteLine("Oceny studenta: ");
            foreach(Mark element in Marks)
            {
                element.Info();
            }
        }
    }
}
