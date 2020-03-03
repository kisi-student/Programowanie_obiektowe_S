using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Garage
    {
        private string adres;
        private int capasity;
        private int carCounts = 0;
        private Car[] cars;

        public Garage()
        {
            adres = "unknow";
            capasity = 0;
            cars = null;
        }

        public Garage(string adres_,int capasity_)
        {
            adres = adres_;
            capasity = capasity_;
            cars = new Car[capasity_];
        }



        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }
        public int Capasity
        {
            get { return capasity; }
            set
            {
                capasity = value;
                cars = new Car[capasity];
            }
        }

        public void GetCar(Car c)
        {
            if (capasity < 3)
                cars[carCounts] = c;
            else
                Console.WriteLine("Garage is full");

            carCounts++;
        }

        public void PopCar()
        {
            if (carCounts >= 0)
                cars[carCounts] = null;
            else
                Console.WriteLine("Garage is empty");

            carCounts--;
        }

        public void Details()
        {

        }

    }
}
