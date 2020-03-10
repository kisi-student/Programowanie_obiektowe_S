using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Student : Person
    {
        private int year;
        private int group;
        private int indexId;
        private List<Grade> grades = new List<Grade>();

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Group
        {
            get { return group; }
            set { group = value; }
        }

        public int IndexId
        {
            get { return indexId; }
            set { indexId = value; }
        }

        public Student() : base()
        {
            year = 0;
            group = 0;
            indexId = 0;
            
        }

        public Student(string name_,string lastname_,string dateOfB_,int year_,int group_,int index_) : base(name_,lastname_,dateOfB_)
        {
            year = year_;
            group = group_;
            indexId = index_;
        }

        public override string ToString()
        {
            return base.ToString() + $"Year: {year}  Group:  {group }  Index ID: {indexId} ";
        }

        public override void Details()
        {
            Console.WriteLine(this);
            ShowGrades();
        }

        public void AddGrade(string subName,string date,double val)
        {
            Grade grade = new Grade(subName, date, val);
            grades.Add(grade);
        }

        public void ShowGrades()
        {
            for (int i = 0; i < grades.Count; i++)
            {
                grades[i].Details();
            }
        }

        public void ShowGrades(string subName)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if(grades[i].SubName==subName)
                    grades[i].Details();
            }
        }

        public void DeleteGrade(string subName,string date,double val)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i].SubName == subName && grades[i].Date == date && grades[i].Value1 == val)
                    grades.RemoveAt(i);
            }
        }

        public void DeleteGrades()
        {
            grades.Clear();
        }

        public void DeleteGrade(string subName)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i].SubName == subName )
                    grades.RemoveAt(i);
            }
        }
    }
}
