using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Car
    {
        private string marka;
        private string model;
        private int doorNumber;
        private double engineCapacity;
        private double avgPetrolUse;
        public static int carNumber = 0;

        public Car()
        {
            carNumber++;
        }

        public Car(string marka, string model, int doorNumber, double engineCapacity, double avgPetrolUse)
        {
            carNumber++;
            this.marka = marka;
            this.model = model;
            this.doorNumber = doorNumber;
            this.engineCapacity = engineCapacity;
            this.avgPetrolUse = avgPetrolUse;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int DoorNumber { get => doorNumber; set => doorNumber = value; }
        public double EngineCapacity { get => engineCapacity; set => engineCapacity = value; }
        public double AvgPetrolUse { get => avgPetrolUse; set => avgPetrolUse = value; }

        public override string ToString()
        {
            return $"Auto( marka:{marka}, model:{model}, l.drzwi:{doorNumber}, poj. silnika:{engineCapacity}, sr. uz. paliwa:{avgPetrolUse}";
        }

    }
}
