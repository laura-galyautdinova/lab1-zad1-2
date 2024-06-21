using System;

namespace SamochodApp
{
    class Garaz
    {
        // Prywatne pola klasy
        private string adres;
        private int pojemnosc;
        private int liczbaSamochodow = 0;
        private Samochod[]? samochody;

        // Właściwości dostępowe do pól
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

        // Konstruktor domyślny
        public Garaz()
        {
            adres = "nieznana";
            pojemnosc = 0;
            samochody = Array.Empty<Samochod>();
        }

        // Konstruktor z parametrami
        public Garaz(string adres_, int pojemnosc_)
        {
            adres = adres_;
            pojemnosc = pojemnosc_;
            samochody = new Samochod[pojemnosc];
        }

        // Metoda dodająca samochód do garażu
        public void WprowadzSamochod(Samochod samochod)
        {
            if (liczbaSamochodow >= pojemnosc)
            {
                Console.WriteLine("Garaż jest pełny!");
            }
            else
            {
                samochody![liczbaSamochodow] = samochod;
                liczbaSamochodow++;
            }
        }

        // Metoda usuwająca ostatnio dodany samochód z garażu
        public Samochod? WyprowadzSamochod()
        {
            if (liczbaSamochodow == 0)
            {
                Console.WriteLine("Garaż jest pusty!");
                return null;
            }
            else
            {
                liczbaSamochodow--;
                Samochod samochod = samochody![liczbaSamochodow];
                samochody[liczbaSamochodow] = null!;
                return samochod;
            }
        }

        // Metoda wypisująca informacje o garażu i samochodach w nim przechowywanych
        public void WypiszInfo()
        {
            Console.WriteLine("Adres: " + adres);
            Console.WriteLine("Pojemność: " + pojemnosc);
            Console.WriteLine("Liczba samochodów: " + liczbaSamochodow);
            for (int i = 0; i < liczbaSamochodow; i++)
            {
                samochody![i].WypiszInfo();
            }
        }
    }
}
