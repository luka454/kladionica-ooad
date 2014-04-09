using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kladionica
{
    public abstract class Osoba
    {
        public int Password{ get; set; }
        public string Username{ get; set; }
        public string Prezime{ get; set; }
        public string Ime{ get; set; }
        public int ID{ get; set; }
    }
}
