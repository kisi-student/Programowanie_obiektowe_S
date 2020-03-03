using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class Car
    {
        private string brand;
        private string model;
        private int doorCount;
        private int engCapacity;
        private double avgConsump;

        private static int carCount = 0;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int DoorCount
        {
            get { return doorCount; }
            set { doorCount = value; }
        }
        public int EngCapacity
        {
            get { return engCapacity; }
            set { engCapacity = value; }
        }
        public double AvgConsump
        {
            get { return avgConsump; }
            set { avgConsump = value; }
        }

        public Car()
        {
            brand = "unknown";
            model = "unknown";
            doorCount = 0;
            engCapacity = 0;
            avgConsump = 0.0;
            carCount++;
        }
        public Car(string _brand, string _model, int _doorCount, int _engCapacity, double _avgConsump)
        {
            brand = _brand;
            model = _model;
            doorCount = _doorCount;
            engCapacity = _engCapacity;
            avgConsump = _avgConsump;
            carCount++;
        }
        public double CalculateConsumption(double routeLength)
        {
            return (avgConsump * routeLength) / 100;
        }
        public double CaluclateCost(double routeLength, double fuelCost)
        {
            return CalculateConsumption(routeLength) * fuelCost;
        }
        public void Details()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Door count: " + doorCount);
            Console.WriteLine("Engine capacity: " + engCapacity);
            Console.WriteLine("Average consumption: " + avgConsump);
        }
        public static void DisplayCarCount()
        {
            Console.WriteLine("Car count: " + carCount);
        }
    }
    
}
