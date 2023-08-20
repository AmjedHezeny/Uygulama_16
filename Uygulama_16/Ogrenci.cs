using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_16
{
    internal class Ogrenci
    {
        public string Ad;
        public string Soyad;
        public int Vize1;
        public int Vize2;
        public int Final;

        public Ogrenci(string ad, string soyad)
        {
            Ad = ad;
            Soyad = soyad;
        }

        public double OrtalamaHesapla()
        {
            return (Vize1 * 0.3) + (Vize2 * 0.3) + (Final * 0.4);
        }

        public void BilgileriYazdir()
        {
            Console.WriteLine("Öğrenci Bilgileri:");
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Soyad: " + Soyad);
            Console.WriteLine("Vize 1: " + Vize1);
            Console.WriteLine("Vize 2: " + Vize2);
            Console.WriteLine("Final: " + Final);
            Console.WriteLine("Ortalama: " + OrtalamaHesapla());

            double ortalama = OrtalamaHesapla();
            if (ortalama >= 50)
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Durum: Geçti");
                Console.WriteLine("***********************");

            }
            else
            {
                Console.WriteLine("***********************");
                Console.WriteLine("Durum: Kaldı");
                Console.WriteLine("***********************");
            }

        }
    }
}