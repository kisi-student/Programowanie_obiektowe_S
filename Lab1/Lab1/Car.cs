using System;

namespace zadanie1samochod
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int DoorCount { get; set; }
        public int EngineCapacity { get; set; }
        public double Combustion { get; set; }

        public string RegistrationNumber { get; set; }

        public static int iloscSamochodow = 0; //zwykly int

        //private double srednieSpalanie; stary sposob, ale korzystany na pcz

        //public double Spalanie //wlasciwosc do pola srednieSpalanie
        //{
        //    get { return srednieSpalanie; }
        //    set { srednieSpalanie = value; }
        //}

        public Car()
        {
            Brand = "nieznana";
            Model = "nieznany";
            DoorCount = 0;
            EngineCapacity = 0;
            Combustion = 0.0;
            iloscSamochodow++;
        }

        public Car(string brand_, string model_, int doorCount_, int engineCapacity_, double avgCombustion_)
        {
            Brand = brand_;
            Model = model_;
            DoorCount = doorCount_;
            EngineCapacity = engineCapacity_;
            Combustion = avgCombustion_;
            iloscSamochodow++;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            //double spalanie;
            //spalanie = (Spalanie * dlugoscTrasy) / 100.0;
            // return spalanie;
            return (Combustion * dlugoscTrasy) / 100.0f;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }

        //public double ObliczKosztPrzejazdu2(double dlugoscTrasy, double cenaPaliwa) => dlugoscTrasy * cenaPaliwa; 

        public void WypiszInfo()
        {
            //Console.WriteLine("Marka: {0} {1}", Marka, Model);
            // Console.WriteLine($"Marka: {Marka}"); nowsza metoda

            Console.WriteLine("Marka: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Ilosc drzwi: " + DoorCount);
            Console.WriteLine("Pojemnosc silnika: " + EngineCapacity);
            Console.WriteLine("Spalanie: " + Combustion);
            Console.WriteLine();
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine(iloscSamochodow);
        }
    }
}
