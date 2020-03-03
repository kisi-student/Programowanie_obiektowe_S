using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _doorCount;
        private int _engineCapacity;
        private double _avgFuelConsumption;
        private string _registrationNumber;
        private static int _carsCount = 0;

        public Car()
        {
            _brand = "unknown";
            _model = "unknown";
            _doorCount = 0;
            _avgFuelConsumption = 0.0;
            _registrationNumber = "uknown";
            _carsCount++;
        }

        public Car(string _mark, string _model, string _registrationNumber, int _doorCount, int _engineCapacity, double _avgFuelConsumption)
        {
            this._brand = _mark;
            this._model = _model;
            this._doorCount = _doorCount;
            this._engineCapacity = _engineCapacity;
            this._avgFuelConsumption = _avgFuelConsumption;
            this._registrationNumber = _registrationNumber;
            _carsCount++;
        }

        private double CalculateFuelConsumption(double _routeLength)
        {
            return (_avgFuelConsumption * _routeLength) / 100.0;
        }

        public double CalculateCostRide(double _routeLength, double _fuelCost)
        {
            return CalculateFuelConsumption(_routeLength) * _fuelCost; 
        }
        public void WriteInformation()
        {
            Console.WriteLine("Mark:" + _brand + " Model:" + _model + " Registration Number:" + _registrationNumber + " Door Count:" + _doorCount + " Engine Capacity:" + _engineCapacity + " Avg Fuel Consumption:" + _avgFuelConsumption);
        }

        public static void WriteCarsCount()
        {
            Console.WriteLine("Cars Count:" + _carsCount + "\n");
        }



        public string Brand { get => _brand; set => _brand = value; }
        public string Model { get => _model; set => _model = value; }
        public int DoorCount { get => _doorCount; set => _doorCount = value; }
        public int EngineCapacity { get => _engineCapacity; set => _engineCapacity = value; }
        public double AvgFuelConsumption { get => _avgFuelConsumption; set => _avgFuelConsumption = value; }
        public string RegistrationNumber { get => _registrationNumber; set => _registrationNumber = value; }
    }
}
