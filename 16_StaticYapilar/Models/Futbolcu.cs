using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _16_StaticYapilar.Models
{
    // * Telefon 11 haneli olana kadar giris yapsin
    internal class Futbolcu
    {

        static Futbolcu()
        {
            Console.WriteLine("Futbolcu aktif.");
        }
        public Futbolcu()
        {
            Console.WriteLine("Oluşum başladı.");
        }

        //private static bool isFirstInstanceCreated;
        //public Futbolcu(out string message)
        //{
        //    if (!isFirstInstanceCreated)
        //    {
        //        isFirstInstanceCreated = true;
        //        message = "Futbolcu aktif. Oluşum başladı";
        //    }
        //    else
        //        message = "Oluşum başladı";

        //}


        private string telefon;

        public string TelefonNumarası
        {
            get { return telefon; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("telefon boş geçilemez");
                else if (value.Length != 11)
                {
                    throw new ArgumentException("telefo 11 haneli olmalı");
                }
                telefon = value;


            }
        }
        private DateTime dogumTarihi;

        public DateTime DogumTarihi
        {
            get { return dogumTarihi; }
            set
            {
                int yas = DateTime.Now.Year - value.Year;
                if (yas < 18)
                {
                    dogumTarihi = new DateTime(value.Year - (18 - yas), value.Month, value.Day);
                }
                else if (yas > 35)
                {
                    dogumTarihi = new DateTime(value.Year + (yas - 35), value.Month, value.Day);
                }
                else if (value == null)
                {
                    throw new Exception("Boş geçilemez");
                }
                else
                {
                    dogumTarihi = value;
                }

            }
        }

        private decimal maas;

        public decimal Maas
        {
            get { return maas; }
            set
            {
                decimal asgari = 22000;
                if (value < 22000)
                    maas = asgari;
                else
                    maas = value;
            }
        }

        private int _bonservis;

        public int Bonservis
        {
            get
            {
                return _bonservis;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Bonservis 0 ın altında olamaz");
                else if (value > 250)
                    _bonservis = 250;
                else
                    _bonservis = value;
            }
        }

        List<string> takimlar = new List<string>() { "Fenerbahçe", "Beşiktaş", "Göztepe", "Samsun", "Karagümrük" };
        private string _takim;

        public string Takim
        {
            get { return _takim; }
            set
            {
                if (takimlar.Contains(value))
                {
                    _takim = value;
                }
                else
                {
                    Random random = new Random();
                    _takim = takimlar[random.Next(takimlar.Count())];
                }
            }
        }

        // * FormaNumarasi [1,100) arasinda olmalidir.

        private int _formaNumarasi;

        public int FormaNumarasi
        {
            get { return _formaNumarasi; }
            set
            {
                if (value < 1 || value > 100)
                {
                    Random rand = new Random();
                    value = rand.Next(1, 100);
                }
                _formaNumarasi = value;
            }
        }




    }
}
