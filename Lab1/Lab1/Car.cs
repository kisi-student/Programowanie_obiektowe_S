using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int CapacityEngine { get; set; }
        public double AverageCombustion { get; set; }

        static int carCount=0;

        public Car()
        {
            Brand = "none";
            Model = "none";
            CapacityEngine = 0;
            AverageCombustion = 0.0;

            carCount++; //przy kazdym wywolaniu konstruktora zwiekszamy licznik samochodow

        }
        public Car(string brand, string model, int capacityEngine, double averageCombustion)
        {
            Brand = brand;
            Model = model;
            CapacityEngine = capacityEngine;
            AverageCombustion = averageCombustion;

            carCount++;
        }

       private double CalculateCombustion(double lengthRoute)
        {

        }
    }
}
