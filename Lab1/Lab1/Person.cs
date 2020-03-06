using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        public static int MaxCarCount { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int CarsCount => RegistationNumbers.Count;
        public IList<string> RegistationNumbers { get; set; }

        public Person()
        {
            FirstName = "none";
            LastName = "none";
            Address = "none";
            RegistationNumbers = new List<string>();
        }

        public Person(string firstName, string lastName, string address)
        {
            RegistationNumbers = new List<string>();
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public void AddCarRegistrationNumber(string registrationNumber)
        {
            if (MaxCarCount <= RegistationNumbers.Count)
                Console.WriteLine("The Person already have maximum number of cars");
            else
                RegistationNumbers.Add(registrationNumber);
        }

        public void RemoveCarRegistrationNumber(string registrationNumber)
        {
            string regNum = RegistationNumbers.FirstOrDefault(x => x.CompareTo(registrationNumber) == 0);
            if (regNum == null)
                Console.WriteLine($"The giver registration number is not assigned to a person.");
            else
                RegistationNumbers.Remove(registrationNumber);
        }

        public override string ToString()
        {
            string str = $"First name: {FirstName}, Last name: {LastName}, Address: {Address}, Cars count: {CarsCount} \r\n Registration numbers: ";
            foreach (var regNum in RegistationNumbers)
                str += regNum  +", ";
            return str;
        }
        public void Details()
        {
            Console.WriteLine(this);
        }

    }
}
