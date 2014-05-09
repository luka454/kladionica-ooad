using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaKlase
{
    public class Tenis : Igra
    {
        /// <summary>
        /// dodaj tipove za tenis
        /// </summary>
        public String PrviProtivnik { get; set; }
        public String DrugiProtivnik { get; set; }
        public int PrviPoenaSetova { get; set; }
        public int DrugiPoenaSetova { get; set; }
        public override bool ProvjeriTip(String tip) { return false; }
        public override bool ProvjeriJeLiDobitni(String tip) { return false; }

    }
}
