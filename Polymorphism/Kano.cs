using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Kano : Spor, IYuzus 
    {
        public string  TekneTipi { get; set; }
        public override string KurallariVer()
        {
            return " Can yeleği gibi kişisel güvenlik ekipmanları her zaman giyilmelidir.";
        }

        public int PistinOrtalamaKulaclıkSayisi()
        {
            return 50;
        }

        public override int SureVer()
        {
            return 60;
        }

        public string YuzusSekli()
        {
            return "Kurekle";
        }
    }
}
