using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Garage
    {
        private string _address;
        private int _capacity;
        private int _carCount = 0;
        private Car[] _collection;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public int Capacity
        {
            get { return _capacity; }
            set
            {
                _capacity = value;
                _collection = new Car[_capacity];
            }
        }

        public Garage()
        {
            _address = "unknown";
            _capacity = 0;
            _collection = null;
        }
        public Garage(string address, int capacity)
        {
            _address = address;
            _capacity = capacity;
            _collection = new Car[capacity];
        }

        public void InsertCar(Car c)
        {
            if (_carCount < _capacity)
            {
                _collection[_carCount] = c;
                _carCount++;
                Console.WriteLine("Pomyslnie dodano samochod");
            }
            else
            {
                Console.WriteLine("Nie dodano samochodu - brak miejsca w garazu");
            }
        }
        public Car RemoveCar()
        {
            Car removedCar = new Car();
            if (_carCount == 0)
            {
                Console.WriteLine("Garaz jest juz pusty");
                return removedCar;
            }
            else
            {
                removedCar.Brand = _collection[_carCount - 1].Brand;
                removedCar.Model = _collection[_carCount - 1].Model;
                removedCar.AvgConsump = _collection[_carCount - 1].AvgConsump;
                removedCar.EngineCap = _collection[_carCount - 1].EngineCap;
                removedCar.NumDoors = _collection[_carCount - 1].NumDoors;
                _collection[_carCount - 1] = null;
                _carCount--;
                Console.WriteLine("Pomyslnie usunieto samochod z garazu");
                return removedCar;
            }
        }
        public void GarageInfo()
        {
            Console.WriteLine("Informacje o garazu:");
            Console.WriteLine("Pojemnosc garazu: {0} pojazd(-ow)", _capacity);
            Console.WriteLine("Ilosc samochodow w garazu: {0}", _carCount);
            for(int i=0; i<_carCount; i++)
            {
                Console.WriteLine("Samochod nr {0}", i);
                _collection[i].CarInfo();
            }
        }
    }
}
