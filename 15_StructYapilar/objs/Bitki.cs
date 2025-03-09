using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_StructYapilar
{
    public struct Bitki
    {
        private string ad;
        private string _turu;

        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                if (ad.Length >= 3 && ad.Length <= 50)
                    ad = value;
                else if (ad.Length < 3)
                    ad = value.PadLeft(3, '*');
                else
                    ad = value.Substring(50);


            }
        }

        public string Tur
        {
            get { return _turu; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Turu bos gecilemez!");
                if (value.Length > 15)
                    throw new ArgumentException("Tur 15 karakterden fazla olamaz!");
                _turu = value;
            }
        }

        private int _omur;

        public int Omur
        {
            get
            {
                return _omur;
            }
            set
            {
                if (value > 54000)
                {

                    _omur = 54000;
                }

                else
                    _omur = value;
            }
        }

        private int _boy;

        public int Boy
        {
            get { return _boy; }
            set
            {
                if (value < 0)
                {
                    Random random = new Random();
                    value = random.Next(0, 100);
                }
                _boy = value;


            }
        }

        private string _cinsiyet;

        public string Cinsiyet
        {
            get { return _cinsiyet; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    var list = new List<string>()
                    {
                        "dişi",
                        "erkek"
                    };

                    value = list[(new Random().Next(0, 2))];
                }

                _cinsiyet = value;
            }
        }

        private string _leafType;
        public string LeafType
        {
            get => _leafType;
            set
            {


                if (value.Length < 2)
                    throw new ArgumentException("Min allowed length : 2");
                _leafType = value;

            }
        }
    }
}
