using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Futbol : Spor, ITopSporlari
    {
        public string HakemAdi { get; set; }
        public override string KurallariVer()
        {
            return "Taç atışı başın üzerinden, yüzü sahaya dönük şekilde ve her iki ayağının da çizgide ya da çizgi dışında yerle teması olacak şekilde kullanılır.";
        }

        public override int SureVer()
        {
            return 90;
        }

        public string TopAgirliginiVer()
        {
            return "0.200 g";
        }

        public string TopBoyutuVer()
        {
            return "10cm";
        }
    }
}
