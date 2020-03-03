using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        public class Car
        {
            private string mark;
            private string model;
            private int doorCount;
            private int engineVolume;
            private double avgCounsument;
            private int carCount=0;
            public Car()
            {
                mark = ("---");
                model = ("---");
                doorCount = 0;
                engineVolume = 0;
                avgCounsument = 0;
                carCount++;
            }
            public string Mark
            {
                get { return mark; }
                set { mark = value; }
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

            public double AvgCounsument
            {
                get { return avgCounsument; }
                set { avgCounsument = value; }
            }
            private double CalculationConsument(double LongRoad)
            {
                double counsument;
                counsument = (avgCounsument * LongRoad) / 100;
                return counsument;
            } 
            public 

        }
        static void Main(string[] args)
        {
        }
    }
}
