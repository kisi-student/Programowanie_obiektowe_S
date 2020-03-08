using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;
using System.Collections.Generic;

namespace Lab_1
{
    public class Person
    {
		public string Name { get; set; }
		
		public string Surname { get; set; }

		public string Address { get; set; }

		private List<string> _registrations = new List<string>();
		private int _carCount = 0;

		public Person()
		{
			Name = "none";
			Surname = "none";
			Address = "none";
		}

		public Person(string name, string surname,string address)
		{
			Name = name;
			Surname = surname;
			Address = address;
		}

		public void PushCar(string registrationNr)
		{
			if (_carCount < 3)
			{
				_registrations.Add(registrationNr);
				_carCount++;
			}
			else
            {
                Console.WriteLine("Maximum number of owned cars is 3.");
            }
		}

        public void PopCar(string registrationNr)
        {
			if(_carCount > 0)
            {
				_registrations.Remove(registrationNr);
				_carCount--;
            }
			else
            {
				Console.WriteLine("There is no cars in garage.");
            }
        }
		
        public void PrintInfo()
        {
			Console.WriteLine(this);
        }

		public override string ToString()
		{
            string str = $"Name: {Name} Surname: {Surname}\nAddress: {Address}\nOwned cars:\n";

			foreach (var registration in _registrations)
			{
                str += registration + "\n";
			}

            return str;
		}
	}
}
