using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public class StavkaTiketa
    {
        public String OdigraniTip { get; set; }
        public Igra OdigranaIgra { get; set; }
        public String Stavka { get; set; }

        public StavkaTiketa(string ot, Igra oi)
        {
            if (ot.ToLower() == "2x") ot = "x2";
            if (ot.ToLower() == "x1") ot = "1x";
            OdigraniTip = ot.ToLower() ;
            OdigranaIgra = oi;
            Stavka = null;
        }
        public Boolean JeLiFiksni() {
            return Stavka == "Fiksni";
        }
        public Boolean JeLiDobitni()
        {
            return OdigranaIgra.ProvjeriJeLiDobitni(OdigraniTip);
        }

        public decimal Koeficijent()
        {
            foreach (var item in OdigranaIgra.koeficijenti)
            {
                if (item.tip.ToLower() == OdigraniTip)
                    return item.koeficijent;
            }

            return 0.0M;
        }
    }
}
