using System;

namespace Lab1
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int DoorCount { get; set; }
        public int EngineCapacity { get; set; }
        public double AverageCombustion { get; set; }

        private static int carCount = 0;

        public Car()
        {
            Brand = "none";
            Model = "none";
            DoorCount = 0;
            EngineCapacity = 0;
            AverageCombustion = 0.0f;

            carCount++;
        }

        public Car(string brand, string model, int doorCount, int engineCapactiy, double averageCombustion)
        {
            Brand = brand;
            Model = model;
            DoorCount = doorCount;
            EngineCapacity = engineCapactiy;
            AverageCombustion = averageCombustion;

            carCount++;
        }

        public double CalcTravelCost(double roadLenght, double fuelPrice)
        {
            return CalcCombustion(roadLenght) * fuelPrice;
        }

        public void PrintInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return $"Brand: {Brand}\nModel: {Model}\nDoor count: {DoorCount}\n" + 
                    $"Engine capacity: {EngineCapacity}\nAverage combustion: {AverageCombustion}";
        }

        private double CalcCombustion(double roadLenght)
        {
            return (AverageCombustion * roadLenght) / 100.0f;
        }

        public static void PrintCarCount()
        {
            Console.WriteLine($"Car count: {carCount}");
        }
    }
}
