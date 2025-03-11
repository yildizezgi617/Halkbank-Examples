using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkBank_Examples
{
    class I7BMW : Araba,IElektrikliAracYetenegi,IArabaYetenegi
    {
        public string KoltukIsitma { get; set; }

      

    
        public override string VitesArttır()
        {
            throw new NotImplementedException();
        }

        public int SarjDolumSuresi()
        {
            throw new NotImplementedException();
        }

        public double BataryaSicakliğiVer()
        {
            throw new NotImplementedException();
        }

        public string MuzikCal()   //Interfaceden gelen method. otomatik impl edilmek zorunda ve içi doldurulmak zorunda
        {
            return "kdjfjlşd";
        }
    }
}
