﻿using System;

namespace SamochodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testowanie klasy Samochod
            Samochod s1 = new Samochod("Fiat", "126p", 2, 650, 6.0);
            Samochod s2 = new Samochod("Syrena", "105", 2, 800, 7.6);

            // Testowanie klasy Garaz
            Garaz g1 = new Garaz();
            g1.Adres = "ul. Garażowa 1";
            g1.Pojemnosc = 1;

            Garaz g2 = new Garaz("ul. Garażowa 2", 2);

            g1.WprowadzSamochod(s1);
            g1.WypiszInfo();

            g1.WprowadzSamochod(s2); // Garaż jest pełny!

            g2.WprowadzSamochod(s2);
            g2.WprowadzSamochod(s1);
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WypiszInfo();

            g2.WyprowadzSamochod();
            g2.WyprowadzSamochod(); // Garaż jest pusty!

            Console.ReadKey();
        }
    }
}
