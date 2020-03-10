using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Person
    {
        protected string _firstName;
        protected string _secondName;
        protected string _dateOfBirth;

        public Person()
        {
            _firstName = "unknown";
            _secondName = "unknown";
            _dateOfBirth = "unknown";
        }

        public Person(string _firstName, string _secondName, string _dateOfBirth)
        {
            this._firstName = _firstName;
            this._secondName = _secondName;
            this._dateOfBirth = _dateOfBirth;
        }

        public virtual void WriteInfo()
        {
            Console.WriteLine($"Name and date: { _firstName} { _secondName} {_dateOfBirth} ");
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string SecondName { get => _secondName; set => _secondName = value; }
        public string DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
    }
}
