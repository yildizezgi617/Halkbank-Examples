using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _14_OOPConstructor.Models
{
    class Kedi
    {
       
        public Kedi()
        {
            Console.WriteLine("Bir kedi gordum sanki");
        }

        //public Kedi(string tur, string cinsiyet, int yasamSuresi, string renk, bool tuyluMu, string isim, string mensei) :this()
        //{
        //    this.Tur = tur;
        //    this.Renk = renk;
        //    this.Cinsiyet = cinsiyet;
        //    this.YasamSuresi = yasamSuresi;
        //    this.Mensei = mensei;
        //    this.Ad = Ad;
        //    this.TuyluMu = tuyluMu;


        //}





  //      List<string> turler = new List<string> { "Sokak Kedisi", "Tur", "Ingiliz" };

  //      private string _tur;

		//public string Tur
		//{
  //          get 
  //          { 
  //              return _tur;
  //          }
  //          set
  //          {
  //              if (turler.Contains(value))
  //              {
  //                  _tur = value;
  //              }
  //              else
  //              {
  //                  Random rnd = new Random();
  //                  _tur = turler[rnd.Next(turler.Count)];
  //              }
  //          }
		//}




        //private string cinsiyet;
        //public string Cinsiyet { get; set; }

        //private bool _tuylumu;
        //public bool TuyluMu { get; set; }


        //private int _yasamsuresi;
        //public int YasamSuresi
        //{
        //    get { 
        //        return _yasamsuresi; 
        //    }
        //    set 
        //    {
        //        if (_yasamsuresi>=10)
        //        {
        //            _yasamsuresi = value;
        //        }
        //        else
        //        {
        //            throw new ArgumentException("yasam süresi en az 10 yil olmalıdır");
        //        }
               
        //    }
        //}



    //    List<string> renkler = new List<string> { "siyah", "beyaz", "sari" };

    //    private string _renk;

    //    public string Renk
    //    {
    //        get
    //        {
    //            return _renk;
    //        }
    //        set
    //        {
    //            if (renkler.Contains(value))
    //            {
    //                _renk =value;
    //            }
    //            else
    //            {

    //            }
    //        }
    //    }




    //    private string _ad;
    //    public string Ad
    //    {
    //        get
    //        {
    //            return _ad;
    //        }
    //        set
    //        {
    //            if (value.Length >= 2 && value.Length <= 25)
    //            {
    //                _ad = value;
    //            }
    //            else
    //            {
    //                throw new ArgumentException("en az 2 en çok 25 karakter giriniz");
    //            }
    //        }
    //    }






    //    List<string> menseiler = new List<string> { "Irak", "Mısır", "Turkiye" };

    //    private string _mensei;

    //    public string Mensei
    //    {
    //        get
    //        {
    //            return _mensei;
    //        }
    //        set
    //        {
    //            if (menseiler.Contains(value))
    //            {
    //                _mensei = value;
    //            }
    //            else
    //            {
    //                Random rnd = new Random();
    //                _mensei = menseiler[rnd.Next(turler.Count)];
    //            }
    //        }
    //    }
    }



}
