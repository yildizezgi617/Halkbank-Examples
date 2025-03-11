using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Golf : Spor
    {
        public int SopaSayisi { get; set; }
        public override string KurallariVer()
        {
            return " Bir oyuncu vuruş hazırlığına başladığında, diğer oyuncular hareket etmemeli ve konuşmamalıdır. ";
        }

        public override int SureVer()
        {
          return 300 ;
        }
    }
}
