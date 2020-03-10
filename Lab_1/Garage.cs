using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;

namespace Garage_
{
    public class Garage
    {
		private string adres;
		public string Adres
		{
			get { return adres; }
			set { adres = value; }
		}

		private Car[] cars;

		public Car[] Cars
		{
			get { return cars; }
		}


		private int capacity;

		public int Capacity
		{
			get { return capacity; }
			set 
			{ 
				capacity = value;
				cars = new Car[capacity];
			}
		}

		private int numberOfCars = 0;
		public int NumberOfCars
		{
			get { return numberOfCars; }
		}
		public Garage()
		{
			adres = "none";
			capacity = 0;
			cars = null;
		}

		public Garage(string _adres, int _capacity)
		{
			adres = _adres;
			capacity = _capacity;
			cars = new Car[capacity];
		}

		public void EnterCar(Car car)
		{
			if (Capacity != numberOfCars)
			{
				cars[numberOfCars] = car;
				numberOfCars++;
			}
			else
				Console.WriteLine("Garaz jest juz pelny !");
		}

		public void EnterCar()
		{
			Car car = new Car();

			if (numberOfCars > 0)
			{
				car = cars[numberOfCars - 1];
				cars[numberOfCars - 1] = null;
				numberOfCars--;
			}
			else
				Console.WriteLine("Garaz jest pusty !");
		}

		public void PrintInfo()
		{
			Console.WriteLine("Adres garazu: " + adres);
			Console.WriteLine("Pojemnosc: " + capacity);
			Console.WriteLine("Liczba samochodow: " + numberOfCars);

			Console.WriteLine("Samochody znajdujace sie w garazu: ");
				foreach(Car car in cars)
			{
				if (car != null)
					car.PrintInfo();
			}
	}
	}

		
}
