using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Car
    {
        private string brand;
        private string model;
        private int doorNumber;
        private double engineCapacity;
        private double avgPetrolUse;//per 100km
        public static int carNumber = 0;

        public Car()
        {
            carNumber++;
            brand = "unknown";
            model = "unknown";
            doorNumber = 0;
            engineCapacity = 0.0;
            avgPetrolUse = 0.0;
        }

        public Car(string brand, string model, int doorNumber, double engineCapacity, double avgPetrolUse)
        {
            carNumber++;
            this.brand = brand;
            this.model = model;
            this.doorNumber = doorNumber;
            this.engineCapacity = engineCapacity;
            this.avgPetrolUse = avgPetrolUse;
        }

        /// <summary>
        /// Method calculates average petrol use in given distance in kilometers
        /// </summary>
        /// <param name="distance">distance in km</param>
        /// <returns>petrol use</returns>
        public double avgPetrolUseInDistance(double distance)
        {
            return (avgPetrolUse * distance) / 100.0;
        }

        /// <summary>
        /// Method calculates driving cost in given distance in km and petrol price in l
        /// </summary>
        /// <param name="distance">distance in kilometers</param>
        /// <param name="petrolPrice">petrol price in liters</param>
        /// <returns>total cost</returns>
        public double drivingCost(double distance, double petrolPrice)
        {
            return avgPetrolUseInDistance(distance) * petrolPrice;
        }

        public string Brand { get => brand; set => brand = value; }
        public string Model { get => model; set => model = value; }
        public int DoorNumber { get => doorNumber; set => doorNumber = value; }
        public double EngineCapacity { get => engineCapacity; set => engineCapacity = value; }
        public double AvgPetrolUse { get => avgPetrolUse; set => avgPetrolUse = value; }

        public override string ToString()
        {
            return $"Auto( marka:{brand}, model:{model}, l.drzwi:{doorNumber}, poj. silnika:{engineCapacity}, sr. uz. paliwa:{avgPetrolUse})";
        }

        public void printInfo()
        {
            Console.WriteLine(this);
        }

        public static void printNumberOfCarInstances()
        {
            Console.WriteLine(carNumber);
        }
    }
}
