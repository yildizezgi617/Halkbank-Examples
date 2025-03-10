using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Abstraction.Models
{
    class Metin2 : Oyun
    {
        static int id = 0;
        public Metin2()
        {
            Id = ++id;

           
        }
        public List<string> Karakterler { get; set; }
        public List<string> Bolumler { get; set; }
        public List<string> Nesneler { get; set; }
        public List<string> Bayraklar { get; set; }


        public override string Bilgi()   //virtual methodu rzdim.
        {
            string BaseBilgi = base.Bilgi();
            BaseBilgi += "\n Bayraklar:";
            foreach (var item in Bayraklar)
            {
                BaseBilgi +=item;
            }
            return BaseBilgi;
        }

        public override string Saldir()
        {
            return "kilic";
        }
    }
}
