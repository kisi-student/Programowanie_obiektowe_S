using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    // Klasa Samochod
    public class Car
    {
        private string brand;       // marka 
        private string model;       // model
        private int doorCount;      // iloscDrzwi
        private int engineVolume;   // pojemnoscSilnika
        private double avgConsump;  // srednieSpalanie

        private static int carCount = 0;   // liczbaSamochodow

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

        public int EngineVolume
        {
            get { return engineVolume; }
            set { engineVolume = value; }
        }

        public double AvgConsump
        {
            get { return avgConsump; }
            set { avgConsump = value; }
        }

/*
 // ZBEDNE ???
        public int CarCount
        {
            get { return carCount; }
            set { carCount = value; }
        }
*/

        public Car()
        {
            brand = "unknown";
            model = "unknown";
            doorCount = 0;
            engineVolume = 0;
            avgConsump = 0.0;

            carCount++;
        }

        public Car(string brand_, string model_, int doorCount_, int engineVolume_, double avgConsump_)
        {
            brand = brand_;
            model = model_;
            doorCount = doorCount_;
            engineVolume = engineVolume_;
            avgConsump = avgConsump_;
            
            carCount++;
        }

        // ObliczSpalanie
        private double CalculateConsump(double roadLength)
        {
            return (avgConsump * roadLength) * 100.0;
        }

        // ObliczKosztPrzejazdu
        public double CalculateCost(double roadLength, double petrolCost)
        {
            return CalculateConsump(roadLength) * petrolCost;
        }

        // WypiszInfo
        public void Details()
        {
            Console.WriteLine("Brand: " + brand + "\tModel: " + model + "\tDoor: " + doorCount + "\tEngine Vol.: " + engineVolume + "\tFuel Consump per 100km: " + avgConsump);
        }

/*
 // LEPIEJ TAK !!!
        public override string ToString()
        {
            return $"Car | Brand: {_brand}, Model: {_model}, NumOfDoors: {_doorCount}, EngineVol: {_engineVolume}, AvgConsump: {_avgConsump}, RegistrationNumber: {_registrationNumber}";
        }

        public void Details()
        {
            Console.WriteLine(this);
        }
*/

        // WypiszIloscSamochodow
        public static void DisplayCarCount()
        {
            Console.WriteLine("Car Count = " + carCount);
        }

/*
 //LEPIEJ TAK ???
        public static void DisplayCarCount()
        {
            Console.WriteLine($"Car instances count: {carCount}");
        }
*/
    }
}
