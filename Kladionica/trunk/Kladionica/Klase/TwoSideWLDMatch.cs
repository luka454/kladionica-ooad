using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public abstract class TwoSideWLDMatch: Igra
    {
        public String Domacin { get; set; }
        public String Gost { get; set; }
        public int PoeniDomacin { get; set; }
        public int PoeniGost { get; set; }
        public TwoSideWLDMatch(DateTime p, string n, StatusIgre si, string d, string g, int pd, int pg)
            : base(p, n, si)
        {
            Domacin = d;
            Gost = g;
            PoeniDomacin = pd;
            PoeniGost = pg;
        }
    }
}
