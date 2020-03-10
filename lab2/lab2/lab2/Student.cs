using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Student : Person
    {
        private int year { get; set; }
        private int group { get; set; }
        private int indexNumber { get; set; }

        public Student(string _firstname, string _lastname, string _birthday, int _year, int _group, int _indexNumber) : base(_firstname, _lastname, _birthday)
        {
            year = _year;
            group = _group;
            indexNumber = _indexNumber;
        }
        public override string ToString()
        {
            return base.ToString()+ $"\nYear: {year}\nGroup: {group}\nIndex number: {indexNumber}\n";
        }
        public override void WriteInfo()
        {
            Console.WriteLine(this);
        }
    }
}
