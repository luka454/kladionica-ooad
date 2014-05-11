using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KladionicaKlase
{
    public abstract class Osoba
    {
        public int HashPassword{ get; set; }
        public string Username{ get; set; }
        public string Prezime{ get; set; }
        public string Ime{ get; set; }
        public int ID{ get; set; }

        public Osoba(int id, string i, string p, string u, int hp)
        {
            ID = id;
            Ime = i;
            Prezime = p;
            Username = u;
            HashPassword = hp;
        }
    }
}
