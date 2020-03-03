using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Car
    {
        private string _brand;
        private string _model;
        private int _numDoors;
        private int _engineCap;
        private double _avgConsump;
        private static int _carCount = 0;

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

        public Car()
        {
            _brand = "unknown";
            _model = "unknown";
            _numDoors = 0;
            _engineCap = 0;
            _avgConsump = 0.0;
            _carCount++;
        }

        public Car(string brand, string model, int numDoors, int engineCap, double avgConsump)
        {
            _brand = brand;
            _model = model;
            _numDoors = numDoors;
            _engineCap = engineCap;
            _avgConsump = avgConsump;
            _carCount++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
