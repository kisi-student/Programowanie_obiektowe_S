using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
   public class Person
    {
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected DateTime Birthday { get; set; }

       public Person(string name, string surname, DateTime birthday)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
        }

        public virtual void  PrintInfo()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"{Name} {Surname}\nBirthday: {Birthday.ToShortDateString()}";
        }
    }
}
