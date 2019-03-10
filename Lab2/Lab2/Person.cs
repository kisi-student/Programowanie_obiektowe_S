using System;

namespace Lab2
{
  ///
    public class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected DateTime _dateOfBirth;

        public Person()
        {
            DateOfBirth = new DateTime(); //default(DateTime);
            FirstName = "none";
            LastName = "none";
        }

        /// <summary>
        /// Konstruktor klasy 
        /// </summary>
        /// <param name="firstName">imie</param>
        /// <param name="lastName">nazwisko</param>
        /// <param name="dateOfBirth"></param>
        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }

        public override string ToString()
        {
            return $"Person data | First name: {FirstName}, Last name: {LastName}, Date of birth: {DateOfBirth} ";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }
    }
}
