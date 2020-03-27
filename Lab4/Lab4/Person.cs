using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public Person(string name,string surname,int age)
        {
            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentException();
            }

            Name = name;
            Surname = surname;
            Age = age;
            
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !(this.GetType().Equals(obj.GetType())))
            {
                return false;
            }
            else
            {
                Person person = (Person)obj;
                return (Age == person.Age && Name == person.Name && Surname == person.Surname);
            }
        }

            public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }
    
}
