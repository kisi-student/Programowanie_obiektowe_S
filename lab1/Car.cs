using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    
    class Car
    {
        
            private string brand;
            private string model;
            private int doorCount;
            private int engVolue;
            private double averageConsuption;
            private static int carsNumber = 0;

            public Car()
            {
                brand = "unknow";
                model = "unknow";
                doorCount = 0;
                engVolue = 0;
                averageConsuption = 0.0;
                carsNumber++;
            }
            public Car(string brand_, string model_, int doorCount_, int engVolue_, double avcon_)
            {
                brand = brand_;
                model = model_;
                doorCount = doorCount_;
                engVolue = engVolue_;
                averageConsuption = avcon_;
                carsNumber++;
            }

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

            public int EngVolue
            {
                get { return engVolue; }
                set { engVolue = value; }
            }

            public double AverageConsuption
            {
                get { return averageConsuption; }
                set { averageConsuption = value; }
            }


            public double CountConsuption(double wayLength)
            {
                return (averageConsuption * wayLength) / 100.0;
            }

            public double CountCostOfDrive(double wayLength, double fuelCost)
            {
                return CountConsuption(wayLength) * fuelCost;
            }

            public void ShowInfo()
            {
                Console.WriteLine("Brand: " + brand);
                Console.WriteLine("Model: " + model);
                Console.WriteLine("Door Count: " + doorCount);
                Console.WriteLine("Engine volue: " + engVolue);
                Console.WriteLine("Average Consuption: " + averageConsuption);
            }

            public static void ShowNumberOfCars()
            {
                Console.WriteLine("Number of cars: " + carsNumber);
            }

        
    }
}
