using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Garage
    {
        private string _address;
        private int _capacity;
        private int _numberOfCars = 0;
        private Car[] _cars;

        public Garage()
        {
            _address = "unknown";
            _capacity = 0;
            _cars = null;
        }

        public Garage(string _address, int _capacity)
        {
            this._address = _address;
            Capacity = _capacity;
        }

        public void AddCar(Car car)
        {
            if(_numberOfCars == _capacity)
            {
                Console.WriteLine("\nGarage is full\n");
            }
            else
            {
                _numberOfCars++;
                _cars[_numberOfCars - 1] = car;
            }
        }

        public void DeleteCar()
        {
            if(_numberOfCars == 0)
            {
                Console.WriteLine("\nGarage is empty\n");
            }
            else
            {
                Console.WriteLine("\nThis car will be deleted from the garage:");
                _cars[_numberOfCars - 1].WriteInformation();
                Console.WriteLine("\n");
                _cars[_numberOfCars - 1] = null;
                _numberOfCars--;
            }
        }

        public void WriteInfo()
        {
            if(_numberOfCars == 0)
            {
                Console.WriteLine("\nGarage is empty\n");
            }
            else
            {
                Console.WriteLine("Cars in the garage:");
                for (int i = 0; i < _numberOfCars; i++)
                {
                    _cars[i].WriteInformation();
                }
            }
        }

        public string Address { get => _address; set => _address = value; }
        public int Capacity 
        { 
            get => _capacity;
            set
            {
                _capacity = value;
                _cars = new Car[_capacity];
            }
        }
    }
}
