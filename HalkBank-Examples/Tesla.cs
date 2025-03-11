using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkBank_Examples
{
    class Tesla : Araba, IElektrikliAracYetenegi,IArabaYetenegi
    {
        public int PilOmru { get; set; }
        public int PilKapasitesi { get; set; }
        public bool OtomatikSurus { get; set; }

      

        public override string VitesArttır()
        {
            return "Otomatik pilot vitesi arttirdi";
        }
        override public string AraciCalistir()  //aracı calıştırma biçimi değiştiği için override edildi
        {
            return "Kartla Araç Çalişti";
        }

        public int SarjDolumSuresi()
        {
            throw new NotImplementedException();
        }

        public double BataryaSicakliğiVer()
        {
            throw new NotImplementedException();
        }

        public string MuzikCal()
        {
            return "Onun arabası var";
        }
    }
}
