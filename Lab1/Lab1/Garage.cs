using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using zadanie1samochod;

namespace zadanie2garaz
{
    class Garage
    {
        // to jest stary c#, to bym pisala i do tego osobno metody dostepowe
        // private string adres;
        // private int pojemnosc;
        // private int liczbaSamochodow; 

        public string Address { get; set; }

        private int _capacity;

        public int Capacity
        {
            get { return _capacity; }
            set { _capacity = value; _cars = new Car[_capacity]; }
        }

        private Car[] _cars;
        private int _carCount = 0; // w garazu moze byc inna liczba samochodow

        //List<Samochod> samochodyLista = new List<Samochod>(); // Przykład z wykorzystaniem LIST

        public Garage()
        {
            Address = "nieznany";
            _capacity = 0;
            _cars = null;
        }

        public Garage(string adres_, int pojemnosc_)
        {
            Address = adres_;
            Capacity = pojemnosc_; //od razu tworze tablice   
        }

        public void WprowadzSamochod(Car car)
        {
            if (Capacity == _carCount)
            {
                Console.WriteLine("Garaz pelny");
            }
            else
            {
                _cars[_carCount] = car;
                _carCount++;

                //samochodyLista.Add(samochod);
                //liczbaSamochodow++;
            }
        }

        public Car WyprowadzSamochod()
        {
            if (_carCount <= 0)
            {
                Console.WriteLine("Nie ma co wyprowadzic");
                return null;
            }
            else
            {
                Car temp = _cars[_carCount - 1];

                _cars[_carCount - 1] = null;
                _carCount--;

                //Samochod temp2 = samochodyLista.Last();
                //samochodyLista.Remove(samochody.Last());


                return temp;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Adres: " + Address);
            //Console.WriteLine($"Adres: {Adres}"); alternatywa, ponoc lepsza
            Console.WriteLine("Pojemnosc: " + Capacity);

            for (int i = 0; i < _carCount - 1; i++)
            {
                _cars[i].WypiszInfo();
            }

            //foreach (Samochod samochod in samochodyLista)
            //{
            //    samochod.WypiszInfo();
            //}
        }

    }
}


