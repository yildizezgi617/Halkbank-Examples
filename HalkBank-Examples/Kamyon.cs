using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkBank_Examples
{
    class Kamyon:Araba,IArabaYetenegi
    {
        public double KasaHacmi { get; set; }
        public double KasaTipi { get; set; }

        public string MuzikCal()
        {
            return "kara gumruk yanıyor";
        }

        public override string VitesArttır()    //abstract methottu override ve impl edilmek zorunda
        {
            return "Manuel arttirdik";
        }
            //virtual methodu override etmiyoruz çünkü ezmemize gerek yok zaten bu methodu kullanabiliyoruz.Kamyon da anahtarla çalıştırılıyor.. istenirse değiştirilebilir. impl edilmek zorunda degil cunku otomatik o ozellige sahip
      
    }
}
