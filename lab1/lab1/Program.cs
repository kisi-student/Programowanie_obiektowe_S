using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Car
    {
        private string brand; // marka
        private string model;
        private int number_of_doors;
        private int capacity; //pojemnosc silnika
        private int afc; // srednie spalanie

        public Car()
        {
            brand = "null";
            model = "null";
            number_of_doors = 0;
            capacity = 0;
            afc = 0;
        }
        public Car(string _brand, string _model, int _nod, int _capacity, int _afc)
        {
            brand = _brand;
            model = _model;
            number_of_doors = _nod;
            capacity = _capacity;
            afc = _afc;
        }
    }
}
