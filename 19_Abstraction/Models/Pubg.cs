using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Abstraction.Models
{
    class Pubg:Oyun
    {
        public List<string> SilahCesitleri { get; set; }

        public override string Saldir()
        {
            return "tava";
        }
    }
}
