using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Abstraction.Ornek
{
    class Papatya
    {
        public int  YaprakSayisi { get; set; }
        public string YaprakSekli { get; set; }


        public override string BilgiVer()
        {
            string metin = $"{Id},{YasamSuresi},{YaprakSayisi},{YaprakSekli}";
            return metin;
        }
    }
}
