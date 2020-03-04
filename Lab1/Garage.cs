using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Garage
    {
        private string adres;
        private int capacity;
        private int carsNumber = 0;
        private Car[] cars;

        public Garage()
        {
            adres = "unknown";
            capacity = 0;
            cars = null;
        }

        public Garage(string adres, int capacity)
        {
            this.adres = adres;
            Capacity = capacity;
        }

        public void LeadCarIn(Car car)
        {
            if(carsNumber == capacity)
            {
                Console.WriteLine("Garaz pelny!");
            }
            else
            {
                cars[carsNumber++] = car;
            }
        }
        public Car LeadCarOut()
        {
            if (carsNumber == 0)
            {
                Console.WriteLine("Garaz pusty!");
                return null;
            }
            Car res = cars[--carsNumber];
            cars[carsNumber] = null;
            return res;
        }

        public string Adres { get => adres; set => adres = value; }
        public int Capacity { 
            get => capacity;
            set { 
                capacity = value;
                cars = new Car[capacity];
            } 
        }

        public override string ToString()
        {
            string res = $"Garaz( adres:{adres}, pojemnosc:{capacity}, ilosc garaz. sam.:{carsNumber},\r\n Samochody:\r\n";
            foreach (Car x in cars)
                res += " "+x+"\r\n";
            res += ")";
            return res;
        }
        
        public void PrintInfo()
        {
            Console.WriteLine(this);
        }
    }
}
