using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
	class Person
	{
		private string name;
		private string surname;
		private string address;
		private int carsNumber = 0;
		private IList<string> cars = new List<string>();

		public string Name { get => name; set => name = value; }
		public string Surname { get => surname; set => surname = value; }
		public string Address { get => address; set => address = value; }
		public int CarsNumber { get => carsNumber;}
		public IList<string> Cars { get => cars; }

		public Person(string name, string surname, string address)//usunięty argument o ilosci samochodow- prawdopodobny blad logiczny
		{
			this.name = name;
			this.surname = surname;
			this.address = address;

		}

		public Person()
		{
		}

		public void AddCar(string licensePlateNumber)
		{
			if (carsNumber < 3)
			{
				cars.Add(licensePlateNumber);
				carsNumber++;
			} 
			else 
			{
				Console.Write(this);
				Console.WriteLine(" nie może posiadać więcej niż 3 samochody.");
			}

		}

		public void RemoveCar(string licensePlateNumber)
		{
			if (carsNumber > 0)
			{
				cars.Remove(licensePlateNumber);
				carsNumber--;
			}
			else
			{
				Console.Write(this);
				Console.WriteLine(" nie posiada żadnego samochodu.");
			}
		}

		public void PrintInfo()
		{
			Console.WriteLine(this);
		}

		public override string ToString()
		{
			string res = $"Osoba( imie:{name}, nazwisko:{surname}, adres:{address}, liczba Aut:{carsNumber}";
			if (carsNumber > 0) res += ", Auta: ";
			foreach (string c in cars)
			{
				res += c + " ";
			}
			
			return res+")";
		}

	}
}
