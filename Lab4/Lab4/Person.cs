using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public Person(string firstname, string lastname, int age)
        {
            if(string.IsNullOrWhiteSpace(firstname) || string.IsNullOrWhiteSpace(lastname))
            {
                throw new ArgumentException();
            }
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
        }

        
        public override bool Equals(object obj)
        {
            if((obj == null) || !(this.GetType().Equals(obj.GetType())))
            {
                return false;
            }
            else
            {
                Person person = (Person)obj;
                return (Age == person.Age && Firstname == person.Firstname && Lastname == person.Lastname);
            }
        }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} age: {Age}";
        }
    }
}
