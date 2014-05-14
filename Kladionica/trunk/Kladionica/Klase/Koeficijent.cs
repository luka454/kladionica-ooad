using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kladionica
{
    public class Koeficijent
    {
        public int ID { get; set; }
        public String tip { get; set; }
        public float koeficijent { get; set; }
        public Koeficijent(string t, float k)
        {
            tip = t;
            koeficijent = k;
        }
    }
}
