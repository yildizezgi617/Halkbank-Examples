using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class KickBox : Spor, IDovus
    {
        public int MyProperty { get; set; }
        public string KuralDisiSaldiriSayisi()
        {
            return "8";
        }

        public override string KurallariVer()
        {
            return "Sporcu rakibine, her raunt en az altı tekme atmak zorundadır.";
        }

        public string RaundSayisi()
        {
            return "3";
        }

        public override int SureVer()
        {
            return 1;
        }
    }
}
