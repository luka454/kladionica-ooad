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
        public decimal koeficijent { get; set; }
        public Koeficijent(string t, decimal k)
        {
            tip = t;
            koeficijent = k;
        }
    }
}
