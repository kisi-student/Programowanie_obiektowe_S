using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Student:Person
    {
        private int _year;
        private int _group;
        private int _indexNumber;
        private IList<Grade> _grades = new List<Grade>();

        public Student() : base()
        {
            _year = 0;
            _group = 0;
            _indexNumber = 0;
        }

        public Student(string _firstName, string _secondName, string _dateOfBirth, int _year, int _group, int _indexNumber) : base(_firstName, _secondName, _dateOfBirth)
        {
            this._year = _year;
            this._group = _group;
            this._indexNumber = _indexNumber;
        }

        public void AddGrade(string _subject, string _data, double _value)
        {
            Grade grade = new Grade(_subject, _data, _value);
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

        public void DeleteGrade()
        {
            _grades.re
        }

        public override void WriteInfo()
        {
            base.WriteInfo();
            Console.WriteLine($"Year, group and index: {_year} {_group} {_indexNumber}");
        }

        public int IndexNumber { get => _indexNumber; set => _indexNumber = value; }
        public int Group { get => _group; set => _group = value; }
        public int Year { get => _year; set => _year = value; }
        public IList<Grade> Grades { get => _grades; set => _grades = value; }
    }
}
