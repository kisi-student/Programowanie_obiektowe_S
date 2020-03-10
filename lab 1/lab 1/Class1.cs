using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class Samochod
    {
      
        public string Marka { get; set; }
        public string Model{ get; set; }
        public int IloscDrzwi { get; set; }
        public int PojemnoscSilnika { get; set; }
        public double SrednieSpalanie { get; set; }
        private static int IloscSamochodow = 0; 

        public Samochod()
        {
            Marka = "nieznana";
            Model = "nieznany";
            IloscDrzwi = 0;
            PojemnoscSilnika = 0;
            SrednieSpalanie = 0.0;
            IloscSamochodow = IloscSamochodow + 1;
        }

        public Samochod(string marka_,string model_,int iloscDrzwi_,int pojemnoscSilkika_,
            double srednieSpalanie_)
        {
            Marka = marka_;
            Model = model_;
            IloscDrzwi = iloscDrzwi_;
            PojemnoscSilnika = pojemnoscSilkika_;
            SrednieSpalanie = srednieSpalanie_;
            IloscSamochodow = IloscSamochodow + 1;
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (SrednieSpalanie * dlugoscTrasy) / 100;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy,double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + Marka);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Ilosc Drzwi: " + IloscDrzwi);
            Console.WriteLine("Pojemnosc Silnika: " + PojemnoscSilnika);
            Console.WriteLine("Srednie Spalanie: " + SrednieSpalanie);
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine(IloscSamochodow);
        }
    }

}
