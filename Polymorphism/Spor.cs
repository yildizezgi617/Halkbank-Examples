using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
   abstract class Spor
    {
        public string Name { get; }
        public string Aciklama { get; }

        public virtual string Selamla() {

            return "merhaba";
        }

        public abstract string KurallariVer();

        public abstract int SureVer();









    }
}
