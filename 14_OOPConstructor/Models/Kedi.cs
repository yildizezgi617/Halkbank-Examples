using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPConstructor.Models
{
    internal class Kedi
    {
        private string cinsiyet;
        public Kedi()

        {
            Console.WriteLine("Bir kedi gördüm sanki");

        }
        public Kedi(string tur, string cinsiyet, int yasamSuresi, string renk, bool tuyluMu, string isim, string mensei) : this()
        {
            this.Turu = tur;
            this.Renk = renk;
            this.Cinsiyet = cinsiyet;
            this.Mensei = mensei;
            this.YasamSuresi = yasamSuresi;
            this.TuyluMu = tuyluMu;
            this.Ad = isim;

        }
        private string ad;

        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 25)
                    ad = value;
                else
                    throw new ArgumentException("En az 2 en fazla 25 karakter arasında girin.");

            }
        }

        List<string> turler = new List<string>() { "Sokak Kedisi", "İngiliz", "İskoç", "İran", "Mısır" };
        private string _turu;
        //public string Isim { get; set; }
        public bool TuyluMu { get; set; }
        public string Turu
        {
            get { return _turu; }
            set
            {
                if (turler.Contains(value))
                    _turu = value;
                else
                {
                    Random rnd = new Random();
                    _turu = turler[rnd.Next(turler.Count)];
                }

            }
        }
        public string Cinsiyet { get; set; }

        List<string> renkler = new List<string>() { "beyaz", "siyah", "kahverengi", "sarı", "gri" };
        private string _renk;
        public string Renk
        {
            get { return _renk; }
            set
            {
                if (renkler.Contains(value))
                    _renk = value;
                else
                {
                    Random rnd = new Random();
                    _renk = renkler[rnd.Next(renkler.Count)];
                }

            }

        }

        private int _yasamSuresi;

        public int YasamSuresi
        {
            get { return _yasamSuresi; }
            set
            {
                if (value >= 10)
                    _yasamSuresi = value;
                else
                    throw new ArgumentException("Yasam Suresi en az 10 yıl olmalıdır.");
            }
        }
        List<string> ulkeler = new List<string>
        {
            "Turkiye",
            "Samsun",
            "Trabzon",
            "Somali",
            "Çin",
            "Monaco",
            "Bangladeş"
        };
        private string _mensei;

        public string Mensei
        {
            get
            {
                return _mensei;
            }
            set
            {
                if (ulkeler.Contains(value))
                    _mensei = value;
                else
                {
                    Random random = new Random();
                    _mensei = ulkeler[random.Next(ulkeler.Count)];

                }

            }
        }


    }
}
