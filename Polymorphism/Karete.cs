using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Karete : Spor, IDovus
    {
        public string KusakRengi { get; set; }
        public string KuralDisiSaldiriSayisi()
        {
            return "5";
        }

        public override string KurallariVer()
        {
            return " puan kazanmak için rakibi yumruk, tekme ve atmalar kullanarak yenmek.";
        }

        public string RaundSayisi()
        {
            return"2";
        }

        public override int SureVer()
        {
           return 1;
        }
    }
}
