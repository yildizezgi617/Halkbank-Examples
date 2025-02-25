using System.Xml.Schema;

namespace _01_Intro
{
    internal class Program
    {
        /// <summary>
        /// Metot bilgisi
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Console.WriteLine("Merhaba Bilgeadam");

            // Degiskenler 

            // Tek satirlik yorum
            /*
             * sad
             * sad
             * sad
             * asd
             */

            //Console.WriteLine("Int min value : " + int.MinValue);
            //Console.WriteLine("Int max value : " + int.MaxValue);
            //Console.WriteLine("byte min value : " + byte.MinValue);
            //Console.WriteLine("byte max value : " + byte.MaxValue);

            // degiskenTipi degiskenAdi = deger;
            int sayi = 5;
            int Sayi = 55;

            int _tam_Sayi_ = 60;

            int degisken = 5;

            //int int

            // Ondalikli veri tipleri
            float pi = 3.14f;
            double ondalikliSayi = 10.5;
            decimal maas = 145644456.54545m;

            // Metinsel veri tipleri
            char karakter = 'B';
            string metin2 = "Cumle";

            // Mantiksal Veri Tipi
            bool dogruMu = false;


            // Degisken atamalari
            //byte yas = 18;
            //Console.WriteLine(yas);
            //yas = 19;
            //Console.WriteLine(  yas);

            string ad, soyad = "Şahin";
            ad = "Hakan";

            // Marka, model, fiyat, hasarliMi, yas,yil, sinifini degiskende saklayarak ekranda tek bir cumle olarak yazdiriniz.    
            string marka = "Renault";
            string model = "Toros";
            decimal fiyat = 100000.5m;
            bool hasarliMi = false;
            byte yas = 5;
            int yil = 2020;
            char sinif = 'C';

            string cumle = $"{marka}-{model}-{fiyat}-{hasarliMi}-{yas}-{yil}-{sinif}";

            Console.WriteLine(cumle);

            Console.WriteLine("Marka : {0}-Model {1}-Fiyat : {2}-Hasar Durumu : {3}-Yas : {4}-Yil : {5}", marka, model, fiyat, hasarliMi, yas, yil);










        }
    }
}