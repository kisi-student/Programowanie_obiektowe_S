using System;

namespace Lab2
{
    public class Person
    {
        protected string FirstName { get; set; }
        protected string SecondName { get; set; }
        protected DateTime DateOfBirth { get; set; }

        public Person()
        {
            FirstName = "unknown";
            SecondName = "unknown";
            DateOfBirth = new DateTime();
        }

        public Person(string _firstName, string _secondName, DateTime _dateOfBirth)
        {
            FirstName = _firstName;
            SecondName = _secondName;
            DateOfBirth = _dateOfBirth;
        }
        public virtual void WriteInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"FirstName:{FirstName} SecondName:{SecondName} Date of birth:{DateOfBirth.ToShortDateString()}\n";
        }
    }
}
