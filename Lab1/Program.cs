using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{
    public class Samochod
    {
        private string marka;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;
        private static int liczbaSamochodow = 0;
        private string nrRejestracyjny;

        public Samochod()
        {
            marka = ("--");
            model = ("--");
            iloscDrzwi = 0;
            pojemnoscSilnika = 0;
            srednieSpalanie = 0;
            liczbaSamochodow++;
            nrRejestracyjny = ("--");
        }

        public Samochod(string marka_, string model_, int drzwi, int silnik, double spalanie, string nrRej)
        {
            marka = marka_;
            model = model_;
            iloscDrzwi = drzwi;
            pojemnoscSilnika = silnik;
            srednieSpalanie = spalanie;
            liczbaSamochodow++;
            nrRejestracyjny = nrRej;
        }

        public string Marka { get; set; }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }

        public int PojemnoscSilnika
        {
            get { return pojemnoscSilnika; }
            set { pojemnoscSilnika = value; }
        }

        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        public string NrRejestracyjny { get; set; }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (srednieSpalanie * dlugoscTrasy) / 100;            
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {           
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Ilość Drzwi: " + iloscDrzwi);
            Console.WriteLine("Pojemność Silnika: " + pojemnoscSilnika);
            Console.WriteLine("Średnie Spalanie: " + srednieSpalanie);
            Console.WriteLine("Numer Rejestracyjny: " + nrRejestracyjny);
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine("Ilość samochodów: " + liczbaSamochodow);
        }

    }

    public class Garaz
    {
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[] samochody;

        public string Adres
        {
            get { return adres; }
            set { adres = value; }
        }

        public int Pojemnosc
        {
            get { return pojemnosc; }
            set
            {
                pojemnosc = value;
                samochody = new Samochod[pojemnosc];
            }
        }

        public Garaz()
        {
            adres = ("--");
            pojemnosc = 0;
            samochody = new Samochod[0];
        }

        public Garaz(string adres_, int pojemnosc_)
        {
            adres = adres_;
            pojemnosc = pojemnosc_;
            samochody = new Samochod[pojemnosc];
        }

        public void WprowadzSamochod(Samochod samochod)
        {
            if (liczbaSamochodow >= pojemnosc)
            {
                Console.WriteLine("Garaż jest przepełniony");
                Console.ReadKey();
            }
            else
            {
                samochody[liczbaSamochodow] = samochod;
                liczbaSamochodow++;
            }
        }


        public Samochod WyprowadzSamochod()
        {
            Samochod auto;
            if (liczbaSamochodow == 0)
            {
                Console.WriteLine("Garaż jest pusty");
                Console.ReadKey();
                return null;
            }
            else
            {
                auto = samochody[liczbaSamochodow - 1];
                samochody[liczbaSamochodow - 1] = null;
                liczbaSamochodow--;
                return auto;
            }
        }

        public void WypiszInfo()
        {
            for (int i = 0; i < liczbaSamochodow; ++i)
            {
                Console.WriteLine("Pojazd " + i);
                samochody[i].WypiszInfo();
                Console.WriteLine("-------------");
            }
        }

    }

    public class Osoba
    {
        private string imie;
        private string nazwisko;
        private string adresZamieszkania;
        private int iloscSamochodow = 0;
        private string[] rejestracje;

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public string AdresZamieszkania { get; set; }

        public Osoba()
        {
            imie = ("--");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0, "SCZ90WS");
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6, "SK2137G");

            Garaz g1 = new Garaz();
            g1.Adres = "ul. Garażowa 1";
            g1.Pojemnosc = 1;

            Garaz g2 = new Garaz("ul. Garażowa 2", 2);

            g1.WprowadzSamochod(s1);
            g1.WypiszInfo();
            g1.WprowadzSamochod(s2);

            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WyprowadzSamochod();

            Console.ReadKey();
        }
    }
}
