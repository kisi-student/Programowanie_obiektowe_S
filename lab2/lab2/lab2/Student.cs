using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Student : Person
    {
        private int Year { get; set; }
        private int Group { get; set; }
        private int IndexNumber { get; set; }

        public Student(string _firstname, string _lastname, string _birthday, int _year, int _group, int _indexNumber) : base(_firstname, _lastname, _birthday)
        {
            Year = _year;
            Group = _group;
            IndexNumber = _indexNumber;
        }
        private List<Grade> grades = new List<Grade>(); 
        public override string ToString()
        {

            
            string str = base.ToString() + $"\nYear: {Year}\nGroup: {Group}\nIndex number: {IndexNumber}\n";
            
            return str;
        }
        public override void WriteInfo()
        {
            
            for(int i=0; i<grades.Count; i++)
            {
                Grade g = grades[i];
                g.WriteInfo();
            }
            Console.WriteLine(this);
        }
        public void AddGrade (string subject, string date, double value)
        {
           grades.Add(new Grade(subject, date, value));
            
        }
        public void WriteGrade()
        {
            for (int i = 0; i < grades.Count; i++)
                Console.WriteLine("Grades:"+grades[i]);
        }
        public void WriteGrade(string Subject)
        {
            
            for (int i = 0; i < grades.Count; i++)
                Console.WriteLine("Grades:" + grades[i].Subject);
        }
        public void RemoveGrade(string subject, string date, double value)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                Grade g = grades[i];
                if(g.Subject == subject && g.Date == date && g.Value == value)
                {
                    grades.RemoveAt(i);
                }

            }
        }
        public void RemoveGrades()
        {
            grades.Clear();
        }
        public void RemoveGrades(string subject)
        {
            for(int i=0; i<grades.Count; i++)
            {
                Grade g = grades[i];
                if(g.Subject == subject)
                     grades.Clear();

            }
        }
        
    }
}
