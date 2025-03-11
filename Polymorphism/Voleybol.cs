using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Voleybol : Spor, ITopSporlari

    {
        public override string KurallariVer()
        {
            throw new NotImplementedException();
        }

        public override int SureVer()
        {
            throw new NotImplementedException();
        }

        public string TopAgirliginiVer()
        {
            throw new NotImplementedException();
        }

        public string TopBoyutuVer()
        {
            throw new NotImplementedException();
        }
    }
}
