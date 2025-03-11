using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class BuzHokeyi : Spor
    {
        public string BuzKalinligi { get; set; }
        public override string KurallariVer()
        {
            return " pakının çapı 7,5 santimetre ve kalınlığı 2,5 santimetre";
        }

        public override int SureVer()
        {
            return 60;
        }
    }
}
