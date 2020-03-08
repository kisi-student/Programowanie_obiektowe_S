using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Person
    {
        private string _name;
        private string _surname;
        private string _address;
        private int _numberOfCars;
        private string[] _registrationNumbers;

        public Person()
        {
            _name = "uknown";
            _surname = "unknown";
            _address = "uknown";
            _numberOfCars = 0;
            _registrationNumbers = null;
        }

        public Person(string _name, string _surname, string _address, int _numberOfCars)
        {
            this._name = _name;
            this._surname = _surname;
            this._address = _address;
            NumberOfCars = _numberOfCars;
        }

        public void AddCar(string _registrationNumber)
        {
            if(_numberOfCars >= 3)
            {
                Console.WriteLine("This person already has 3 cars\n");
            }
            else
            {
                int _tmpSize = _numberOfCars;
                string[] _temp;
                _temp = new string[_tmpSize];

                for (int i = 0; i < _numberOfCars; i++)
                {
                    _temp[i] = _registrationNumbers[i];
                }

                _numberOfCars++;
                _registrationNumbers = new string[_numberOfCars];
                for (int i = 0; i < _tmpSize; i++)
                {
                    _registrationNumbers[i] = _temp[i];
                }
                _registrationNumbers[_numberOfCars - 1] = _registrationNumber;
            }
        }

        public void DeleteCar(string _registrationNumber)
        {
            if(_numberOfCars == 0)
            {
                Console.WriteLine("This person does not own any car\n");
            }
            else
            {
                Console.WriteLine("\nCar with this registration number will be deleted:" + _registrationNumber);

                int _tmpSize = _numberOfCars;
                string[] _temp;
                _temp = new string[_tmpSize];

                for (int i = 0; i < _numberOfCars; i++)
                {
                    _temp[i] = _registrationNumbers[i];
                }

                for (int i = 0; i < _numberOfCars; i++)
                {
                    if (_temp[i] == _registrationNumber )
                    {
                        _temp[i] = null;
                    }
                }
                _numberOfCars--;

                _registrationNumbers = new string[_numberOfCars];
                for (int i = 0, j = 0; i < _numberOfCars; )
                {
                    if(_temp[j] != null)
                    {
                        _registrationNumbers[i] = _temp[j];
                        i++;
                    }
                    j++;
                }
            }
        }

        public void WriteInfo()
        {
            Console.WriteLine("\nInformation about person");
            Console.WriteLine("Name:"+_name+" Surname:"+_surname+" Address:"+_address+" Number of Cars:"+_numberOfCars);
            Console.WriteLine("Registration number of:");
            for (int i = 0; i < _numberOfCars; i++)
            {
                Console.WriteLine(i + 1 + "." + _registrationNumbers[i] + " "); ;
            }
        }



        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public string Address { get => _address; set => _address = value; }
        public int NumberOfCars
        {
            get => _numberOfCars;
            set
            {
                _numberOfCars = value;
                _registrationNumbers = new string[_numberOfCars];
                for (int i = 0; i < _numberOfCars; i++)
                {
                    _registrationNumbers[i] = "unknown";
                }
            }
        }
    }
}
