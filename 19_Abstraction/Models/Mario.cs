using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Abstraction.Models
{
    class Mario :Oyun
    {
        public int TuglaSayisi { get; set; }
        public int MantarSayisi { get; set; }
        public List<string> Nesneler { get; set; }
        public int Seviye { get; set; }

        public override string Saldir()
        {
            return "kafayla";
        }
    }
}
