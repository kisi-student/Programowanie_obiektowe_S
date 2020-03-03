using System;

namespace Lab1
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public int DoorCount { get; set; }
        public int EngineCapacity { get; set; }
        public double AverageCombustion { get; set; }

        private static int carCount = 0;

        public Car()
        {
            Brand = "none";
            Model = "none";
            Registration = "none";
            DoorCount = 0;
            EngineCapacity = 0;
            AverageCombustion = 0.0f;

            carCount++;
        }

        public Car(string brand, string model, int doorCount, int engineCapactiy, double averageCombustion, string registrationNumber = "")
        {
            Brand = brand;
            Model = model;
            DoorCount = doorCount;
            EngineCapacity = engineCapactiy;
            AverageCombustion = averageCombustion;
            Registration = registrationNumber;
            carCount++;
        }

        public double CalcTravelCost(double roadLenght, double fuelPrice)
        {
            return CalcCombustion(roadLenght) * fuelPrice;
        }

        private double CalcCombustion(double roadLenght)
        {
            return (AverageCombustion * roadLenght) / 100.0f;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.ToString());
        }
        
        public static void PrintCarCount()
        {
            Console.WriteLine($"Car count: {carCount}");
        }

        public override string ToString()
        {
            return $"Brand: {Brand}\nModel: {Model}\nDoor count: {DoorCount}\n" + 
                    $"Engine capacity: {EngineCapacity}\nAverage combustion: {AverageCombustion}\n";
        }
    }
}
