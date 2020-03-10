using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected string dateOfBirth;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public Person()
        {
            firstName = "none";
            lastName = "none";
            dateOfBirth = "none";
        }

        public Person(string firstName_,string lastName_,string dateOfBirth_)
        {
            firstName = firstName_;
            lastName = lastName_;
            dateOfBirth = dateOfBirth_;
        }

        public override string ToString()
        {
            return $"Name: { firstName}  Last name:  { lastName }  Date of birth: { dateOfBirth} ";
        }

        public virtual void Details()
        {
            Console.WriteLine(this);
        }
    }
}
