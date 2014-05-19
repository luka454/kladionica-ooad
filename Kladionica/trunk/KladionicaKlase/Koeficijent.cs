using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KladionicaKlase
{
    public class Koeficijent
    {
        public String tip { get; set; }
        public decimal koeficijent { get; set; }
        public Boolean dobitni { get; set; }
        public Koeficijent(string t, decimal k)
        {
            tip = t;
            koeficijent = k;
            dobitni = false;
        }
        public Boolean Dobitni
        {
            get { return dobitni; }
            set { dobitni = value; }
        }
        
    }
}
