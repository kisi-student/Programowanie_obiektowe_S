using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car
    {
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int doorCount;
        public int DoorCount
        {
            get { return doorCount; }
            set { doorCount = value; }
        }

        private int engineVolume;
        public int EngineVolume     
        {
            get { return engineVolume; }
            set { engineVolume = value; }
        }

        private double avarageConsump;
        public double AvarageConsump
        {
            get { return avarageConsump; }
            set { avarageConsump = value; }
        }

        private static int numberOfCars = 0;   

        private string registrationNumber;

        public string RegistrationNumber
        {
            get { return registrationNumber; }
            set { registrationNumber = value; }
        }

        public Car()
        {
            brand = "none";
            model = "none";
            doorCount = 0;
            registrationNumber = "none";
            engineVolume = 0;
            avarageConsump = 0.0f;
            numberOfCars++;
        }

        public Car(string _brand,string _model,string _registrationNumber,int _doorCount,int _engineVolume,double _avarageConsump)
        {
            brand = _brand;
            model = _model;
            doorCount = _doorCount;
            engineVolume = _engineVolume;
            avarageConsump = _avarageConsump;
            registrationNumber = _registrationNumber;
            numberOfCars++;
        }

        private double CountConsump(double roadLength)
        {
            double consump;
            consump = (avarageConsump * roadLength) / 100.0;
            return consump;
        }

        public double CountCostOfTravel(double roadLength, double petrolPrice)
        {
            double consump;
            consump = CountConsump(roadLength);

            double costOfTravel;
            costOfTravel = consump * petrolPrice;

            return costOfTravel;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Marka: " + brand);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Ilosc dzrwi: " + doorCount);
            Console.WriteLine("Pojemnosc silnika: " + engineVolume);
            Console.WriteLine("Srednie spalanie: " + avarageConsump);
       
        }
        public static void PrintNumberOfCars()
        {
            Console.WriteLine("Liczba samochodow: " + numberOfCars);
        }
    }
}
