using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Abstraction.Models
{
    class WolfTeam: Oyun
    {
        public List<string> Haritalar { get; set; }
        public List<string> Klanlar { get; set; }
        public List<string> Modlar { get; set; }
        public List<string> Kurtlar { get; set; }

        public override string Saldir()
        {
            return "bicak";
        }
    }
}
