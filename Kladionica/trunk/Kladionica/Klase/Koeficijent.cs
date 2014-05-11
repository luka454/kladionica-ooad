using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kladionica
{
    public class Koeficijent
    {
        public String tip;
        public float koeficijent;
        public Koeficijent(string t, float k)
        {
            tip = t;
            koeficijent = k;
        }
    }
}
