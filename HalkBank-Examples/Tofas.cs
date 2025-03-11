using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkBank_Examples
{
    class Tofas:Araba,IArabaYetenegi
    {
        public string Egzoz { get; set; }
        public string ArkaYazisi { get; set; }

        public string MuzikCal()
        {
            return"mavi mavi";
        }

        public override string VitesArttır()             //abstract methoddu impl etmek zorundayız ve override etmek zorundayız
        {
            return "Ayakla vites arttirildi";
        }

        
    }
}
