using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkBank_Examples
{
   abstract class Araba
    {
        public int Marka { get; set; }
        public int Beygir { get; set; }
        public int Model { get; set; }


          //her araçta farklı şekilde o yuzden abstract. ve methodun içi dolu olmaz.her sınıf bunu impl ve override edip içini doldurmak zorunda
        public abstract string VitesArttır();

        public virtual string AraciCalistir()  //her araçta aynı şekilde çalıştığı için virtual değiştirmek istenirse override edilir.
        {
            return "Anahtarı kullanarak araç çalıştı";
        }




    }
}
