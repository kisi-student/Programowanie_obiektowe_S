using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public class Car
        {
            private string _brand;
            private string _model;
            private int _doorCount;
            private float _engineVolume;
            private float _avgConsumption;
            public static int _carsCount;

            public string Brand { get; set; }
            public string Model { get; set; }
            public int DoorCount { get; set; }
            public float EngineVolume { get; set; }
            public float AvgConsumption { get; set; }

            public Car()
            {
                _brand = "none";
                _model = "none";
                _doorCount = 0;
                _engineVolume = 0.0F;
                _avgConsumption = 0.0F;
                _carsCount += 1;
            }

            public Car(string brand, string model, int doorCount, float engineVolume, float avgConsumption)
            {
                _brand = brand;
                _model = model;
                _doorCount = doorCount;
                _engineVolume = engineVolume;
                _avgConsumption = avgConsumption;
                _carsCount += 1;
            }

            public float AvgConsumptionOnTrack(float distance)
            {
                return distance * _avgConsumption * 100;
            }

            
        }
    }
}
