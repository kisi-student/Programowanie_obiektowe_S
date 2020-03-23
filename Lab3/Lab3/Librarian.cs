using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Librarian : Person
    {
        private string dateOfEmployment;
        private double wage;

        public string DateOfEmployment { get => dateOfEmployment; set => dateOfEmployment = value; }
        public double Wage { get => wage; set => wage = value; }

        public Librarian():
            base()
        {
            dateOfEmployment = ("--");
            wage = 0;
        }

        public Librarian(string name_, string surname_, string dateOfEmployment_, double wage_) :
            base(name_, surname_)
        {
            dateOfEmployment = dateOfEmployment_;
            wage = wage_;
        }

        public override string ToString()
        {
            return base.ToString() + $" Date of Employment: {dateOfEmployment}, Wage: {wage}";
        }

        public void Details() 
        {
            Console.WriteLine(this);
            Console.WriteLine("-----------");
        }
    }
}
