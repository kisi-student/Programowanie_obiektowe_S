using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Person
    {
        protected string Firstname { get; set; }
        protected string Lastname { get; set; }
        protected string Birthday { get; set; }

        public Person(string _firstname, string _lastname, string _birthday)
        {
            Firstname = _firstname;
            Lastname = _lastname;
            Birthday = _birthday;
        }
       
        public override string ToString()
        {
            return $"\nFirstname: {Firstname}\nLastname: {Lastname}\nDate of birth: {Birthday}\n";
        }
        public virtual void WriteInfo()
        {
            Console.WriteLine();
        }

    }
}
