using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student:Person
    {
        private IList<Grade> _grades = new List<Grade>();
        public Student() : base()
        {
            Year = 0;
            Group = 0;
            IndexNumber = 0;
        }

        public Student(string _firstName, string _secondName, DateTime _dateOfBirth, int _year, int _group, int _indexNumber) : base(_firstName, _secondName, _dateOfBirth)
        {
            Year = _year;
            Group = _group;
            IndexNumber = _indexNumber;
        }

        public void AddGrade(string _subject, DateTime _date, double _value)
        {
            Grade grade = new Grade(_subject, _date, _value);
            _grades.Add(grade);
        }

        public void WriteGrades()
        {
            foreach (var grade in _grades)
            {
                Console.WriteLine(grade);
            }
        }

        public void WriteGrades(string _subject)
        {
            foreach (var grade in _grades)
            {
                if (grade.Subject == _subject)
                {
                    Console.WriteLine(grade);
                }
                else
                {
                    Console.WriteLine("Brak danego przedmiotu");
                    break;
                }
            }
        }

        public void DeleteGrade(string subject, DateTime date, double value)
        {
            Grade grade = new Grade();
            foreach (var item in _grades)
            {
                if (item.Subject == subject && item.Value == value && item.Date.Date == date.Date)
                {
                    grade = item;
                }
            }
                _grades.Remove(grade);
        }

        public void DeleteGrades()
        {
            _grades.Clear();
        }

        public void DeleteGrades(string _subject)
        {
            foreach (var grade in _grades.ToList())
            {
                if (grade.Subject == _subject)
                {
                    _grades.Remove(grade);
                }
            }
        }


        public override void WriteInfo()
        {
            Console.WriteLine(this);
            foreach (var grade in _grades)
            {
                grade.WriteInfo();
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"{base.ToString()}Year: {Year} Group: {Group} IndexNumber: {IndexNumber}";
        }

        public int IndexNumber { get; set; }
        public int Group { get; set; }
        public int Year { get; set; }

    }
}
