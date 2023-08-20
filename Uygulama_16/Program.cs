using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üniversite Sınav Hesaplama Sistemi");

            Console.Write("Öğrencinin Adını Giriniz: ");
            string ad = Console.ReadLine();

            Console.Write("Öğrencinin Soyadını Giriniz: ");
            string soyad = Console.ReadLine();

            Ogrenci ogrenci = new Ogrenci(ad, soyad);

            Console.Write("Vize 1 Notunu Giriniz: ");
            ogrenci.Vize1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Vize 2 Notunu Giriniz: ");
            ogrenci.Vize2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Final Notunu Giriniz: ");
            ogrenci.Final = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            ogrenci.BilgileriYazdir();


            Console.ReadKey();
        }

        
    }

}