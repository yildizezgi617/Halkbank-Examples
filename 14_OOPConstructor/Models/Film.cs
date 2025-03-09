using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPConstructor.Models
{
    internal class Film
    {
        private string _filmAdi;
        private double _rating;
        private static int idSayac = 1;
        public Film(string filmAdi, double rating, DateTime cikisTarihi, string konu, string kategori, decimal hasilat)
        {
            FilmAdi = filmAdi;
            Rating = rating;
            CikisTarihi = cikisTarihi;
            Konu = konu;
            Kategori = kategori;
            Hasilat = hasilat;
            Id = idSayac++;
        }
        public int Id { get; private set; }
        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("Düzgün gir(0 ile 10 arasında bir değer giriniz).");
                }
                _rating = value;
            }
        }


        public string FilmAdi
        {
            get { return _filmAdi; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(" Girilen girdi null veya empty olamaz");
                }
                if (value.Length > 25)
                    throw new Exception("Girilen karakter 25 den uzun olamaz");

                _filmAdi = value;
            }
        }

        private DateTime cikisTarihi;

        public DateTime CikisTarihi
        {
            get { return cikisTarihi; }
            set
            {
                if (value > DateTime.Now)
                {
                    value = DateTime.Now;
                }
                cikisTarihi = value;
            }
        }

        private string konu;

        public string Konu
        {
            get { return konu; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Filmin konusu boş geçilemez. Lütfen geçerli bir konu giriniz.");
                else if (value.Length < 0 || value.Length > 200)
                    throw new ArgumentNullException("konu 0-200 karakter arasında olmalıdır.");

                konu = value;
            }
        }

        private string _kategori;

        public string Kategori
        {
            get { return _kategori; }
            set
            {

                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Kategori alanı boş bırakılamaz");
                if (value.Length < 3 || value.Length > 25)
                    throw new ArgumentNullException("KATEGORİ 3 İLE 25 ARASINDA oLMALIDIR");
                _kategori = value;

            }
        }


        private decimal _hasilat;

        public decimal Hasilat
        {
            get { return _hasilat; }
            set
            {
                if (value > 1000000000)
                {
                    value = 1000000000;
                }
                else if (value < 0) value = 0;
                _hasilat = value;
            }
        }
    }
}
