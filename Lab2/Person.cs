using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Person
    {
        private string name;
        private string surname;
        private string birthday;

        protected string Name { get => name; set => name = value; }
        protected string Surname { get => surname; set => surname = value; }
        protected string Birthday { get => birthday; set => birthday = value; }

        public Person()
        {
        }

        public Person(string name, string surname, string birthday)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
        }

        public virtual void Details()
        {
            Console.WriteLine(this);

        }

        public override string ToString()
        {
            return $"imie:{name}, nazwisko:{surname}, data ur.:{birthday}";
        }
    }
}
