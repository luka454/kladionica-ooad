using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class Tenis : Igra
    {
        public String PrviProtivnik { get; set; }
        public String DrugiProtivnik { get; set; }
        public int PrviPoenaSetova { get; set; }
        public int DrugiPoenaSetova { get; set; }
        public Tenis(DateTime p, string n, StatusIgre si, string pp, string dp, int pps, int dps)
            : base(p, n, si)
        {
            PrviProtivnik = pp;
            DrugiProtivnik = dp;
            PrviPoenaSetova = pps;
            DrugiPoenaSetova = dps;
        }
        public Boolean provjeriTip(String tip) { return false; }
        public Boolean provjeriJeLiDobitni(String tip) { return false; }

        public override bool ProvjeriTip(string tip)
        {
            throw new NotImplementedException();
        }

        public override bool ProvjeriJeLiDobitni(string tip)
        {
            throw new NotImplementedException();
        }
    }
}
