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

        public StavkaTiketa(string odigraniTip, Igra odigranaIgra)
        {
            OdigraniTip = odigraniTip;
            OdigranaIgra = odigranaIgra;
            Stavka = null;
        }
        public Boolean JeLiFiksni() {
            return Stavka == "Fiksni";
        }
        public Boolean JeLiDobitni()
        {
            return OdigranaIgra.ProvjeriJeLiDobitni(OdigraniTip);
        }
    }
}
