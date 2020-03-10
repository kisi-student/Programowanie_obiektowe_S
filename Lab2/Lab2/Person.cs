using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Person
    {
        private string name;
        private string surname;
        private string dateOfBirth;

        protected string Name { get => name; set => name = value; }
        protected string Surname { get => surname; set => surname = value; }
        protected string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public Person()
        {
            name = ("--");
            surname = ("--");
            dateOfBirth = ("--");
        }

        public Person(string name_, string surname_, string dateOfBirth_)
        {
            name = name_;
            surname = surname_;
            dateOfBirth = dateOfBirth_;
        }

        public override string ToString()
        {
            return $"Personal Data | Name: {name} {surname}, Date of Birth: {dateOfBirth}";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }

    }
}
