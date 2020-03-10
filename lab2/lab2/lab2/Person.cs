using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Person
    {
        protected string firstname, lastname, birthday;

        public Person(string _firstname, string _lastname, string _birthday)
        {
            firstname = _firstname;
            lastname = _lastname;
            birthday = _birthday;
        }
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public override string ToString()
        {
            return $"\nFirstname: {firstname}\nLastname: {lastname}\nDate of birth: {birthday}\n";
        }
        public virtual void WriteInfo()
        {
            Console.WriteLine();
        }

    }
}
