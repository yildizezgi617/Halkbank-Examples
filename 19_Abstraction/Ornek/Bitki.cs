using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Abstraction.Ornek
{
    abstract class Bitki
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public string Renk { get; set; }

        public virtual string OzellikleriVer()
        {
            
            return $"Id:{Id},Ad:{Ad},Renk:{Renk}";
        }

        public virtual double YasamSuresiHesapla()
        {
            return 4;
        }




    }
}
