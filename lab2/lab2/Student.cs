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

        public Student(string firstName, string lastName, string birthDate, int year, int group, int indexNo):
            base(firstName, lastName, birthDate)
        {
            Year = year;
            Group = group;
            IndexNo = indexNo;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, nr indeksu: {IndexNo}, grupa {Group}, rok {Year}";
        }

        public override void Info()
        {
            Console.WriteLine(this);
        }
    }
}
