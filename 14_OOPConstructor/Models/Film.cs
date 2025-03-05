using _14_OOPConstructor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_OOPConstructor.Models
{
    class Film
    {


		//public Film(string filmadi, string yonetmen, int cikistarihi, double imdb, string konu, string kategori, decimal hasilat)
		//{

		//}





		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}

		private string _filmadi;

		public string FilmAdi
		{
			get
			{
				return _filmadi; 
			}
			set 
			{
				if (string.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Boş olmayan bir film adı veriniz");
				}
				if (value.Length>25)
				{
					throw new ArgumentException("25 karakterden daha kısa bir ad girin");
				}
				_filmadi = value;
			}
		}


		private string _yonetmenadi;

		public string YonetmenAdi
		{
			get { return _yonetmenadi; }
			set { _yonetmenadi = value; }
		}


		private int _cikistarihi;

		public int CikisTarihi
		{
			get { return _cikistarihi; }
			set
			{
				if (_cikistarihi<2025)
				{
                    _cikistarihi = value;
                }
				else
				{
					throw new ArgumentException("çıkış tarihi 2025den fazla olamaz.");
				}
			}
		}

			

		private string _konu;

		public string Konu
		{
			get { return _konu; }
			set { _konu = value; }
		}

		private string _kategori;

		public string Kategori
		{
			get { return _kategori; }
			set { _kategori = value; }
		}

		private decimal _hasilat;

		public decimal Hasilat
		{
			get { return _hasilat; }
			set { _hasilat = value; }
		}



		 3



	}
}
//  using _14_OOPConstructor.Models;
//using System;

//namespace _14_OOPConstructor
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
            
//            }

//            Console.WriteLine($"Film başarıyla oluşturuldu: {film.FilmAdi}, {film.Yonetmen}, {film.CikisYili}, {film.Imdb}, {film.Konu}, {film.Kategori}, {film.Hasilat}");
//        }
//    }
//}
