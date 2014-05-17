using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KladionicaKlase
{
    public class Koeficijent
    {
        public String tip;
        public float koeficijent;
        private bool dobitni;
        public Koeficijent(string t, float k)
        {
            tip = t;
            koeficijent = k;
            dobitni = false;
        }
        public bool Dobitni
        {
            get { return dobitni; }
            set { dobitni = value; }
        }
        
    }
}
