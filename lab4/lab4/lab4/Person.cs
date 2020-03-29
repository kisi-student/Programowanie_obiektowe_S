using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{

    class Person
    {
        public int Id { get; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        static int _id = 101;

        public Person(string Firstname, string Lastname, int Age)
        {
            this.Id = _id++;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Age = Age;
        }
        public override string ToString() => $"{Firstname} {Lastname} age: {Age} id: {Id}";

    }
}
