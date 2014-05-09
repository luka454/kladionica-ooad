using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaKlase
{
    public abstract class TwoSideWLDMatch: Igra
    {
        public String Domacin { get; set; }
        public String Gost { get; set; }
        public int PoeniDomacin { get; set; }
        public int PoeniGost { get; set; }

    }
}
