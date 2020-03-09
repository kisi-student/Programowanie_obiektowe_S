using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Person
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private int _carCount = 0;
        private string[] _collection;

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
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public int CarCount
        {
            get { return _carCount; }
            set { _carCount = value; }
        }

        public Person()
        {
            _firstName = "unknown";
            _lastName = "unknown";
            _address = "unknown";
            _collection = new string[3];
        }
        public Person(string firstName, string lastName, string address, int carCount)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _carCount = carCount;
            _collection = new string[3];
        }

        public void AddCar(string registrationNumber)
        {
            if (_carCount < 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (_collection[i] != null)
                    {
                        _collection[i] = registrationNumber;
                    }
                }
                Console.WriteLine("Pomyslnie dodano samochod");
            }
            else
            {
                Console.WriteLine("Brak miejsca na nastepne samochody");
            }
        }
        public void RemoveCar(string registrationNumber)
        {
            int counter = 0;
            if (_carCount > 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (_collection[i] == registrationNumber)
                    {
                        _collection[i] = null;
                    }
                    else
                    {
                        counter++;
                    }
                }
                if (counter == 3)
                {
                    Console.WriteLine("Brak podanego numeru rejestracyjnego w bazie");
                }
            }
            else
            {
                Console.WriteLine("Nie ma samochodu do usuniecia");
            }
        }
        public void PersonInfo()
        {
            Console.WriteLine("Samochody nalezace do: {0} {1}:", _firstName, _lastName);
            if (_carCount > 0)
            {
                for (int i = 0; i < _carCount; i++)
                {
                    Console.WriteLine(_collection[i]);
                }
            }
            else
            {
                Console.WriteLine("Brak samochodow");
            }
        }
    }

}
