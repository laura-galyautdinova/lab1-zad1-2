using System;

namespace SamochodApp
{
    class Samochod
    {
        // Prywatne pola klasy
        private string marka;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;

        // Konstruktor domyślny
        public Samochod()
        {
            marka = "nieznana";
            model = "nieznany";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0;
            srednieSpalanie = 0.0;
        }

        // Konstruktor z parametrami
        public Samochod(string marka_, string model_, int iloscDrzwi_, int pojemnoscSilnika_, double srednieSpalanie_)
        {
            marka = marka_;
            model = model_;
            iloscDrzwi = iloscDrzwi_;
            pojemnoscSilnika = pojemnoscSilnika_;
            srednieSpalanie = srednieSpalanie_;
        }

        // Metoda wypisująca informacje o samochodzie
        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Ilość drzwi: " + iloscDrzwi);
            Console.WriteLine("Pojemność silnika: " + pojemnoscSilnika);
            Console.WriteLine("Średnie spalanie: " + srednieSpalanie);
        }
    }
}
