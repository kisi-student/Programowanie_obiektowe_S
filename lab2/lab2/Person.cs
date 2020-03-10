using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Person
    {
        protected string _firstName;
        protected string _lastName;
        protected string _birthDate;

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
        public string BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public Person(string firstName, string lastName, string birthDate)
        {
            _firstName = firstName;
            _lastName = lastName;
            _birthDate = birthDate;
        }
        //ToString() lepiej
        public override string ToString()
        {
            return $"{_firstName} {_lastName}, urodzony(-a) {_birthDate}";
        }

        public virtual void Info()
        {
            Console.WriteLine(this); //z ToString() będzie tak

            //te se tez moga byc
            //Console.WriteLine("{0} {1}, urodzony(-a) {2}", _firstName, _lastName, _birthDate);
            //Console.WriteLine($"{_firstName} {_lastName}, urodzony(-a) {_birthDate}");
        }
    }
}
