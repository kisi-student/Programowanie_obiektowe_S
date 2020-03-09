using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Car
    {
        //pola
        private string _brand;
        private string _model;
        private int _numDoors;
        private int _engineCap;
        private double _avgConsump;
        private string _registrationNumber;
        private static int _carCount = 0;
        //wlasciwosci
        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int NumDoors
        {
            get { return _numDoors; }
            set { _numDoors = value; }
        }
        public int EngineCap
        {
            get { return _engineCap; }
            set { _engineCap = value; }
        }
        public double AvgConsump
        {
            get { return _avgConsump; }
            set { _avgConsump = value; }
        }
        public string RegistrationNumber
        {
            get { return _registrationNumber; }
            set { _registrationNumber = value; }
        }
        //konstruktory
        public Car()
        {
            _brand = "unknown";
            _model = "unknown";
            _numDoors = 0;
            _engineCap = 0;
            _avgConsump = 0.0;
            _registrationNumber = "unknown";
            _carCount++;
        }
        public Car(string brand, string model, int numDoors, int engineCap, double avgConsump, string registrationNumber)
        {
            _brand = brand;
            _model = model;
            _numDoors = numDoors;
            _engineCap = engineCap;
            _avgConsump = avgConsump;
            _registrationNumber = registrationNumber;
            _carCount++;
        }
        //metody
        public double CalcConsump(double distance)
        {
            return (distance / 100) * _avgConsump;
        }
        public double CalcFuelCost(double distance, double fuelCost)
        {
            return CalcConsump(distance) * fuelCost;
        }
        public void CarInfo()
        {
            Console.WriteLine("Marka: {0}", _brand);
            Console.WriteLine("Model: {0}", _model);
            Console.WriteLine("Pojemnosc silnika: {0}cc", _engineCap);
            Console.WriteLine("Srednie spalanie: {0}l / 100km", _avgConsump);
            Console.WriteLine("Liczba drzwi: {0}", _numDoors);
            Console.WriteLine("Numer rejestracyjny: {0}", _registrationNumber);

        }
        public static void CarCount()
        {
            Console.WriteLine("Liczba samochodow w bazie: {0}", _carCount);
        }
    }

}
